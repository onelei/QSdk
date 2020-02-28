//
//  EglsUnityPlugin.m
//  eglsUnityPlugin
//
//  Created by onelei on 16/9/28.
//  Copyright © 2016年 onelei. All rights reserved.
//

#import "SimpleUnityPluginC.h"
#import "SimpleUnityPlugin.h"
#import <UIKit/UIKit.h>

@interface SimpleUnityPlugin ()<NSObject>
@end

static SimpleUnityPlugin * instance = nil;
@implementation SimpleUnityPlugin

+ (SimpleUnityPlugin *)sharedInstance {
    @synchronized(self) {
        if (instance == nil) {
            instance = [[self alloc] init];
        }
    }
    return instance;
}


- (void)sdkLogin {
   // (NSString *)uid = "uid";
    //(NSString *)token = "token";
    //NSLog(@"sdk Login Success Call Back!\n uid is : %@\n token is : %@", uid, token);
    //NSString * par = [NSString stringWithFormat:@"%@,%@", uid, token];
    UnitySendMessage("SDKManager", "iosCallBack", "iOS successful");
}

@end


#if defined (__cplusplus)
extern "C"
{
#endif
    
    int _Add (int x,int y){
        return x+y;
    }

    int _Multiply (int x, int y){
        return x*y;
    }

    void _sendToUnity (){
        NSLog(@"sdk login");
        [[SimpleUnityPlugin sharedInstance] sdkLogin];
    }

    
#if defined (__cplusplus)
}
#endif