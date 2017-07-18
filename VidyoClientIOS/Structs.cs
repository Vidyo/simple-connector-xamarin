using System;
using ObjCRuntime;

namespace VidyoClientIOS
{
	[Native]
	public enum ChatMessageSenderType : long
	{
		None,
		Room,
		System,
		User
	}

	[Native]
	public enum ChatMessageType : long
	{
		Chat,
		MediaStart,
		MediaStop
	}

	[Native]
	public enum ChatMessageTypingIndication : long
	{
		Active,
		Composing,
		Gone,
		Inactive,
		None,
		Paused
	}

	[Native]
	public enum DeviceAudioSignalType : long
	{
		Unprocessed,
		Voice
	}

	[Native]
	public enum DeviceState : long
	{
		Added,
		ConfigureError,
		ConfigureSuccess,
		Controllable,
		DefaultChanged,
		Error,
		NotControllable,
		Paused,
		Removed,
		Resumed,
		Started,
		Stopped,
		Suspended,
		Unsuspended
	}

	[Native]
	public enum DeviceType : long
	{
		LocalCamera,
		LocalMicrophone,
		LocalMonitor,
		LocalRenderer,
		LocalSpeaker,
		LocalWindowShare,
		RemoteCamera,
		RemoteMicrophone,
		RemoteRenderer,
		RemoteSpeaker,
		RemoteWindowShare
	}

	[Native]
	public enum LocalRendererViewStyle : long
	{
		Default,
		Tiles
	}

	[Native]
	public enum MediaFormat : long
	{
		Mediaformat24bg,
		MEDIAFORMAT_2vuy,
		MEDIAFORMAT_420f,
		MEDIAFORMAT_420v,
		Argb,
		Bgra,
		Byr1,
		Byr2,
		Fl32,
		Hdyc,
		I420,
		In16,
		Jpeg,
		M420,
		Mjpg,
		Null,
		Nv12,
		Nv21,
		Rgba,
		Uyvy,
		Wpcm,
		Y8,
		Yu12,
		Yuy2,
		Yuyv,
		dmb1,
		dv,
		dv25,
		dv50,
		dvh1,
		dvhd,
		dvsd,
		dvsl,
		raw,
		yuv2,
		yuvs,
		yuvu
	}

	[Native]
	public enum LocalCameraPosition : long
	{
		Back,
		Front,
		Unknown
	}

	[Native]
	public enum LocalWindowShareState : long
	{
		Closed,
		Minimized,
		MiscError,
		NotVisible,
		Ok
	}

	[Native]
	public enum LocalMonitorState : long
	{
		MiscError,
		NotVisible,
		Ok
	}

	[Native]
	public enum LogLevel : long
	{
		Debug,
		Enter,
		Error,
		Fatal,
		Info,
		Invalid,
		Leave,
		Received,
		Sent,
		Warning
	}

	[Native]
	public enum NetworkInterfaceFamily : long
	{
		Ipv4,
		Ipv6,
		Unspecified
	}

	[Native]
	public enum NetworkInterfaceState : long
	{
		Down,
		Unknown,
		Up
	}

	[Native]
	public enum NetworkInterfaceTransportType : long
	{
		Data,
		Media,
		Signaling
	}

	[Native]
	public enum NetworkInterfaceType : long
	{
		Loopback,
		NotApplicable,
		Other,
		Tunneled,
		WiFi,
		Wired,
		Wwan
	}

	[Native]
	public enum ContactPresenceState : long
	{
		Available,
		Away,
		DoNotDisturb,
		ExtendedAway,
		InterestedInChat,
		Unavailable
	}

	[Native]
	public enum ContactSubscriptionState : long
	{
		AwaitingApproval,
		NotSubscribed,
		Preapproved,
		Subscribed,
		Unavailable
	}

	[Native]
	public enum RemoteCameraMode : long
	{
		Dynamic,
		Static
	}

	[Native]
	public enum RemoteCameraPosition : long
	{
		Back,
		Front,
		Unknown
	}

	[Native]
	public enum RemoteMicrophoneMode : long
	{
		Dynamic,
		Static
	}

	[Native]
	public enum ConnectorDisconnectReason : long
	{
		ConnectionLost,
		ConnectionTimeout,
		Disconnected,
		MiscError,
		MiscLocalError,
		MiscRemoteError,
		NoResponse,
		Terminated
	}

	[Native]
	public enum ConnectorFailReason : long
	{
		Banned,
		ConnectionFailed,
		ConnectionLost,
		ConnectionTimeout,
		InvalidResourceId,
		InvalidToken,
		MediaFailed,
		MediaNotEnabled,
		MiscError,
		MiscLocalError,
		MiscRemoteError,
		NoResponse,
		NoResponseFromResource,
		NotMember,
		ResourceFull,
		Terminated,
		UnableToCreateResource
	}

	[Native]
	public enum ConnectorMode : long
	{
		Background,
		Default,
		Foreground
	}

	[Native]
	public enum ConnectorState : long
	{
		Connected,
		ConnectingToResource,
		EnablingMedia,
		EstablishingConnection,
		FindingResource,
		Idle,
		Ready
	}

	[Native]
	public enum ConnectorViewStyle : long
	{
		Default,
		Tiles
	}
}
