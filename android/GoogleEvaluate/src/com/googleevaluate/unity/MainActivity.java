package com.googleevaluate.unity;
import com.unity3d.player.UnityPlayer;

import com.unity3d.player.UnityPlayerActivity; //引入头文件

import android.content.Intent;
import android.net.Uri;

public class MainActivity extends UnityPlayerActivity {
 
	public static int add(int x, int y) {
		return x + y;
	}

	public int Multiply(int x, int y) {
		return x * y;
	}

	public static void SendToUnity() {
		String msg = "Send successful ~~";
		UnityPlayer.UnitySendMessage("SDKManager", "AndroidMessage", msg);
	}
	
	public void Evaluate()
	{		
		String mAddress = "https://play.google.com/store/apps/details?id=" + "com.tencent.mm";//getPackageName();
		//https://play.google.com/store/apps/details?id=com.tencent.mm
		Intent marketIntent = new Intent(Intent.ACTION_VIEW);  //"android.intent.action.VIEW"
		marketIntent.setData(Uri.parse(mAddress ));  
		startActivity(marketIntent);
	}
	
}
