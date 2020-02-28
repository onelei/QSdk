//
//  QSdkUnityPlugin.h
//  QSdkUnityPlugin
//
//  Created by onelei on 16/9/28.
//  Copyright © 2016年 onelei. All rights reserved.
//

#ifndef QSdkUnityPlugin_h
#define QSdkUnityPlugin_h

#import <Foundation/Foundation.h>

@interface QSdkUnityPlugin : NSObject
+ (QSdkUnityPlugin *)sharedInstance;
- (void)sdkLogin;
@end

#endif /* QSdkUnityPlugin_h */
