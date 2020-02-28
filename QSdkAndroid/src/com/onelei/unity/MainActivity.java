package com.onelei.unity;
import java.util.Locale;

//import head file.
import com.unity3d.player.UnityPlayer;
import com.unity3d.player.UnityPlayerActivity; 

import android.content.Intent;
import android.net.Uri;
import android.os.Build;

public class MainActivity extends UnityPlayerActivity {
 
	public static int add(int x, int y) 
	{
		return x + y;
	}

	public int Multiply(int x, int y) 
	{
		return x * y;
	}

	public static void SdkMessage() 
	{
		String msg = "Send successful ~~";
		UnityPlayer.UnitySendMessage("SDKManager", "SdkMessage", msg);
	}
	
	//Google Evaluate
	public void Evaluate()
	{		
		String mAddress = "https://play.google.com/store/apps/details?id=" + "com.tencent.mm";
		//https://play.google.com/store/apps/details?id=com.tencent.mm
		Intent marketIntent = new Intent(Intent.ACTION_VIEW);//"android.intent.action.VIEW"
		marketIntent.setData(Uri.parse(mAddress ));  
		startActivity(marketIntent);
	}
	
	public String GetDeviceLanguage()
	{
		String language = Locale.getDefault().getLanguage();
		 //>=24 is Android 7.0 or high
        if (Build.VERSION.SDK_INT >=  24) 
        {
        	Locale local = getResources().getConfiguration().locale;
        	language = local.getLanguage();            
        } 
		return language;
	}
	
	public String GetDeviceCountry()
	{
        String country = Locale.getDefault().getCountry();
		 //>=24 is Android 7.0 or high
        if (Build.VERSION.SDK_INT >=  24) 
        {
        	Locale local = getResources().getConfiguration().locale;
        	country = local.getCountry();            
        } 
		return country;
	}
}
