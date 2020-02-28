//
//  EglsUnityPlugin.h
//  eglsUnityPlugin
//
//  Created by onelei on 16/9/28.
//  Copyright © 2016年 onelei. All rights reserved.
//

#ifndef SimpleUnityPlugin_h
#define SimpleUnityPlugin_h

#import <Foundation/Foundation.h>

@interface SimpleUnityPlugin : NSObject
+ (SimpleUnityPlugin *)sharedInstance;
- (void)sdkLogin;
@end

#endif /* SimpleUnityPlugin_h */
