using UnityEngine;
using System.Collections;
using System.Runtime.InteropServices;
using UnityEngine.UI;

public class SDKManager : MonoBehaviour {
    [SerializeField] private Text m_testAdd, m_testMult, m_testSend;
    // Use this for initialization
    void Start() {
        testAdd();
        testMult();
        testSend();
    }

    void testAdd() {
        var result = 0;
#if UNITY_IPHONE
		result = _Add(1,2);
#elif UNITY_ANDROID
        AndroidJavaClass ja = new AndroidJavaClass("com.unity3d.player.UnityPlayer");
        AndroidJavaObject jo = ja.GetStatic<AndroidJavaObject>("currentActivity");
        result = jo.CallStatic<int>("add", 1, 2);
#endif
        m_testAdd.text = result.ToString();

    }

    void testMult() {
        var result = 0;
#if UNITY_IPHONE
		result = _Multiply(3,4);
#elif UNITY_ANDROID
        AndroidJavaClass ja = new AndroidJavaClass("com.unity3d.player.UnityPlayer");
        AndroidJavaObject jo = ja.GetStatic<AndroidJavaObject>("currentActivity");
        result = jo.Call<int>("Multiply", 3, 4);
#endif
        m_testMult.text = result.ToString();
    }

    void testSend() {
#if UNITY_IPHONE
		_sendToUnity();
#elif UNITY_ANDROID
        AndroidJavaClass ja = new AndroidJavaClass("com.unity3d.player.UnityPlayer");
        AndroidJavaObject jo = ja.GetStatic<AndroidJavaObject>("currentActivity");
        jo.CallStatic("SendToUnity");
#endif

    }

    public void Evaluate()
    {
        Debug.Log("Unity------------- Evaluate");
        AndroidJavaClass ja = new AndroidJavaClass("com.unity3d.player.UnityPlayer");
        AndroidJavaObject jo = ja.GetStatic<AndroidJavaObject>("currentActivity");
        jo.Call("Evaluate");
        Debug.Log("Unity------------- Evaluate   end--------------");
    }


    public void AndroidMessage(string msg)
    {
        m_testSend.text = msg;
    }

    void iosCallBack(string msg){
		m_testSend.text = msg;
	}

	#if UNITY_IPHONE
	[DllImport("__Internal")]private static extern int _Add (int x,int y);
	[DllImport("__Internal")]private static extern int _Multiply (int x, int y);
	[DllImport("__Internal")]private static extern void _sendToUnity ();
	#endif
}