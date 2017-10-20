using System;
using UIKit;
using VidyoClient;
using AVFoundation;

namespace SimpleVidyoConnectorIOS
{
	public partial class ViewController : UIViewController, Connector.IConnect, Connector.IRegisterLocalCameraEventListener, Connector.IRegisterRemoteCameraEventListener
	{
		Connector vc = null;

		protected ViewController(IntPtr handle) : base(handle)
		{
			// Note: this .ctor should not contain any initialization logic.
		}

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();
			// Perform any additional setup after loading the view.

			// Authorize this app to use the microphone and camera
			AuthorizeMediaUse();

			// Initialize VidyoClient library
			bool status = ConnectorPKG.Initialize();
			Console.WriteLine("VidyoClientInitalize status = " + status);

			try
			{
				// Construct VidyoConnector
				vc = new Connector(videoView.Handle, Connector.ConnectorViewStyle.ConnectorviewstyleDefault, 15, "warning info@VidyoConnector info@VidyoClient", "", 0);

				// Register for local and remote camera event listeners
				if (!vc.RegisterLocalCameraEventListener(this))
					Console.WriteLine("RegisterLocalCameraEventListener failed");
				if (!vc.RegisterRemoteCameraEventListener(this))
					Console.WriteLine("RegisterRemoteCameraEventListener failed");
			}
			catch (Exception e)
			{
				Console.WriteLine(e);
			}

			// Register for OS notifications about this app running in background/foreground, etc.
			Foundation.NSNotificationCenter.DefaultCenter.AddObserver(UIApplication.DidEnterBackgroundNotification, AppDidEnterBackground);
			Foundation.NSNotificationCenter.DefaultCenter.AddObserver(UIApplication.WillEnterForegroundNotification, AppWillEnterForeground);
			Foundation.NSNotificationCenter.DefaultCenter.AddObserver(UIApplication.WillTerminateNotification, AppWillTerminate);
		}

		// The device interface orientation has changed
		public override void DidRotate(UIInterfaceOrientation fromInterfaceOrientation)
		{
			base.DidRotate(fromInterfaceOrientation);
			vc.ShowViewAt(videoView.Handle, 0, 0, (uint)videoView.Frame.Width, (uint)videoView.Frame.Height);
		}

		public override void DidReceiveMemoryWarning()
		{
			base.DidReceiveMemoryWarning();
			// Release any cached data, images, etc that aren't in use.
		}

		async System.Threading.Tasks.Task AuthorizeMediaUse()
		{
			var authorizationStatus = AVCaptureDevice.GetAuthorizationStatus(AVMediaType.Video);

			if (authorizationStatus != AVAuthorizationStatus.Authorized)
			{
				await AVCaptureDevice.RequestAccessForMediaTypeAsync(AVMediaType.Video);
			}

			authorizationStatus = AVCaptureDevice.GetAuthorizationStatus(AVMediaType.Audio);
			if (authorizationStatus != AVAuthorizationStatus.Authorized)
			{
				await AVCaptureDevice.RequestAccessForMediaTypeAsync(AVMediaType.Audio);
			}
		}

		// The app is about to enter into the background
		void AppDidEnterBackground(Foundation.NSNotification notification)
		{
			Console.WriteLine("Received a notification UIApplication: ", notification);
			vc.SetMode(Connector.ConnectorMode.ConnectormodeBackground);
		}

		// The app is about to enter into the foreground
		void AppWillEnterForeground(Foundation.NSNotification notification)
		{
			Console.WriteLine("Received a notification UIApplication: ", notification);
			vc.SetMode(Connector.ConnectorMode.ConnectormodeForeground);
		}

		// The app is terminating
		void AppWillTerminate(Foundation.NSNotification notification)
		{
			Console.WriteLine("Received a notification UIApplication: ", notification);

			// Deregister from any/all notifications.
			Foundation.NSNotificationCenter.DefaultCenter.RemoveObserver(this);

			// Set the VidyoConnector to nil so it is garbage collected
			vc = null;

			// Uninitialize VidyoConnector
			ConnectorPKG.Uninitialize();
		}

		// Delegates when the buttons are clicked

		partial void ShowPreview(UIButton sender)
		{
			vc.ShowViewAt(videoView.Handle, 0, 0, (uint)videoView.Frame.Width, (uint)videoView.Frame.Height);
		}

		partial void CycleCamera(UIButton sender)
		{
			vc.CycleCamera();
		}

		partial void ConnectButton(UIButton sender)
		{
			string token = ""; //INSERT VALID TOKEN
			vc.Connect("prod.vidyo.io", token, "Xamarin.IOS User", "demoroom", this);
		}

		partial void DisconnectButton(UIButton sender)
		{
			vc.Disconnect();
		}

		// IConnect callbacks

		public void OnDisconnected(Connector.ConnectorDisconnectReason reason)
		{
			Console.WriteLine("OnDisconnected: " + reason);
		}
		public void OnFailure(Connector.ConnectorFailReason reason)
		{
			Console.WriteLine("OnFailure: " + reason);
		}
		public void OnSuccess()
		{
			Console.WriteLine("OnSuccess");
		}

		// IRegisterLocalCameraEventListener callbacks
		public void OnLocalCameraAdded(LocalCamera localCamera)
		{
			Console.WriteLine("OnLocalCameraAdded");
		}

		public void OnLocalCameraRemoved(LocalCamera localCamera)
		{
			Console.WriteLine("OnLocalCameraRemoved");
		}

		public void OnLocalCameraSelected(LocalCamera localCamera)
		{
			Console.WriteLine("OnLocalCameraSelected");
		}

		public void OnLocalCameraStateUpdated(LocalCamera localCamera, VidyoClient.Device.DeviceState state)
		{
			Console.WriteLine("OnLocalCameraStateUpdated");
		}

		// IRegisterRemoteCameraEventListener
		public void OnRemoteCameraAdded(RemoteCamera remoteCamera, Participant participant)
		{
			Console.WriteLine("OnRemoteCameraAdded: " + remoteCamera.GetName());
		}
		public void OnRemoteCameraRemoved(RemoteCamera remoteCamera, Participant participant)
		{
			Console.WriteLine("OnRemoteCameraRemoved: " + remoteCamera.GetName());
		}
		public void OnRemoteCameraStateUpdated(RemoteCamera remoteCamera, Participant participant, Device.DeviceState state)
		{
			Console.WriteLine("OnRemoteCameraStateUpdated: " + remoteCamera.GetName() + " , state : " + state);
		}
	}
}
