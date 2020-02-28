# QSdkAndroid
Using android studio creating android plugin for Unity. 

## SoftWare

Unity version : 5.4.0p4


## Steps
**1**, Create an empty Android Project.
![unity icon](./Image/project1.png)
![unity icon](./Image/project2.png)
![unity icon](./Image/project3.png)
![unity icon](./Image/project4.png)

**2**, Create an empty Android Project.
![unity icon](./Image/plugin1.png)
![unity icon](./Image/plugin2.png)
![unity icon](./Image/plugin3.png)

**3**, Copy the unity classes.jar   
win:  

![unity icon](./Image/unityClassesJar_win.png)  

mac:

![unity icon](./Image/setup1.png)
to
![unity icon](./Image/setup2.png)
dictory.

**4**, include the classes.jar 
![unity icon](./Image/setup3.png)
![unity icon](./Image/setup4.png)
![unity icon](./Image/setup5.png)

**5**, editor the android class 
![unity icon](./Image/unityplugin1.png)
![unity icon](./Image/unityplugin2.png)
![unity icon](./Image/unityplugin3.png)

```
package com.onelei.unity;

import com.unity3d.player.UnityPlayer;
import com.unity3d.player.UnityPlayerActivity; //引入头文件

public class MainActivity extends UnityPlayerActivity{
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

```
**6**, compile the android project 
![unity icon](./Image/build1.png)

Terminal execute 

```
./gradlew buildJar
```
![unity icon](./Image/build2.png)
now you can find "onelei_simpleSdk.jar" under the "unityplugin\build\libs".

![unity icon](./Image/build3.png)

**7**, editor the unity project, create floder "Plugins/Android" under the "Assets". 
And create "AndroidManifest.xml" under "Plugins/Android".

![unity icon](./Image/build1.png)

**8**, editor the "AndroidManifest.xml",in the unity project. 

```
<manifest xmlns:android="http://schemas.android.com/apk/res/android" >
    <application
        android:allowBackup="true"
        android:icon="@drawable/app_icon"
        android:label="@string/app_name"
        android:supportsRtl="true">
        
        <activity 
            android:name="com.onelei.unity.MainActivity"  
            android:configChanges="locale|keyboardHidden|orientation|screenSize"
            android:screenOrientation="landscape"
            android:theme="@android:style/Theme.NoTitleBar.Fullscreen" >
            <intent-filter>
                <action android:name="android.intent.action.MAIN" />

                <category android:name="android.intent.category.LAUNCHER" />
            </intent-filter>
        </activity>  
        
    </application>

</manifest>

``` 
 
## How to use

Here are the simple sdk unity project ![simpleSdk](https://github.com/onelei/simpleSdk).

