using UnityEngine;
using System.Collections;
using System.Runtime.InteropServices;
using UnityEngine.UI;

public class SDKManager : MonoBehaviour
{
    public Text Text_Add;
    public Text Text_Mult;
    public Text Text_Send;
    public Button Button_GameEvaluate;

    private void Awake()
    {
        Button_GameEvaluate.onClick.AddListener(OnClickEvaluate);
    }

    // Use this for initialization
    void Start()
    {
        testAdd();
        testMult();
        //testSend();
        GetDeviceLanguage();
    }

    void testAdd()
    {
        var result = 0;
#if UNITY_IPHONE
		result = _Add(1,2);
#elif UNITY_ANDROID
        AndroidJavaClass ja = new AndroidJavaClass("com.unity3d.player.UnityPlayer");
        AndroidJavaObject jo = ja.GetStatic<AndroidJavaObject>("currentActivity");
        result = jo.CallStatic<int>("add", 1, 2);
#endif
        Text_Add.text = result.ToString();

    }

    void testMult()
    {
        var result = 0;
#if UNITY_IPHONE
		result = _Multiply(3,4);
#elif UNITY_ANDROID
        AndroidJavaClass ja = new AndroidJavaClass("com.unity3d.player.UnityPlayer");
        AndroidJavaObject jo = ja.GetStatic<AndroidJavaObject>("currentActivity");
        result = jo.Call<int>("Multiply", 3, 4);
#endif
        Text_Mult.text = result.ToString();
    }

    void testSend()
    {
#if UNITY_IPHONE
		_sendToUnity();
#elif UNITY_ANDROID
        AndroidJavaClass ja = new AndroidJavaClass("com.unity3d.player.UnityPlayer");
        AndroidJavaObject jo = ja.GetStatic<AndroidJavaObject>("currentActivity");
        jo.CallStatic("SdkMessage");
#endif

    }

    void OnClickEvaluate()
    {
        Debug.Log("Unity------------- Evaluate");

#if UNITY_ANDROID
        AndroidJavaClass ja = new AndroidJavaClass("com.unity3d.player.UnityPlayer");
        AndroidJavaObject jo = ja.GetStatic<AndroidJavaObject>("currentActivity");
        jo.Call("Evaluate");
#endif
        Debug.Log("Unity------------- Evaluate   end--------------");
    }

    public void GetDeviceLanguage()
    {
        Debug.Log("Unity------------- GetDeviceLanguage  Start");
        AndroidJavaClass ja = new AndroidJavaClass("com.unity3d.player.UnityPlayer");
        AndroidJavaObject jo = ja.GetStatic<AndroidJavaObject>("currentActivity");
        string deviceLanguage = jo.Call<string>("GetDeviceLanguage");

        Debug.Log("Unity------------- GetDeviceLanguage   End--------------");
        Text_Add.text = Application.systemLanguage.ToString();
        Text_Send.text = deviceLanguage;
    }

    public void SdkMessage(string msg)
    {
        Text_Send.text = msg;
    }

    void iosCallBack(string msg)
    {
        Text_Send.text = msg;
    }

#if UNITY_IPHONE
	[DllImport("__Internal")]private static extern int _Add (int x,int y);
	[DllImport("__Internal")]private static extern int _Multiply (int x, int y);
	[DllImport("__Internal")]private static extern void _sendToUnity ();
#endif
}