package com.simplesdk.onelei.unityplugin;

import com.unity3d.player.UnityPlayer;
import com.unity3d.player.UnityPlayerActivity; //引入头文件

/**
 * Created by onelei on 16/9/28.
 */
public class UnityPlugin extends UnityPlayerActivity{
    public static int add(int x, int y)
    {
        return  x+y;
    }

    public int Multiply(int x, int y) { return x*y; }

    public static void sendToUnity(){
        String msg = "send successful ~~";
        UnityPlayer.UnitySendMessage("SDKManager","androidMessgae",msg);
    }
}
