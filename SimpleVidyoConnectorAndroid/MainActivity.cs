using Android.App;
using Android.Widget;
using Android.OS;
using System;
using Android.Content.PM;
using Com.Vidyo.VidyoClient.Connector;
using Com.Vidyo.VidyoClient.Device;
using Com.Vidyo.VidyoClient.Endpoint;

namespace SimpleVidyoConnector
{
[Activity(Label = "SimpleVidyoConnector", MainLauncher = true, Icon = "@mipmap/icon", ConfigurationChanges = ConfigChanges.Orientation, ScreenOrientation = ScreenOrientation.Portrait)]
	public class MainActivity : Activity, VidyoConnector.IConnect, VidyoConnector.IRegisterLocalCameraEventListener, VidyoConnector.IRegisterRemoteCameraEventListener
	{
		VidyoConnector vc;
		FrameLayout videoFrame;

		protected override void OnCreate(Bundle savedInstanceState)
		{
			base.OnCreate(savedInstanceState);

			// Set our view from the "main" layout resource
			SetContentView(Resource.Layout.Main);

			// Set application context and initialize VidyoClient library
			Connector.SetApplicationUIContext(this);
			Connector.Initialize();

			videoFrame = FindViewById<FrameLayout>(Resource.Id.videoFrame);
			try
			{
				// Construct VidyoConnector
				vc = new VidyoConnector(videoFrame, VidyoConnector.VidyoConnectorViewStyle.VIDYOCONNECTORVIEWSTYLEDefault, 16, "warning info@VidyoConnector info@VidyoClient", "", 0);

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
					vc.ShowViewAt(videoFrame, 0, 0, videoFrame.Width, videoFrame.Height);
				};
				connectButton.Click += delegate
				{
string token = "cHJvdmlzaW9uAFBoaWxseVdlYkAyOTkyYzQudmlkeW8uaW8ANjM2Njc1NzkyNTIAAGNlMDM3MDA4MTk3NzJkMjUxNWYxNDhlMjYyYjYwYTM4MjM5MGFhN2E1NWRiOTM1NGY1MGFiNjVmOWRiN2Q4NjhmODQyYTA5ZDRiYTY2Y2FhNzA1ZTExNDAzMGUzYTk3NA=="; //INSERT VALID TOKEN
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
			vc.SetMode(VidyoConnector.VidyoConnectorMode.VIDYOCONNECTORMODEForeground);
		}

		// The app is going to the background
		protected override void OnStop()
		{
			base.OnStop();
			vc.SetMode(VidyoConnector.VidyoConnectorMode.VIDYOCONNECTORMODEBackground);
		}

		// The app is terminating
		protected override void OnDestroy()
		{
			vc.Disable();
			Connector.Uninitialize();
			base.OnDestroy();
		}

		// IConnect callbacks
		public void OnDisconnected(VidyoConnector.VidyoConnectorDisconnectReason p0)
		{
			Console.WriteLine("OnDisconnected: " + p0);
		}
		public void OnFailure(VidyoConnector.VidyoConnectorFailReason p0)
		{
			Console.WriteLine("OnFailure: " + p0);
		}
		public void OnSuccess()
		{
			Console.WriteLine("OnSuccess");
		}

		// IRegisterLocalCameraEventListener callbacks
		public void OnLocalCameraAdded(VidyoLocalCamera localCamera)
		{
			Console.WriteLine("OnLocalCameraAdded: " + localCamera.Name);
		}
		public void OnLocalCameraRemoved(VidyoLocalCamera localCamera)
		{
			Console.WriteLine("OnLocalCameraRemoved: " + localCamera.Name);
		}
		public void OnLocalCameraSelected(VidyoLocalCamera localCamera)
		{
			Console.WriteLine("OnLocalCameraSelected: " + localCamera.Name);
		}
		public void OnLocalCameraStateUpdated(VidyoLocalCamera localCamera, VidyoDevice.VidyoDeviceState state)
		{
			Console.WriteLine("OnLocalCameraStateUpdated: " + localCamera.Name + " , state : " + state);
		}

		// IRegisterRemoteCameraEventListener
		public void OnRemoteCameraAdded(VidyoRemoteCamera remoteCamera, VidyoParticipant participant)
		{
			Console.WriteLine("OnRemoteCameraAdded: " + remoteCamera.Name);
		}
		public void OnRemoteCameraRemoved(VidyoRemoteCamera remoteCamera, VidyoParticipant participant)
		{
			Console.WriteLine("OnRemoteCameraRemoved: " + remoteCamera.Name);
		}
		public void OnRemoteCameraStateUpdated(VidyoRemoteCamera remoteCamera, VidyoParticipant participant, VidyoDevice.VidyoDeviceState state)
		{
			Console.WriteLine("OnRemoteCameraStateUpdated: " + remoteCamera.Name + " , state : " + state);
		}
	}
}

