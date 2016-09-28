using UnityEngine;
using System.Collections;

public class SDKManager : MonoBehaviour {
	[SerializeField] private UILabel m_testAdd,m_testMult,m_testSend;
	// Use this for initialization
	void Start () {
		testAdd ();
		testMult ();
		testSend ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void testAdd(){
		AndroidJavaClass ja = new AndroidJavaClass("com.unity3d.player.UnityPlayer");  
		AndroidJavaObject jo = ja.GetStatic<AndroidJavaObject>("currentActivity");  
		var result = jo.CallStatic<int>("add",1,2);  
		m_testAdd.text = result.ToString();  
	}

	void testMult(){
		AndroidJavaClass ja = new AndroidJavaClass("com.unity3d.player.UnityPlayer");  
		AndroidJavaObject jo = ja.GetStatic<AndroidJavaObject>("currentActivity");  
		var result = jo.Call<int>("Multiply",3,4);  
		m_testMult.text = result.ToString();  
	}

	void testSend(){
		AndroidJavaClass ja = new AndroidJavaClass("com.unity3d.player.UnityPlayer");  
		AndroidJavaObject jo = ja.GetStatic<AndroidJavaObject>("currentActivity");  
		jo.CallStatic("sendToUnity");  
	}

	void androidMessgae(string msg){
		m_testSend.text = msg;
	}
}
