//
//  SimpleUnityPluginC.h
//  SimpleUnityPlugin
//
//  Created by onelei on 16/9/28.
//  Copyright © 2016年 onelei. All rights reserved.
//

#ifndef SimpleUnityPluginC_h
#define SimpleUnityPluginC_h

#import <Foundation/Foundation.h>


#ifdef __cplusplus
extern "C"
{
#endif
    
    int _Add (int x,int y);
    int _Multiply (int x, int y);
    void _sendToUnity ();
   
#ifdef __cplusplus
}
#endif

#endif /* SimpleUnityPluginC_h */
