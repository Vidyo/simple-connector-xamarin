// WARNING
//
// This file has been generated automatically by Xamarin Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;

namespace SimpleVidyoConnectorIOS
{
    [Register ("ViewController")]
    partial class ViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIView videoView { get; set; }

        [Action ("ConnectButton:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void ConnectButton (UIKit.UIButton sender);

        [Action ("CycleCamera:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void CycleCamera (UIKit.UIButton sender);

        [Action ("DisconnectButton:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void DisconnectButton (UIKit.UIButton sender);

        [Action ("ShowPreview:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void ShowPreview (UIKit.UIButton sender);

        void ReleaseDesignerOutlets ()
        {
            if (videoView != null) {
                videoView.Dispose ();
                videoView = null;
            }
        }
    }
}