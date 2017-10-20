using Android.App;
using Android.Widget;
using Android.OS;
using System;
using Android.Content.PM;
using VidyoClient;

namespace SimpleVidyoConnector
{
[Activity(Label = "SimpleVidyoConnector", MainLauncher = true, Icon = "@mipmap/icon", ConfigurationChanges = ConfigChanges.Orientation, ScreenOrientation = ScreenOrientation.Portrait)]
	public class MainActivity : Activity, Connector.IConnect, Connector.IRegisterLocalCameraEventListener, Connector.IRegisterRemoteCameraEventListener
	{
		Connector vc;
		FrameLayout videoFrame;

		protected override void OnCreate(Bundle savedInstanceState)
		{
			base.OnCreate(savedInstanceState);

			// Set our view from the "main" layout resource
			SetContentView(Resource.Layout.Main);

			// Set application context and initialize VidyoClient library
			ConnectorPKG.SetApplicationUIContext(this);
			ConnectorPKG.Initialize();

			videoFrame = FindViewById<FrameLayout>(Resource.Id.videoFrame);
			try
			{
				// Construct VidyoConnector
				vc = new Connector(videoFrame.Handle, Connector.ConnectorViewStyle.ConnectorviewstyleDefault, 15, "warning info@VidyoConnector info@VidyoClient", "", 0);

				// Register for local and remote camera event listeners
				if (!vc.RegisterLocalCameraEventListener(this))
					Console.WriteLine("RegisterLocalCameraEventListener failed");
				if (!vc.RegisterRemoteCameraEventListener(this))
					Console.WriteLine("RegisterRemoteCameraEventListener failed");

				// Get our buttons from the layout resource and attach an event to each button 
				Button showPreviewButton = FindViewById<Button>(Resource.Id.showPreviewButton);
				Button connectButton = FindViewById<Button>(Resource.Id.connectButton);
				Button disconnectButton = FindViewById<Button>(Resource.Id.disconnectButton);
				Button cycleCameraButton = FindViewById<Button>(Resource.Id.cycleCameraButton);

				// Delegates when the buttons are clicked
				showPreviewButton.Click += delegate
				{
					vc.ShowViewAt(videoFrame.Handle, 0, 0, (uint)videoFrame.Width, (uint)videoFrame.Height);
				};
				connectButton.Click += delegate
				{
					string token = ""; //INSERT VALID TOKEN
					vc.Connect("prod.vidyo.io", token, "Xamarin.Android User", "demoroom", this);
				};
				disconnectButton.Click += delegate
				{
					vc.Disconnect();
				};
				cycleCameraButton.Click += delegate
				{
					vc.CycleCamera();
				};
			}
			catch (Exception e)
			{
				Console.WriteLine(e);
			}
		}

		// The app is coming into the foreground
		protected override void OnRestart()
		{
			base.OnRestart();
			vc.SetMode(Connector.ConnectorMode.ConnectormodeForeground);
		}

		// The app is going to the background
		protected override void OnStop()
		{
			base.OnStop();
			vc.SetMode(Connector.ConnectorMode.ConnectormodeBackground);
		}

		// The app is terminating
		protected override void OnDestroy()
		{
			vc.Disable();
			ConnectorPKG.Uninitialize();
			base.OnDestroy();
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

