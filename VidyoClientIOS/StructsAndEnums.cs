using System;
using ObjCRuntime;

namespace VidyoClientIOS
{
	[Native]
	public enum ChatMessageSenderType : long
	{
		User,
		Room,
		System,
		None
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
		Paused,
		None
	}

	[Native]
	public enum DeviceAudioSignalType : long
	{
		Voice,
		Unprocessed
	}

	[Native]
	public enum DeviceState : long
	{
		Added,
		Removed,
		Started,
		Stopped,
		Suspended,
		Unsuspended,
		InUse,
		Available,
		Paused,
		Resumed,
		Controllable,
		NotControllable,
		DefaultChanged,
		ConfigureSuccess,
		ConfigureError,
		Error
	}

	[Native]
	public enum DeviceType : long
	{
		LocalCamera,
		LocalMicrophone,
		LocalMonitor,
		LocalWindowShare,
		LocalSpeaker,
		LocalRenderer,
		RemoteCamera,
		RemoteMicrophone,
		RemoteWindowShare,
		RemoteSpeaker,
		RemoteRenderer
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
		In16,
		Fl32,
		Null,
		Wpcm,
		I420,
		Yu12,
		Yuyv,
		Yuy2,
		yuvs,
		MEDIAFORMAT_2vuy,
		Uyvy,
		Hdyc,
		yuv2,
		yuvu,
		Nv12,
		Nv21,
		Mediaformat24bg,
		raw,
		Bgra,
		Rgba,
		Argb,
		Byr1,
		Byr2,
		Jpeg,
		Mjpg,
		dmb1,
		dvsd,
		dvhd,
		dvsl,
		dv25,
		dv50,
		dvh1,
		dv,
		M420,
		MEDIAFORMAT_420f,
		MEDIAFORMAT_420v,
		Y8
	}

	[Native]
	public enum LocalCameraPosition : long
	{
		Unknown,
		Front,
		Back
	}

	[Native]
	public enum LocalCameraTradeOffProfile : long
	{
		High,
		Medium,
		Low
	}

	[Native]
	public enum LocalWindowShareState : long
	{
		Ok,
		NotVisible,
		Minimized,
		Closed,
		MiscError
	}

	[Native]
	public enum LocalMonitorState : long
	{
		Ok,
		NotVisible,
		MiscError
	}

	[Native]
	public enum LogLevel : long
	{
		Fatal,
		Error,
		Warning,
		Info,
		Debug,
		Sent,
		Received,
		Enter,
		Leave,
		Invalid
	}

	[Native]
	public enum NetworkInterfaceFamily : long
	{
		Unspecified,
		Ipv4,
		Ipv6
	}

	[Native]
	public enum NetworkInterfaceState : long
	{
		Unknown,
		Up,
		Down
	}

	[Native]
	public enum NetworkInterfaceTransportType : long
	{
		Signaling,
		Media,
		Data
	}

	[Native]
	public enum NetworkInterfaceType : long
	{
		Wired,
		WiFi,
		Wwan,
		Loopback,
		Tunneled,
		Other,
		NotApplicable
	}

	[Native]
	public enum ContactPresenceState : long
	{
		Unavailable,
		DoNotDisturb,
		ExtendedAway,
		Away,
		Available,
		InterestedInChat
	}

	[Native]
	public enum ContactSubscriptionState : long
	{
		Unavailable,
		NotSubscribed,
		Preapproved,
		AwaitingApproval,
		Subscribed
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
		Unknown,
		Front,
		Back
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
		Disconnected,
		ConnectionLost,
		ConnectionTimeout,
		NoResponse,
		Terminated,
		MiscLocalError,
		MiscRemoteError,
		MiscError
	}

	[Native]
	public enum ConnectorFailReason : long
	{
		ConnectionFailed,
		ConnectionLost,
		ConnectionTimeout,
		NoResponse,
		Terminated,
		InvalidToken,
		UnableToCreateResource,
		NoResponseFromResource,
		InvalidResourceId,
		ResourceFull,
		NotMember,
		Banned,
		MediaNotEnabled,
		MediaFailed,
		MiscLocalError,
		MiscRemoteError,
		MiscError
	}

	[Native]
	public enum ConnectorMode : long
	{
		Default,
		Foreground,
		Background
	}

	[Native]
	public enum ConnectorState : long
	{
		Idle,
		Ready,
		EstablishingConnection,
		FindingResource,
		ConnectingToResource,
		EnablingMedia,
		Connected
	}

	[Native]
	public enum ConnectorTradeOffProfile : long
	{
		High,
		Medium,
		Low
	}

	[Native]
	public enum ConnectorViewStyle : long
	{
		Default,
		Tiles
	}
}
