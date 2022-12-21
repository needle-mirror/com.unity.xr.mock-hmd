#import <Foundation/Foundation.h>
#include "IUnityInterface.h"

#ifdef __cplusplus
extern "C" {
#endif

void UNITY_INTERFACE_EXPORT UNITY_INTERFACE_API UnityPluginLoad(IUnityInterfaces* unityInterfaces);

#ifdef __cplusplus
} // extern "C"
#endif

@interface UnityMockHMD : NSObject

+ (void)loadPlugin;

@end

@implementation UnityMockHMD

+ (void)loadPlugin
{
    UnityRegisterRenderingPluginV5(UnityPluginLoad, NULL);
}

@end
