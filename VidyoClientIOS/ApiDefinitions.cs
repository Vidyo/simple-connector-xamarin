using System;
using Foundation;

namespace VidyoClientIOS
{
	// @interface AudioFrame : NSObject
	[BaseType (typeof(NSObject))]
	interface AudioFrame
	{
		// -(void)dealloc;
		[Export ("dealloc")]
		void Dealloc ();

		// -(NSString *)GetFormat;
		[Export ("GetFormat")]
		string GetFormat();

		// -(id)initWithObject:(void *)rPtr;
		[Export ("initWithObject:")]
		IntPtr Constructor (ref IntPtr rPtr);

		// -(void *)GetObjectPtr;
		[Export ("GetObjectPtr")]
		IntPtr GetObjectPtr();
	}

	// @interface ChatMessage : NSObject
	[BaseType (typeof(NSObject))]
	interface ChatMessage
	{
	}

	// @interface Device : NSObject
	[BaseType (typeof(NSObject))]
	interface Device
	{
		// -(void)dealloc;
		[Export ("dealloc")]
		void Dealloc ();

		// -(BOOL)DerivedEqual;
		[Export ("DerivedEqual")]
		bool DerivedEqual();

		// -(NSString *)GetId;
		[Export ("GetId")]
		string GetId();

		// -(NSString *)GetName;
		[Export ("GetName")]
		string GetName();

		// -(DeviceType)GetType;
		[Export ("GetType")]
		DeviceType GetTypeXamarin();

		// -(id)initWithObject:(void *)rPtr;
		[Export ("initWithObject:")]
		IntPtr Constructor (ref IntPtr rPtr);

		// -(void *)GetObjectPtr;
		[Export ("GetObjectPtr")]
		IntPtr GetObjectPtr();
	}

	// @interface LocalRenderer : NSObject
	[BaseType (typeof(NSObject))]
	interface LocalRenderer
	{
		// -(void)dealloc;
		[Export ("dealloc")]
		void Dealloc ();

		// -(NSString *)GetId;
		[Export ("GetId")]
		string GetId();

		// -(NSString *)GetName;
		[Export ("GetName")]
		string GetName();

		// -(BOOL)IsPaused;
		[Export ("IsPaused")]
		bool IsPaused();

		// -(void)Pause;
		[Export ("Pause")]
		void Pause ();

		// -(void)Resume;
		[Export ("Resume")]
		void Resume ();

		// -(BOOL)SetMaxStreams:(unsigned int)numStreams;
		[Export ("SetMaxStreams:")]
		bool SetMaxStreams (uint numStreams);

		// -(BOOL)SetPosition:(int)x Y:(int)y Width:(unsigned int)width Height:(unsigned int)height;
		[Export ("SetPosition:Y:Width:Height:")]
		bool SetPosition (int x, int y, uint width, uint height);

		// -(id)initWithObject:(void *)rPtr;
		[Export ("initWithObject:")]
		IntPtr Constructor (ref IntPtr rPtr);

		// -(void *)GetObjectPtr;
		[Export ("GetObjectPtr")]
		IntPtr GetObjectPtr();
	}

	// @interface RemoteRenderer : NSObject
	[BaseType (typeof(NSObject))]
	interface RemoteRenderer
	{
		// -(void)dealloc;
		[Export ("dealloc")]
		void Dealloc ();

		// -(NSString *)GetId;
		[Export ("GetId")]
		string GetId();

		// -(NSString *)GetName;
		[Export ("GetName")]
		string GetName();

		// -(id)initWithObject:(void *)rPtr;
		[Export ("initWithObject:")]
		IntPtr Constructor (ref IntPtr rPtr);

		// -(void *)GetObjectPtr;
		[Export ("GetObjectPtr")]
		IntPtr GetObjectPtr();
	}

	// @interface VideoCapability : NSObject
	[BaseType (typeof(NSObject))]
	interface VideoCapability
	{
	}

	// @interface VideoFrameIntervalRange : NSObject
	[BaseType (typeof(NSObject))]
	interface VideoFrameIntervalRange
	{
	}

	// @interface TimeRange : NSObject
	[BaseType (typeof(NSObject))]
	interface TimeRange
	{
	}

	// @interface LocalCamera : NSObject
	[BaseType (typeof(NSObject))]
	interface LocalCamera
	{
		// -(void)dealloc;
		[Export ("dealloc")]
		void Dealloc ();

		// -(long)AddToLocalRenderer:(LocalRenderer *)localRenderer;
		[Export ("AddToLocalRenderer:")]
		nint AddToLocalRenderer (LocalRenderer localRenderer);

		// -(BOOL)AddToRemoteRenderer:(RemoteRenderer *)remoteRenderer;
		[Export ("AddToRemoteRenderer:")]
		bool AddToRemoteRenderer (RemoteRenderer remoteRenderer);

		// -(BOOL)AllowRemoteCameraControl:(BOOL)allow;
		[Export ("AllowRemoteCameraControl:")]
		bool AllowRemoteCameraControl (bool allow);

		// -(BOOL)ControlPTZ:(int)pan Tilt:(int)tilt Zoom:(int)zoom;
		[Export ("ControlPTZ:Tilt:Zoom:")]
		bool ControlPTZ (int pan, int tilt, int zoom);

		// -(LocalCameraTradeOffProfile)GetFramerateTradeOffProfile;
		[Export ("GetFramerateTradeOffProfile")]
		LocalCameraTradeOffProfile GetFramerateTradeOffProfile();

		// -(NSString *)GetId;
		[Export ("GetId")]
		string GetId();

		// -(NSString *)GetName;
		[Export ("GetName")]
		string GetName();

		// -(LocalCameraPosition)GetPosition;
		[Export ("GetPosition")]
		LocalCameraPosition GetPosition();

		// -(NSString *)GetPreviewLabel;
		[Export ("GetPreviewLabel")]
		string GetPreviewLabel();

		// -(LocalCameraTradeOffProfile)GetResolutionTradeOffProfile;
		[Export ("GetResolutionTradeOffProfile")]
		LocalCameraTradeOffProfile GetResolutionTradeOffProfile();

		// -(BOOL)GetVideoCapabilities:(NSMutableArray *)capabilities;
		[Export ("GetVideoCapabilities:")]
		bool GetVideoCapabilities (NSMutableArray capabilities);

		// -(BOOL)IsControlDigital;
		[Export ("IsControlDigital")]
		bool IsControlDigital();

		// -(BOOL)IsPaused;
		[Export ("IsPaused")]
		bool IsPaused();

		// -(BOOL)IsSuspended;
		[Export ("IsSuspended")]
		bool IsSuspended();

		// -(BOOL)RemoveFromLocalRenderer:(LocalRenderer *)localRenderer;
		[Export ("RemoveFromLocalRenderer:")]
		bool RemoveFromLocalRenderer (LocalRenderer localRenderer);

		// -(BOOL)RemoveFromRemoteRenderer:(RemoteRenderer *)remoteRenderer;
		[Export ("RemoveFromRemoteRenderer:")]
		bool RemoveFromRemoteRenderer (RemoteRenderer remoteRenderer);

		// -(void)Resume;
		[Export ("Resume")]
		void Resume ();

		// -(BOOL)SetAspectRatioConstraint:(unsigned int)aspectRatioWidth AspectRatioHeight:(unsigned int)aspectRatioHeight;
		[Export ("SetAspectRatioConstraint:AspectRatioHeight:")]
		bool SetAspectRatioConstraint (uint aspectRatioWidth, uint aspectRatioHeight);

		// -(BOOL)SetBoundsConstraint:(unsigned int)minWidth MinHeight:(unsigned int)minHeight MaxWidth:(unsigned int)maxWidth MaxHeight:(unsigned int)maxHeight MaxFrameInterval:(long)maxFrameInterval MinFrameInterval:(long)minFrameInterval AspectRatioWidth:(unsigned int)aspectRatioWidth AspectRatioHeight:(unsigned int)aspectRatioHeight TemporalSpatialTradeOff:(unsigned int)temporalSpatialTradeOff;
		[Export ("SetBoundsConstraint:MinHeight:MaxWidth:MaxHeight:MaxFrameInterval:MinFrameInterval:AspectRatioWidth:AspectRatioHeight:TemporalSpatialTradeOff:")]
		bool SetBoundsConstraint (uint minWidth, uint minHeight, uint maxWidth, uint maxHeight, nint maxFrameInterval, nint minFrameInterval, uint aspectRatioWidth, uint aspectRatioHeight, uint temporalSpatialTradeOff);

		// -(BOOL)SetCapabilitiesConstraint:(NSMutableArray *)capabilities TemporalSpatialTradeOff:(unsigned int)temporalSpatialTradeOff;
		[Export ("SetCapabilitiesConstraint:TemporalSpatialTradeOff:")]
		bool SetCapabilitiesConstraint (NSMutableArray capabilities, uint temporalSpatialTradeOff);

		// -(BOOL)SetConstraints:(unsigned int)minWidth MinHeight:(unsigned int)minHeight MaxWidth:(unsigned int)maxWidth MaxHeight:(unsigned int)maxHeight MaxFrameInterval:(unsigned int)maxFrameInterval MinFrameInterval:(unsigned int)minFrameInterval AspectRatioWidth:(unsigned int)aspectRatioWidth AspectRatioHeight:(unsigned int)aspectRatioHeight TemporalSpatialTradeOff:(unsigned int)temporalSpatialTradeOff Capabilities:(NSMutableArray *)capabilities;
		[Export ("SetConstraints:MinHeight:MaxWidth:MaxHeight:MaxFrameInterval:MinFrameInterval:AspectRatioWidth:AspectRatioHeight:TemporalSpatialTradeOff:Capabilities:")]
		bool SetConstraints (uint minWidth, uint minHeight, uint maxWidth, uint maxHeight, uint maxFrameInterval, uint minFrameInterval, uint aspectRatioWidth, uint aspectRatioHeight, uint temporalSpatialTradeOff, NSMutableArray capabilities);

		// -(void)SetControlDigital:(BOOL)digital;
		[Export ("SetControlDigital:")]
		void SetControlDigital (bool digital);

		// -(BOOL)SetFramerateTradeOffProfile:(LocalCameraTradeOffProfile)profile;
		[Export ("SetFramerateTradeOffProfile:")]
		bool SetFramerateTradeOffProfile (LocalCameraTradeOffProfile profile);

		// -(void)SetMaxBitRate:(unsigned int)bitRate;
		[Export ("SetMaxBitRate:")]
		void SetMaxBitRate (uint bitRate);

		// -(BOOL)SetMaxConstraint:(unsigned int)width Height:(unsigned int)height FrameInterval:(long)frameInterval;
		[Export ("SetMaxConstraint:Height:FrameInterval:")]
		bool SetMaxConstraint (uint width, uint height, nint frameInterval);

		// -(BOOL)SetNudgeTimes:(long)panTime TiltTime:(long)tiltTime ZoomTime:(long)zoomTime;
		[Export ("SetNudgeTimes:TiltTime:ZoomTime:")]
		bool SetNudgeTimes (nint panTime, nint tiltTime, nint zoomTime);

		// -(BOOL)SetPositionInLocalRenderer:(LocalRenderer *)localRenderer X:(int)x Y:(int)y Width:(unsigned int)width Height:(unsigned int)height FrameInterval:(long)frameInterval;
		[Export ("SetPositionInLocalRenderer:X:Y:Width:Height:FrameInterval:")]
		bool SetPositionInLocalRenderer (LocalRenderer localRenderer, int x, int y, uint width, uint height, nint frameInterval);

		// -(BOOL)SetPreviewLabel:(NSString *)previewLabel;
		[Export ("SetPreviewLabel:")]
		bool SetPreviewLabel (string previewLabel);

		// -(BOOL)SetResolutionTradeOffProfile:(LocalCameraTradeOffProfile)profile;
		[Export ("SetResolutionTradeOffProfile:")]
		bool SetResolutionTradeOffProfile (LocalCameraTradeOffProfile profile);

		// -(BOOL)ShowCameraControl:(BOOL)show;
		[Export ("ShowCameraControl:")]
		bool ShowCameraControl (bool show);

		// -(id)initWithObject:(void *)rPtr;
		[Export ("initWithObject:")]
		IntPtr Constructor (ref IntPtr rPtr);

		// -(void *)GetObjectPtr;
		[Export ("GetObjectPtr")]
		IntPtr GetObjectPtr();
	}

	// @interface LocalSpeaker : NSObject
	[BaseType (typeof(NSObject))]
	interface LocalSpeaker
	{
		// -(void)dealloc;
		[Export ("dealloc")]
		void Dealloc ();

		// -(NSString *)GetId;
		[Export ("GetId")]
		string GetId();

		// -(NSString *)GetName;
		[Export ("GetName")]
		string GetName();

		// -(unsigned int)GetVolume;
		[Export ("GetVolume")]
		uint GetVolume();

		// -(BOOL)IsPaused;
		[Export ("IsPaused")]
		bool IsPaused();

		// -(void)Pause;
		[Export ("Pause")]
		void Pause ();

		// -(void)PlayTone:(char)dtmfTone;
		[Export ("PlayTone:")]
		void PlayTone (sbyte dtmfTone);

		// -(void)Resume;
		[Export ("Resume")]
		void Resume ();

		// -(void)SetVolume:(unsigned int)volumePercent;
		[Export ("SetVolume:")]
		void SetVolume (uint volumePercent);

		// -(void)StopSound;
		[Export ("StopSound")]
		void StopSound ();

		// -(id)initWithObject:(void *)rPtr;
		[Export ("initWithObject:")]
		IntPtr Constructor (ref IntPtr rPtr);

		// -(void *)GetObjectPtr;
		[Export ("GetObjectPtr")]
		IntPtr GetObjectPtr();
	}

	// @interface RemoteSpeaker : NSObject
	[BaseType (typeof(NSObject))]
	interface RemoteSpeaker
	{
		// -(void)dealloc;
		[Export ("dealloc")]
		void Dealloc ();

		// -(NSString *)GetId;
		[Export ("GetId")]
		string GetId();

		// -(NSString *)GetName;
		[Export ("GetName")]
		string GetName();

		// -(id)initWithObject:(void *)rPtr;
		[Export ("initWithObject:")]
		IntPtr Constructor (ref IntPtr rPtr);

		// -(void *)GetObjectPtr;
		[Export ("GetObjectPtr")]
		IntPtr GetObjectPtr();
	}

	// @interface LocalMicrophone : NSObject
	[BaseType (typeof(NSObject))]
	interface LocalMicrophone
	{
		// -(void)dealloc;
		[Export ("dealloc")]
		void Dealloc ();

		// -(BOOL)AddToLocalSpeaker:(LocalSpeaker *)speaker;
		[Export ("AddToLocalSpeaker:")]
		bool AddToLocalSpeaker (LocalSpeaker speaker);

		// -(BOOL)AddToRemoteSpeaker:(RemoteSpeaker *)remoteSpeaker;
		[Export ("AddToRemoteSpeaker:")]
		bool AddToRemoteSpeaker (RemoteSpeaker remoteSpeaker);

		// -(BOOL)DisableDebugRecording;
		[Export ("DisableDebugRecording")]
		bool DisableDebugRecording();

		// -(BOOL)EnableDebugRecording:(NSString *)dir;
		[Export ("EnableDebugRecording:")]
		bool EnableDebugRecording (string dir);

		// -(BOOL)GetAutoGain;
		[Export ("GetAutoGain")]
		bool GetAutoGain();

		// -(NSString *)GetId;
		[Export ("GetId")]
		string GetId();

		// -(NSString *)GetName;
		[Export ("GetName")]
		string GetName();

		// -(DeviceAudioSignalType)GetSignalType;
		[Export ("GetSignalType")]
		DeviceAudioSignalType GetSignalType();

		// -(BOOL)GetVoiceProcessing;
		[Export ("GetVoiceProcessing")]
		bool GetVoiceProcessing();

		// -(unsigned int)GetVolume;
		[Export ("GetVolume")]
		uint GetVolume();

		// -(void)HideDebugDialog;
		[Export ("HideDebugDialog")]
		void HideDebugDialog ();

		// -(BOOL)IsDebugRecordingEnabled;
		[Export ("IsDebugRecordingEnabled")]
		bool IsDebugRecordingEnabled();

		// -(BOOL)IsPaused;
		[Export ("IsPaused")]
		bool IsPaused();

		// -(void)Pause;
		[Export ("Pause")]
		void Pause ();

		// -(void)PlayTone:(char)dtmfTone;
		[Export ("PlayTone:")]
		void PlayTone (sbyte dtmfTone);

		// -(BOOL)RemoveFromLocalSpeaker:(LocalSpeaker *)speaker;
		[Export ("RemoveFromLocalSpeaker:")]
		bool RemoveFromLocalSpeaker (LocalSpeaker speaker);

		// -(BOOL)RemoveFromRemoteSpeaker:(RemoteSpeaker *)remoteSpeaker;
		[Export ("RemoveFromRemoteSpeaker:")]
		bool RemoveFromRemoteSpeaker (RemoteSpeaker remoteSpeaker);

		// -(void)Resume;
		[Export ("Resume")]
		void Resume ();

		// -(BOOL)SetAutoGain:(BOOL)autoGain;
		[Export ("SetAutoGain:")]
		bool SetAutoGain (bool autoGain);

		// -(BOOL)SetEchoCancellation:(LocalSpeaker *)speaker IsEnable:(BOOL)isEnable;
		[Export ("SetEchoCancellation:IsEnable:")]
		bool SetEchoCancellation (LocalSpeaker speaker, bool isEnable);

		// -(BOOL)SetSignalType:(DeviceAudioSignalType)signalType;
		[Export ("SetSignalType:")]
		bool SetSignalType (DeviceAudioSignalType signalType);

		// -(BOOL)SetVoiceProcessing:(BOOL)voiceProcessing;
		[Export ("SetVoiceProcessing:")]
		bool SetVoiceProcessing (bool voiceProcessing);

		// -(void)SetVolume:(unsigned int)volumePercent;
		[Export ("SetVolume:")]
		void SetVolume (uint volumePercent);

		// -(void)ShowDebugDialog;
		[Export ("ShowDebugDialog")]
		void ShowDebugDialog ();

		// -(id)initWithObject:(void *)rPtr;
		[Export ("initWithObject:")]
		IntPtr Constructor (ref IntPtr rPtr);

		// -(void *)GetObjectPtr;
		[Export ("GetObjectPtr")]
		IntPtr GetObjectPtr();
	}

	// @protocol IGetApplicationIconFrameDataUriAsync
	[BaseType(typeof(NSObject))]
	[Protocol, Model]
	interface GetApplicationIconFrameDataUriAsync
	{
		// @required -(void)OnApplicationIconDataUriComplete:(NSString *)icon;
		[Abstract]
		[Export ("OnApplicationIconDataUriComplete:")]
		void OnApplicationIconDataUriComplete (string icon);
	}
	interface IGetApplicationIconFrameDataUriAsync {}

	// @protocol IGetPreviewFrameDataUriAsync
	[BaseType(typeof(NSObject))]
	[Protocol, Model]
	interface GetPreviewFrameDataUriAsync
	{
		// @required -(void)OnPreviewDataUriComplete:(NSString *)videoFrame State:(LocalWindowShareState)state;
		[Abstract]
		[Export ("OnPreviewDataUriComplete:State:")]
		void State (string videoFrame, LocalWindowShareState state);
	}
	interface IGetPreviewFrameDataUriAsync {}

	// @interface LocalWindowShare : NSObject
	[BaseType (typeof(NSObject))]
	interface LocalWindowShare
	{
		// -(void)dealloc;
		[Export ("dealloc")]
		void Dealloc ();

		// -(long)AddToLocalRenderer:(LocalRenderer *)renderer;
		[Export ("AddToLocalRenderer:")]
		nint AddToLocalRenderer (LocalRenderer renderer);

		// -(BOOL)AddToRemoteRenderer:(RemoteRenderer *)remoteRenderer;
		[Export ("AddToRemoteRenderer:")]
		bool AddToRemoteRenderer (RemoteRenderer remoteRenderer);

		// -(void)ClearConstraints;
		[Export ("ClearConstraints")]
		void ClearConstraints ();

		// -(BOOL)GetApplicationIconFrameDataUriAsync:(size_t)maxWidth MaxHeight:(size_t)maxHeight GetApplicationIconFrameDataUriAsync:(id<IGetApplicationIconFrameDataUriAsync>)getApplicationIconFrameDataUriAsync;
		[Export ("GetApplicationIconFrameDataUriAsync:MaxHeight:GetApplicationIconFrameDataUriAsync:")]
		bool GetApplicationIconFrameDataUriAsync (nuint maxWidth, nuint maxHeight, IGetApplicationIconFrameDataUriAsync getApplicationIconFrameDataUriAsync);

		// -(NSString *)GetApplicationName;
		[Export ("GetApplicationName")]
		string GetApplicationName();

		// -(NSString *)GetId;
		[Export ("GetId")]
		string GetId();

		// -(NSString *)GetName;
		[Export ("GetName")]
		string GetName();

		// -(BOOL)GetPreviewFrameDataUriAsync:(size_t)maxWidth MaxHeight:(size_t)maxHeight GetPreviewFrameDataUriAsync:(id<IGetPreviewFrameDataUriAsync>)getPreviewFrameDataUriAsync;
		[Export ("GetPreviewFrameDataUriAsync:MaxHeight:GetPreviewFrameDataUriAsync:")]
		bool GetPreviewFrameDataUriAsync (nuint maxWidth, nuint maxHeight, IGetPreviewFrameDataUriAsync getPreviewFrameDataUriAsync);

		// -(unsigned int)GetProcessId;
		[Export ("GetProcessId")]
		uint GetProcessId();

		// -(BOOL)IsApplicationNameSet;
		[Export ("IsApplicationNameSet")]
		bool IsApplicationNameSet();

		// -(BOOL)IsNameSet;
		[Export ("IsNameSet")]
		bool IsNameSet();

		// -(BOOL)RemoveFromLocalRenderer:(LocalRenderer *)renderer;
		[Export ("RemoveFromLocalRenderer:")]
		bool RemoveFromLocalRenderer (LocalRenderer renderer);

		// -(BOOL)RemoveFromRemoteRenderer:(RemoteRenderer *)remoteRenderer;
		[Export ("RemoveFromRemoteRenderer:")]
		bool RemoveFromRemoteRenderer (RemoteRenderer remoteRenderer);

		// -(BOOL)SetBoundsConstraints:(long)maxFrameInterval MinFrameInterval:(long)minFrameInterval MaxWidth:(unsigned int)maxWidth MinWidth:(unsigned int)minWidth MaxHeight:(unsigned int)maxHeight MinHeight:(unsigned int)minHeight;
		[Export ("SetBoundsConstraints:MinFrameInterval:MaxWidth:MinWidth:MaxHeight:MinHeight:")]
		bool SetBoundsConstraints (nint maxFrameInterval, nint minFrameInterval, uint maxWidth, uint minWidth, uint maxHeight, uint minHeight);

		// -(BOOL)SetCapability:(long)frameInterval ShowCursor:(BOOL)showCursor RedactOccludedAreas:(BOOL)redactOccludedAreas;
		[Export ("SetCapability:ShowCursor:RedactOccludedAreas:")]
		bool SetCapability (nint frameInterval, bool showCursor, bool redactOccludedAreas);

		// -(BOOL)SetDiscrerteConstraints:(long)maxFrameInterval MinFrameInterval:(long)minFrameInterval Width:(unsigned int)width Height:(unsigned int)height ScaleFactor:(float)scaleFactor;
		[Export ("SetDiscrerteConstraints:MinFrameInterval:Width:Height:ScaleFactor:")]
		bool SetDiscrerteConstraints (nint maxFrameInterval, nint minFrameInterval, uint width, uint height, float scaleFactor);

		// -(BOOL)SetPositionInLocalRenderer:(LocalRenderer *)localRenderer X:(int)x Y:(int)y Width:(unsigned int)width Height:(unsigned int)height FrameInterval:(long)frameInterval;
		[Export ("SetPositionInLocalRenderer:X:Y:Width:Height:FrameInterval:")]
		bool SetPositionInLocalRenderer (LocalRenderer localRenderer, int x, int y, uint width, uint height, nint frameInterval);

		// -(id)initWithObject:(void *)rPtr;
		[Export ("initWithObject:")]
		IntPtr Constructor (ref IntPtr rPtr);

		// -(void *)GetObjectPtr;
		[Export ("GetObjectPtr")]
		IntPtr GetObjectPtr();
	}

	// @interface LocalMonitor : NSObject
	[BaseType (typeof(NSObject))]
	interface LocalMonitor
	{
		// -(void)dealloc;
		[Export ("dealloc")]
		void Dealloc ();

		// -(long)AddToLocalRenderer:(LocalRenderer *)renderer;
		[Export ("AddToLocalRenderer:")]
		nint AddToLocalRenderer (LocalRenderer renderer);

		// -(BOOL)AddToRemoteRenderer:(RemoteRenderer *)remoteRenderer;
		[Export ("AddToRemoteRenderer:")]
		bool AddToRemoteRenderer (RemoteRenderer remoteRenderer);

		// -(void)ClearConstraints;
		[Export ("ClearConstraints")]
		void ClearConstraints ();

		// -(NSString *)GetId;
		[Export ("GetId")]
		string GetId();

		// -(NSString *)GetName;
		[Export ("GetName")]
		string GetName();

		// -(LocalMonitorState)GetPreviewFrameDataUri:(size_t)maxWidth MaxHeight:(size_t)maxHeight VideoFrame:(NSMutableString *)videoFrame;
		[Export ("GetPreviewFrameDataUri:MaxHeight:VideoFrame:")]
		LocalMonitorState GetPreviewFrameDataUri (nuint maxWidth, nuint maxHeight, NSMutableString videoFrame);

		// -(BOOL)GetPreviewFrameDataUriAsync:(size_t)maxWidth MaxHeight:(size_t)maxHeight GetPreviewFrameDataUriAsync:(id<IGetPreviewFrameDataUriAsync>)getPreviewFrameDataUriAsync;
		[Export ("GetPreviewFrameDataUriAsync:MaxHeight:GetPreviewFrameDataUriAsync:")]
		bool GetPreviewFrameDataUriAsync (nuint maxWidth, nuint maxHeight, IGetPreviewFrameDataUriAsync getPreviewFrameDataUriAsync);

		// -(void)PrecludeWindow:(LocalWindowShare *)w;
		[Export ("PrecludeWindow:")]
		void PrecludeWindow (LocalWindowShare w);

		// -(BOOL)RemoveFromLocalRenderer:(LocalRenderer *)renderer;
		[Export ("RemoveFromLocalRenderer:")]
		bool RemoveFromLocalRenderer (LocalRenderer renderer);

		// -(BOOL)RemoveFromRemoteRenderer:(RemoteRenderer *)remoteRenderer;
		[Export ("RemoveFromRemoteRenderer:")]
		bool RemoveFromRemoteRenderer (RemoteRenderer remoteRenderer);

		// -(BOOL)SetBoundsConstraints:(long)maxFrameInterval MinFrameInterval:(long)minFrameInterval MaxWidth:(unsigned int)maxWidth MinWidth:(unsigned int)minWidth MaxHeight:(unsigned int)maxHeight MinHeight:(unsigned int)minHeight;
		[Export ("SetBoundsConstraints:MinFrameInterval:MaxWidth:MinWidth:MaxHeight:MinHeight:")]
		bool SetBoundsConstraints (nint maxFrameInterval, nint minFrameInterval, uint maxWidth, uint minWidth, uint maxHeight, uint minHeight);

		// -(BOOL)SetCaptureInterval:(long)frameInterval;
		[Export ("SetCaptureInterval:")]
		bool SetCaptureInterval (nint frameInterval);

		// -(BOOL)SetDiscrerteConstraints:(long)maxFrameInterval MinFrameInterval:(long)minFrameInterval Width:(unsigned int)width Height:(unsigned int)height ScaleFactor:(float)scaleFactor;
		[Export ("SetDiscrerteConstraints:MinFrameInterval:Width:Height:ScaleFactor:")]
		bool SetDiscrerteConstraints (nint maxFrameInterval, nint minFrameInterval, uint width, uint height, float scaleFactor);

		// -(BOOL)SetPositionInLocalRenderer:(LocalRenderer *)localRenderer X:(int)x Y:(int)y Width:(unsigned int)width Height:(unsigned int)height FrameInterval:(long)frameInterval;
		[Export ("SetPositionInLocalRenderer:X:Y:Width:Height:FrameInterval:")]
		bool SetPositionInLocalRenderer (LocalRenderer localRenderer, int x, int y, uint width, uint height, nint frameInterval);

		// -(id)initWithObject:(void *)rPtr;
		[Export ("initWithObject:")]
		IntPtr Constructor (ref IntPtr rPtr);

		// -(void *)GetObjectPtr;
		[Export ("GetObjectPtr")]
		IntPtr GetObjectPtr();
	}

	// @interface LogRecord : NSObject
	[BaseType (typeof(NSObject))]
	interface LogRecord
	{
	}

	// @interface NetworkInterface : NSObject
	[BaseType (typeof(NSObject))]
	interface NetworkInterface
	{
		// -(void)dealloc;
		[Export ("dealloc")]
		void Dealloc ();

		// -(NSString *)GetAddress;
		[Export ("GetAddress")]
		string GetAddress();

		// -(NetworkInterfaceFamily)GetFamily;
		[Export ("GetFamily")]
		NetworkInterfaceFamily GetFamily();

		// -(NSString *)GetName;
		[Export ("GetName")]
		string GetName();

		// -(NetworkInterfaceState)GetState;
		[Export ("GetState")]
		NetworkInterfaceState GetState();

		// -(NetworkInterfaceType)GetType;
		[Export ("GetType")]
		NetworkInterfaceType GetTypeXamarin();

		// -(id)initWithObject:(void *)rPtr;
		[Export ("initWithObject:")]
		IntPtr Constructor (ref IntPtr rPtr);

		// -(void *)GetObjectPtr;
		[Export ("GetObjectPtr")]
		IntPtr GetObjectPtr();
	}

	// @interface Contact : NSObject
	[BaseType (typeof(NSObject))]
	interface Contact
	{
	}

	// @interface ContactProperty : NSObject
	[BaseType (typeof(NSObject))]
	interface ContactProperty
	{
	}

	// @interface Participant : NSObject
	[BaseType (typeof(NSObject))]
	interface Participant
	{
		// -(void)dealloc;
		[Export ("dealloc")]
		void Dealloc ();

		// -(Contact *)GetContact:(Contact *)contact;
		[Export ("GetContact:")]
		Contact GetContact (Contact contact);

		// -(NSString *)GetId;
		[Export ("GetId")]
		string GetId();

		// -(NSString *)GetName;
		[Export ("GetName")]
		string GetName();

		// -(NSString *)GetUserId;
		[Export ("GetUserId")]
		string GetUserId();

		// -(BOOL)IsHidden;
		[Export ("IsHidden")]
		bool IsHidden();

		// -(BOOL)IsLocal;
		[Export ("IsLocal")]
		bool IsLocal();

		// -(BOOL)IsRecording;
		[Export ("IsRecording")]
		bool IsRecording();

		// -(BOOL)IsSelectable;
		[Export ("IsSelectable")]
		bool IsSelectable();

		// -(id)initWithObject:(void *)rPtr;
		[Export ("initWithObject:")]
		IntPtr Constructor (ref IntPtr rPtr);

		// -(void *)GetObjectPtr;
		[Export ("GetObjectPtr")]
		IntPtr GetObjectPtr();
	}

	// @interface RemoteCamera : NSObject
	[BaseType (typeof(NSObject))]
	interface RemoteCamera
	{
		// -(void)dealloc;
		[Export ("dealloc")]
		void Dealloc ();

		// -(long)AddToLocalRenderer:(LocalRenderer *)localRenderer Mode:(RemoteCameraMode)mode;
		[Export ("AddToLocalRenderer:Mode:")]
		nint AddToLocalRenderer (LocalRenderer localRenderer, RemoteCameraMode mode);

		// -(BOOL)ControlPTZ:(int)pan Tilt:(int)tilt Zoom:(int)zoom;
		[Export ("ControlPTZ:Tilt:Zoom:")]
		bool ControlPTZ (int pan, int tilt, int zoom);

		// -(NSString *)GetId;
		[Export ("GetId")]
		string GetId();

		// -(long)GetLocalRenderingStreamId:(int)index;
		[Export ("GetLocalRenderingStreamId:")]
		nint GetLocalRenderingStreamId (int index);

		// -(NSString *)GetName;
		[Export ("GetName")]
		string GetName();

		// -(RemoteCameraPosition)GetPosition;
		[Export ("GetPosition")]
		RemoteCameraPosition GetPosition();

		// -(BOOL)IsControllable;
		[Export ("IsControllable")]
		bool IsControllable();

		// -(BOOL)RemoveFromLocalRenderer:(LocalRenderer *)localRenderer;
		[Export ("RemoveFromLocalRenderer:")]
		bool RemoveFromLocalRenderer (LocalRenderer localRenderer);

		// -(BOOL)SetPositionInLocalRenderer:(LocalRenderer *)localRenderer X:(int)x Y:(int)y Width:(unsigned int)width Height:(unsigned int)height FrameInterval:(long)frameInterval;
		[Export ("SetPositionInLocalRenderer:X:Y:Width:Height:FrameInterval:")]
		bool SetPositionInLocalRenderer (LocalRenderer localRenderer, int x, int y, uint width, uint height, nint frameInterval);

		// -(BOOL)ShowCameraControl:(BOOL)show;
		[Export ("ShowCameraControl:")]
		bool ShowCameraControl (bool show);

		// -(id)initWithObject:(void *)rPtr;
		[Export ("initWithObject:")]
		IntPtr Constructor (ref IntPtr rPtr);

		// -(void *)GetObjectPtr;
		[Export ("GetObjectPtr")]
		IntPtr GetObjectPtr();
	}

	// @interface RemoteMicrophone : NSObject
	[BaseType (typeof(NSObject))]
	interface RemoteMicrophone
	{
		// -(void)dealloc;
		[Export ("dealloc")]
		void Dealloc ();

		// -(BOOL)AddToLocalSpeaker:(LocalSpeaker *)speaker Mode:(RemoteMicrophoneMode)mode;
		[Export ("AddToLocalSpeaker:Mode:")]
		bool AddToLocalSpeaker (LocalSpeaker speaker, RemoteMicrophoneMode mode);

		// -(NSString *)GetId;
		[Export ("GetId")]
		string GetId();

		// -(NSString *)GetName;
		[Export ("GetName")]
		string GetName();

		// -(DeviceAudioSignalType)GetSignalType;
		[Export ("GetSignalType")]
		DeviceAudioSignalType GetSignalType();

		// -(BOOL)RemoveFromLocalSpeaker:(LocalSpeaker *)speaker;
		[Export ("RemoveFromLocalSpeaker:")]
		bool RemoveFromLocalSpeaker (LocalSpeaker speaker);

		// -(id)initWithObject:(void *)rPtr;
		[Export ("initWithObject:")]
		IntPtr Constructor (ref IntPtr rPtr);

		// -(void *)GetObjectPtr;
		[Export ("GetObjectPtr")]
		IntPtr GetObjectPtr();
	}

	// @interface RemoteWindowShare : NSObject
	[BaseType (typeof(NSObject))]
	interface RemoteWindowShare
	{
		// -(void)dealloc;
		[Export ("dealloc")]
		void Dealloc ();

		// -(long)AddToLocalRenderer:(LocalRenderer *)renderer;
		[Export ("AddToLocalRenderer:")]
		nint AddToLocalRenderer (LocalRenderer renderer);

		// -(NSString *)GetId;
		[Export ("GetId")]
		string GetId();

		// -(NSString *)GetName;
		[Export ("GetName")]
		string GetName();

		// -(BOOL)RemoveFromLocalRenderer:(LocalRenderer *)renderer;
		[Export ("RemoveFromLocalRenderer:")]
		bool RemoveFromLocalRenderer (LocalRenderer renderer);

		// -(BOOL)SetPositionInLocalRenderer:(LocalRenderer *)localRenderer X:(int)x Y:(int)y Width:(unsigned int)width Height:(unsigned int)height FrameInterval:(long)frameInterval;
		[Export ("SetPositionInLocalRenderer:X:Y:Width:Height:FrameInterval:")]
		bool SetPositionInLocalRenderer (LocalRenderer localRenderer, int x, int y, uint width, uint height, nint frameInterval);

		// -(id)initWithObject:(void *)rPtr;
		[Export ("initWithObject:")]
		IntPtr Constructor (ref IntPtr rPtr);

		// -(void *)GetObjectPtr;
		[Export ("GetObjectPtr")]
		IntPtr GetObjectPtr();
	}

	// @interface VideoFrame : NSObject
	[BaseType (typeof(NSObject))]
	interface VideoFrame
	{
		// -(void)dealloc;
		[Export ("dealloc")]
		void Dealloc ();

		// -(NSString *)GetFormat;
		[Export ("GetFormat")]
		string GetFormat();

		// -(size_t)GetHeight;
		[Export ("GetHeight")]
		nuint GetHeight();

		// -(size_t)GetWidth;
		[Export ("GetWidth")]
		nuint GetWidth();

		// -(id)initWithObject:(void *)rPtr;
		[Export ("initWithObject:")]
		IntPtr Constructor (ref IntPtr rPtr);

		// -(void *)GetObjectPtr;
		[Export ("GetObjectPtr")]
		IntPtr GetObjectPtr();
	}

	// @interface VidyoClientConnector : NSObject
	[BaseType (typeof(NSObject))]
	interface VidyoClientConnector
	{
		// +(BOOL)Initialize;
		[Static]
		[Export ("Initialize")]
		bool Initialize();

		// +(BOOL)SetExperimentalOptions:(const char *)options;
		[Static]
		[Export ("SetExperimentalOptions:")]
		bool SetExperimentalOptions ([PlainString]string options);

		// +(void)Uninitialize;
		[Static]
		[Export ("Uninitialize")]
		void Uninitialize ();
	}

	// @protocol IConnect
	[BaseType(typeof(NSObject))]
	[Protocol, Model]
	interface Connect
	{
		// @required -(void)OnSuccess;
		[Abstract]
		[Export ("OnSuccess")]
		void OnSuccess ();

		// @required -(void)OnFailure:(ConnectorFailReason)reason;
		[Abstract]
		[Export ("OnFailure:")]
		void OnFailure (ConnectorFailReason reason);

		// @required -(void)OnDisconnected:(ConnectorDisconnectReason)reason;
		[Abstract]
		[Export ("OnDisconnected:")]
		void OnDisconnected (ConnectorDisconnectReason reason);
	}
	interface IConnect {}

	// @protocol IRegisterLocalCameraEventListener
	[BaseType(typeof(NSObject))]
	[Protocol, Model]
	interface RegisterLocalCameraEventListener
	{
		// @required -(void)OnLocalCameraAdded:(LocalCamera *)localCamera;
		[Abstract]
		[Export ("OnLocalCameraAdded:")]
		void OnLocalCameraAdded (LocalCamera localCamera);

		// @required -(void)OnLocalCameraRemoved:(LocalCamera *)localCamera;
		[Abstract]
		[Export ("OnLocalCameraRemoved:")]
		void OnLocalCameraRemoved (LocalCamera localCamera);

		// @required -(void)OnLocalCameraSelected:(LocalCamera *)localCamera;
		[Abstract]
		[Export ("OnLocalCameraSelected:")]
		void OnLocalCameraSelected (LocalCamera localCamera);

		// @required -(void)OnLocalCameraStateUpdated:(LocalCamera *)localCamera State:(DeviceState)state;
		[Abstract]
		[Export ("OnLocalCameraStateUpdated:State:")]
		void OnLocalCameraStateUpdated (LocalCamera localCamera, DeviceState state);
	}
	interface IRegisterLocalCameraEventListener {}

	// @protocol IRegisterLocalCameraFrameListener
	[BaseType(typeof(NSObject))]
	[Protocol, Model]
	interface RegisterLocalCameraFrameListener
	{
		// @required -(void)OnLocalCameraFrame:(LocalCamera *)localCamera VideoFrame:(VideoFrame *)videoFrame;
		[Abstract]
		[Export ("OnLocalCameraFrame:VideoFrame:")]
		void VideoFrame (LocalCamera localCamera, VideoFrame videoFrame);
	}
	interface IRegisterLocalCameraFrameListener {}

	// @protocol IRegisterLocalMicrophoneEventListener
	[BaseType(typeof(NSObject))]
	[Protocol, Model]
	interface RegisterLocalMicrophoneEventListener
	{
		// @required -(void)OnLocalMicrophoneAdded:(LocalMicrophone *)localMicrophone;
		[Abstract]
		[Export ("OnLocalMicrophoneAdded:")]
		void OnLocalMicrophoneAdded (LocalMicrophone localMicrophone);

		// @required -(void)OnLocalMicrophoneRemoved:(LocalMicrophone *)localMicrophone;
		[Abstract]
		[Export ("OnLocalMicrophoneRemoved:")]
		void OnLocalMicrophoneRemoved (LocalMicrophone localMicrophone);

		// @required -(void)OnLocalMicrophoneSelected:(LocalMicrophone *)localMicrophone;
		[Abstract]
		[Export ("OnLocalMicrophoneSelected:")]
		void OnLocalMicrophoneSelected (LocalMicrophone localMicrophone);

		// @required -(void)OnLocalMicrophoneStateUpdated:(LocalMicrophone *)localMicrophone State:(DeviceState)state;
		[Abstract]
		[Export ("OnLocalMicrophoneStateUpdated:State:")]
		void OnLocalMicrophoneStateUpdated (LocalMicrophone localMicrophone, DeviceState state);
	}
	interface IRegisterLocalMicrophoneEventListener {}

	// @protocol IRegisterLocalMicrophoneFrameListener
	[BaseType(typeof(NSObject))]
	[Protocol, Model]
	interface RegisterLocalMicrophoneFrameListener
	{
		// @required -(void)OnLocalMicrophoneFrame:(LocalMicrophone *)localMicrophone AudioFrame:(AudioFrame *)audioFrame;
		[Abstract]
		[Export ("OnLocalMicrophoneFrame:AudioFrame:")]
		void AudioFrame (LocalMicrophone localMicrophone, AudioFrame audioFrame);
	}
	interface IRegisterLocalMicrophoneFrameListener {}

	// @protocol IRegisterLocalMonitorEventListener
	[BaseType(typeof(NSObject))]
	[Protocol, Model]
	interface RegisterLocalMonitorEventListener
	{
		// @required -(void)OnLocalMonitorAdded:(LocalMonitor *)localMonitor;
		[Abstract]
		[Export ("OnLocalMonitorAdded:")]
		void OnLocalMonitorAdded (LocalMonitor localMonitor);

		// @required -(void)OnLocalMonitorRemoved:(LocalMonitor *)localMonitor;
		[Abstract]
		[Export ("OnLocalMonitorRemoved:")]
		void OnLocalMonitorRemoved (LocalMonitor localMonitor);

		// @required -(void)OnLocalMonitorSelected:(LocalMonitor *)localMonitor;
		[Abstract]
		[Export ("OnLocalMonitorSelected:")]
		void OnLocalMonitorSelected (LocalMonitor localMonitor);

		// @required -(void)OnLocalMonitorStateUpdated:(LocalMonitor *)localMonitor State:(DeviceState)state;
		[Abstract]
		[Export ("OnLocalMonitorStateUpdated:State:")]
		void OnLocalMonitorStateUpdated (LocalMonitor localMonitor, DeviceState state);
	}
	interface IRegisterLocalMonitorEventListener {}

	// @protocol IRegisterLocalMonitorFrameListener
	[BaseType(typeof(NSObject))]
	[Protocol, Model]
	interface RegisterLocalMonitorFrameListener
	{
		// @required -(void)OnLocalMonitorFrame:(LocalMonitor *)localMonitor VideoFrame:(VideoFrame *)videoFrame;
		[Abstract]
		[Export ("OnLocalMonitorFrame:VideoFrame:")]
		void VideoFrame (LocalMonitor localMonitor, VideoFrame videoFrame);
	}
	interface IRegisterLocalMonitorFrameListener {}

	// @protocol IRegisterLocalSpeakerEventListener
	[BaseType(typeof(NSObject))]
	[Protocol, Model]
	interface RegisterLocalSpeakerEventListener
	{
		// @required -(void)OnLocalSpeakerAdded:(LocalSpeaker *)localSpeaker;
		[Abstract]
		[Export ("OnLocalSpeakerAdded:")]
		void OnLocalSpeakerAdded (LocalSpeaker localSpeaker);

		// @required -(void)OnLocalSpeakerRemoved:(LocalSpeaker *)localSpeaker;
		[Abstract]
		[Export ("OnLocalSpeakerRemoved:")]
		void OnLocalSpeakerRemoved (LocalSpeaker localSpeaker);

		// @required -(void)OnLocalSpeakerSelected:(LocalSpeaker *)localSpeaker;
		[Abstract]
		[Export ("OnLocalSpeakerSelected:")]
		void OnLocalSpeakerSelected (LocalSpeaker localSpeaker);

		// @required -(void)OnLocalSpeakerStateUpdated:(LocalSpeaker *)localSpeaker State:(DeviceState)state;
		[Abstract]
		[Export ("OnLocalSpeakerStateUpdated:State:")]
		void OnLocalSpeakerStateUpdated (LocalSpeaker localSpeaker, DeviceState state);
	}
	interface IRegisterLocalSpeakerEventListener {}

	// @protocol IRegisterLocalWindowShareEventListener
	[BaseType(typeof(NSObject))]
	[Protocol, Model]
	interface RegisterLocalWindowShareEventListener
	{
		// @required -(void)OnLocalWindowShareAdded:(LocalWindowShare *)localWindowShare;
		[Abstract]
		[Export ("OnLocalWindowShareAdded:")]
		void OnLocalWindowShareAdded (LocalWindowShare localWindowShare);

		// @required -(void)OnLocalWindowShareRemoved:(LocalWindowShare *)localWindowShare;
		[Abstract]
		[Export ("OnLocalWindowShareRemoved:")]
		void OnLocalWindowShareRemoved (LocalWindowShare localWindowShare);

		// @required -(void)OnLocalWindowShareSelected:(LocalWindowShare *)localWindowShare;
		[Abstract]
		[Export ("OnLocalWindowShareSelected:")]
		void OnLocalWindowShareSelected (LocalWindowShare localWindowShare);

		// @required -(void)OnLocalWindowShareStateUpdated:(LocalWindowShare *)localWindowShare State:(DeviceState)state;
		[Abstract]
		[Export ("OnLocalWindowShareStateUpdated:State:")]
		void OnLocalWindowShareStateUpdated (LocalWindowShare localWindowShare, DeviceState state);
	}
	interface IRegisterLocalWindowShareEventListener {}

	// @protocol IRegisterLocalWindowShareFrameListener
	[BaseType(typeof(NSObject))]
	[Protocol, Model]
	interface RegisterLocalWindowShareFrameListener
	{
		// @required -(void)OnLocalWindowShareFrame:(LocalWindowShare *)localWindowShare VideoFrame:(VideoFrame *)videoFrame;
		[Abstract]
		[Export ("OnLocalWindowShareFrame:VideoFrame:")]
		void VideoFrame (LocalWindowShare localWindowShare, VideoFrame videoFrame);
	}
	interface IRegisterLocalWindowShareFrameListener {}

	// @protocol IRegisterLogEventListener
	[BaseType(typeof(NSObject))]
	[Protocol, Model]
	interface RegisterLogEventListener
	{
		// @required -(void)OnLog:(LogRecord *)logRecord;
		[Abstract]
		[Export ("OnLog:")]
		void OnLog (LogRecord logRecord);
	}
	interface IRegisterLogEventListener {}

	// @protocol IRegisterMessageEventListener
	[BaseType(typeof(NSObject))]
	[Protocol, Model]
	interface RegisterMessageEventListener
	{
		// @required -(void)OnChatMessageReceived:(Participant *)participant ChatMessage:(ChatMessage *)chatMessage;
		[Abstract]
		[Export ("OnChatMessageReceived:ChatMessage:")]
		void ChatMessage (Participant participant, ChatMessage chatMessage);
	}
	interface IRegisterMessageEventListener {}

	// @protocol IRegisterNetworkInterfaceEventListener
	[BaseType(typeof(NSObject))]
	[Protocol, Model]
	interface RegisterNetworkInterfaceEventListener
	{
		// @required -(void)OnNetworkInterfaceAdded:(NetworkInterface *)networkInterface;
		[Abstract]
		[Export ("OnNetworkInterfaceAdded:")]
		void OnNetworkInterfaceAdded (NetworkInterface networkInterface);

		// @required -(void)OnNetworkInterfaceRemoved:(NetworkInterface *)networkInterface;
		[Abstract]
		[Export ("OnNetworkInterfaceRemoved:")]
		void OnNetworkInterfaceRemoved (NetworkInterface networkInterface);

		// @required -(void)OnNetworkInterfaceSelected:(NetworkInterface *)networkInterface TransportType:(NetworkInterfaceTransportType)transportType;
		[Abstract]
		[Export ("OnNetworkInterfaceSelected:TransportType:")]
		void OnNetworkInterfaceSelected (NetworkInterface networkInterface, NetworkInterfaceTransportType transportType);

		// @required -(void)OnNetworkInterfaceStateUpdated:(NetworkInterface *)networkInterface State:(NetworkInterfaceState)state;
		[Abstract]
		[Export ("OnNetworkInterfaceStateUpdated:State:")]
		void OnNetworkInterfaceStateUpdated (NetworkInterface networkInterface, NetworkInterfaceState state);
	}
	interface IRegisterNetworkInterfaceEventListener {}

	// @protocol IRegisterParticipantEventListener
	[BaseType(typeof(NSObject))]
	[Protocol, Model]
	interface RegisterParticipantEventListener
	{
		// @required -(void)OnParticipantJoined:(Participant *)participant;
		[Abstract]
		[Export ("OnParticipantJoined:")]
		void OnParticipantJoined (Participant participant);

		// @required -(void)OnParticipantLeft:(Participant *)participant;
		[Abstract]
		[Export ("OnParticipantLeft:")]
		void OnParticipantLeft (Participant participant);

		// @required -(void)OnDynamicParticipantChanged:(NSMutableArray *)participants RemoteCameras:(NSMutableArray *)remoteCameras;
		[Abstract]
		[Export ("OnDynamicParticipantChanged:RemoteCameras:")]
		void OnDynamicParticipantChanged (NSMutableArray participants, NSMutableArray remoteCameras);

		// @required -(void)OnLoudestParticipantChanged:(Participant *)participant AudioOnly:(BOOL)audioOnly;
		[Abstract]
		[Export ("OnLoudestParticipantChanged:AudioOnly:")]
		void OnLoudestParticipantChanged (Participant participant, bool audioOnly);
	}
	interface IRegisterParticipantEventListener {}

	// @protocol IRegisterRecoderInCallEventListener
	[BaseType(typeof(NSObject))]
	[Protocol, Model]
	interface RegisterRecoderInCallEventListener
	{
		// @required -(void)RecorderInCall:(BOOL)recorderInCall;
		[Abstract]
		[Export ("RecorderInCall:")]
		void RecorderInCall (bool recorderInCall);
	}
	interface IRegisterRecoderInCallEventListener {}

	// @protocol IRegisterRemoteCameraEventListener
	[BaseType(typeof(NSObject))]
	[Protocol, Model]
	interface RegisterRemoteCameraEventListener
	{
		// @required -(void)OnRemoteCameraAdded:(RemoteCamera *)remoteCamera Participant:(Participant *)participant;
		[Abstract]
		[Export ("OnRemoteCameraAdded:Participant:")]
		void OnRemoteCameraAdded (RemoteCamera remoteCamera, Participant participant);

		// @required -(void)OnRemoteCameraRemoved:(RemoteCamera *)remoteCamera Participant:(Participant *)participant;
		[Abstract]
		[Export ("OnRemoteCameraRemoved:Participant:")]
		void OnRemoteCameraRemoved (RemoteCamera remoteCamera, Participant participant);

		// @required -(void)OnRemoteCameraStateUpdated:(RemoteCamera *)remoteCamera Participant:(Participant *)participant State:(DeviceState)state;
		[Abstract]
		[Export ("OnRemoteCameraStateUpdated:Participant:State:")]
		void OnRemoteCameraStateUpdated (RemoteCamera remoteCamera, Participant participant, DeviceState state);
	}
	interface IRegisterRemoteCameraEventListener {}

	// @protocol IRegisterRemoteCameraFrameListener
	[BaseType(typeof(NSObject))]
	[Protocol, Model]
	interface RegisterRemoteCameraFrameListener
	{
		// @required -(void)OnRemoteCameraFrame:(RemoteCamera *)remoteCamera Participant:(Participant *)participant VideoFrame:(VideoFrame *)videoFrame;
		[Abstract]
		[Export ("OnRemoteCameraFrame:Participant:VideoFrame:")]
		void Participant (RemoteCamera remoteCamera, Participant participant, VideoFrame videoFrame);
	}
	interface IRegisterRemoteCameraFrameListener {}

	// @protocol IRegisterRemoteMicrophoneEventListener
	[BaseType(typeof(NSObject))]
	[Protocol, Model]
	interface RegisterRemoteMicrophoneEventListener
	{
		// @required -(void)OnRemoteMicrophoneAdded:(RemoteMicrophone *)remoteMicrophone Participant:(Participant *)participant;
		[Abstract]
		[Export ("OnRemoteMicrophoneAdded:Participant:")]
		void OnRemoteMicrophoneAdded (RemoteMicrophone remoteMicrophone, Participant participant);

		// @required -(void)OnRemoteMicrophoneRemoved:(RemoteMicrophone *)remoteMicrophone Participant:(Participant *)participant;
		[Abstract]
		[Export ("OnRemoteMicrophoneRemoved:Participant:")]
		void OnRemoteMicrophoneRemoved (RemoteMicrophone remoteMicrophone, Participant participant);

		// @required -(void)OnRemoteMicrophoneStateUpdated:(RemoteMicrophone *)remoteMicrophone Participant:(Participant *)participant State:(DeviceState)state;
		[Abstract]
		[Export ("OnRemoteMicrophoneStateUpdated:Participant:State:")]
		void OnRemoteMicrophoneStateUpdated (RemoteMicrophone remoteMicrophone, Participant participant, DeviceState state);
	}
	interface IRegisterRemoteMicrophoneEventListener {}

	// @protocol IRegisterRemoteMicrophoneFrameListener
	[BaseType(typeof(NSObject))]
	[Protocol, Model]
	interface RegisterRemoteMicrophoneFrameListener
	{
		// @required -(void)OnRemoteMicrophoneFrame:(RemoteMicrophone *)remoteMicrophone Participant:(Participant *)participant AudioFrame:(AudioFrame *)audioFrame;
		[Abstract]
		[Export ("OnRemoteMicrophoneFrame:Participant:AudioFrame:")]
		void Participant (RemoteMicrophone remoteMicrophone, Participant participant, AudioFrame audioFrame);
	}
	interface IRegisterRemoteMicrophoneFrameListener {}

	// @protocol IRegisterRemoteWindowShareEventListener
	[BaseType(typeof(NSObject))]
	[Protocol, Model]
	interface RegisterRemoteWindowShareEventListener
	{
		// @required -(void)OnRemoteWindowShareAdded:(RemoteWindowShare *)remoteWindowShare Participant:(Participant *)participant;
		[Abstract]
		[Export ("OnRemoteWindowShareAdded:Participant:")]
		void OnRemoteWindowShareAdded (RemoteWindowShare remoteWindowShare, Participant participant);

		// @required -(void)OnRemoteWindowShareRemoved:(RemoteWindowShare *)remoteWindowShare Participant:(Participant *)participant;
		[Abstract]
		[Export ("OnRemoteWindowShareRemoved:Participant:")]
		void OnRemoteWindowShareRemoved (RemoteWindowShare remoteWindowShare, Participant participant);

		// @required -(void)OnRemoteWindowShareStateUpdated:(RemoteWindowShare *)remoteWindowShare Participant:(Participant *)participant State:(DeviceState)state;
		[Abstract]
		[Export ("OnRemoteWindowShareStateUpdated:Participant:State:")]
		void OnRemoteWindowShareStateUpdated (RemoteWindowShare remoteWindowShare, Participant participant, DeviceState state);
	}
	interface IRegisterRemoteWindowShareEventListener {}

	// @protocol IRegisterRemoteWindowShareFrameListener
	[BaseType(typeof(NSObject))]
	[Protocol, Model]
	interface RegisterRemoteWindowShareFrameListener
	{
		// @required -(void)OnRemoteWindowShareFrame:(RemoteWindowShare *)remoteWindowShare Participant:(Participant *)participant VideoFrame:(VideoFrame *)videoFrame;
		[Abstract]
		[Export ("OnRemoteWindowShareFrame:Participant:VideoFrame:")]
		void Participant (RemoteWindowShare remoteWindowShare, Participant participant, VideoFrame videoFrame);
	}
	interface IRegisterRemoteWindowShareFrameListener {}

	// @protocol IRegisterResourceManagerEventListener
	[BaseType(typeof(NSObject))]
	[Protocol, Model]
	interface RegisterResourceManagerEventListener
	{
		// @required -(void)OnAvailableResourcesChanged:(unsigned int)cpuEncode CpuDecode:(unsigned int)cpuDecode BandwidthSend:(unsigned int)bandwidthSend BandwidthReceive:(unsigned int)bandwidthReceive;
		[Abstract]
		[Export ("OnAvailableResourcesChanged:CpuDecode:BandwidthSend:BandwidthReceive:")]
		void OnAvailableResourcesChanged (uint cpuEncode, uint cpuDecode, uint bandwidthSend, uint bandwidthReceive);

		// @required -(void)OnMaxRemoteSourcesChanged:(unsigned int)maxRemoteSources;
		[Abstract]
		[Export ("OnMaxRemoteSourcesChanged:")]
		void OnMaxRemoteSourcesChanged (uint maxRemoteSources);
	}
	interface IRegisterResourceManagerEventListener {}

	// @protocol IRegisterWebProxyEventListener
	[BaseType(typeof(NSObject))]
	[Protocol, Model]
	interface RegisterWebProxyEventListener
	{
		// @required -(void)OnWebProxyCredentialsRequest;
		[Abstract]
		[Export ("OnWebProxyCredentialsRequest")]
		void OnWebProxyCredentialsRequest ();
	}
	interface IRegisterWebProxyEventListener {}

	// @interface Connector : NSObject
	[BaseType (typeof(NSObject))]
	interface Connector
	{
		// -(id)init:(void *)viewId ViewStyle:(ConnectorViewStyle)viewStyle RemoteParticipants:(unsigned int)remoteParticipants LogFileFilter:(const char *)logFileFilter LogFileName:(const char *)logFileName UserData:(long)userData;
		[Export ("init:ViewStyle:RemoteParticipants:LogFileFilter:LogFileName:UserData:")]
		IntPtr Constructor (ref IntPtr viewId, ConnectorViewStyle viewStyle, uint remoteParticipants, [PlainString]string logFileFilter, [PlainString]string logFileName, nint userData);

		// -(void)dealloc;
		[Export ("dealloc")]
		void Dealloc ();

		// -(BOOL)AssignViewToCompositeRenderer:(void *)viewId ViewStyle:(ConnectorViewStyle)viewStyle RemoteParticipants:(unsigned int)remoteParticipants;
		[Export ("AssignViewToCompositeRenderer:ViewStyle:RemoteParticipants:")]
		bool AssignViewToCompositeRenderer (ref IntPtr viewId, ConnectorViewStyle viewStyle, uint remoteParticipants);

		// -(BOOL)AssignViewToLocalCamera:(void *)viewId LocalCamera:(LocalCamera *)localCamera DisplayCropped:(BOOL)displayCropped AllowZoom:(BOOL)allowZoom;
		[Export ("AssignViewToLocalCamera:LocalCamera:DisplayCropped:AllowZoom:")]
		bool AssignViewToLocalCamera (ref IntPtr viewId, LocalCamera localCamera, bool displayCropped, bool allowZoom);

		// -(BOOL)AssignViewToRemoteCamera:(void *)viewId RemoteCamera:(RemoteCamera *)remoteCamera DisplayCropped:(BOOL)displayCropped AllowZoom:(BOOL)allowZoom;
		[Export ("AssignViewToRemoteCamera:RemoteCamera:DisplayCropped:AllowZoom:")]
		bool AssignViewToRemoteCamera (ref IntPtr viewId, RemoteCamera remoteCamera, bool displayCropped, bool allowZoom);

		// -(BOOL)AssignViewToRemoteWindowShare:(void *)viewId RemoteWindowShare:(RemoteWindowShare *)remoteWindowShare DisplayCropped:(BOOL)displayCropped AllowZoom:(BOOL)allowZoom;
		[Export ("AssignViewToRemoteWindowShare:RemoteWindowShare:DisplayCropped:AllowZoom:")]
		bool AssignViewToRemoteWindowShare (ref IntPtr viewId, RemoteWindowShare remoteWindowShare, bool displayCropped, bool allowZoom);

		// -(BOOL)Connect:(const char *)host Token:(const char *)token DisplayName:(const char *)displayName ResourceId:(const char *)resourceId Connect:(id<IConnect>)connect;
		[Export ("Connect:Token:DisplayName:ResourceId:Connect:")]
		bool Connect ([PlainString]string host, [PlainString]string token, [PlainString]string displayName, [PlainString]string resourceId, IConnect connect);

		// -(BOOL)CycleCamera;
		[Export ("CycleCamera")]
		bool CycleCamera();

		// -(BOOL)CycleMicrophone;
		[Export ("CycleMicrophone")]
		bool CycleMicrophone();

		// -(BOOL)CycleSpeaker;
		[Export ("CycleSpeaker")]
		bool CycleSpeaker();

		// -(void)Disable;
		[Export ("Disable")]
		void Disable ();

		// -(void)DisableDebug;
		[Export ("DisableDebug")]
		void DisableDebug ();

		// -(void)Disconnect;
		[Export ("Disconnect")]
		void Disconnect ();

		// -(BOOL)EnableDebug:(unsigned int)port LogFilter:(const char *)logFilter;
		[Export ("EnableDebug:LogFilter:")]
		bool EnableDebug (uint port, [PlainString]string logFilter);

		// -(ConnectorTradeOffProfile)GetCpuTradeOffProfile;
		[Export ("GetCpuTradeOffProfile")]
		ConnectorTradeOffProfile GetCpuTradeOffProfile();

		// -(ConnectorState)GetState;
		[Export ("GetState")]
		ConnectorState GetState();

		// -(NSString *)GetStatsJson;
		[Export ("GetStatsJson")]
		string GetStatsJson();

		// -(NSString *)GetVersion;
		[Export ("GetVersion")]
		string GetVersion();

		// -(BOOL)HideView:(void *)viewId;
		[Export ("HideView:")]
		bool HideView (ref IntPtr viewId);

		// -(BOOL)RegisterLocalCameraEventListener:(id<IRegisterLocalCameraEventListener>)registerLocalCameraEventListener;
		[Export ("RegisterLocalCameraEventListener:")]
		bool RegisterLocalCameraEventListener (IRegisterLocalCameraEventListener registerLocalCameraEventListener);

		// -(BOOL)RegisterLocalCameraFrameListener:(id<IRegisterLocalCameraFrameListener>)registerLocalCameraFrameListener LocalCamera:(LocalCamera *)localCamera Width:(unsigned int)width Height:(unsigned int)height FrameInterval:(long)frameInterval;
		[Export ("RegisterLocalCameraFrameListener:LocalCamera:Width:Height:FrameInterval:")]
		bool RegisterLocalCameraFrameListener (IRegisterLocalCameraFrameListener registerLocalCameraFrameListener, LocalCamera localCamera, uint width, uint height, nint frameInterval);

		// -(BOOL)RegisterLocalMicrophoneEventListener:(id<IRegisterLocalMicrophoneEventListener>)registerLocalMicrophoneEventListener;
		[Export ("RegisterLocalMicrophoneEventListener:")]
		bool RegisterLocalMicrophoneEventListener (IRegisterLocalMicrophoneEventListener registerLocalMicrophoneEventListener);

		// -(BOOL)RegisterLocalMicrophoneFrameListener:(id<IRegisterLocalMicrophoneFrameListener>)registerLocalMicrophoneFrameListener LocalMicrophone:(LocalMicrophone *)localMicrophone;
		[Export ("RegisterLocalMicrophoneFrameListener:LocalMicrophone:")]
		bool RegisterLocalMicrophoneFrameListener (IRegisterLocalMicrophoneFrameListener registerLocalMicrophoneFrameListener, LocalMicrophone localMicrophone);

		// -(BOOL)RegisterLocalMonitorEventListener:(id<IRegisterLocalMonitorEventListener>)registerLocalMonitorEventListener;
		[Export ("RegisterLocalMonitorEventListener:")]
		bool RegisterLocalMonitorEventListener (IRegisterLocalMonitorEventListener registerLocalMonitorEventListener);

		// -(BOOL)RegisterLocalMonitorFrameListener:(id<IRegisterLocalMonitorFrameListener>)registerLocalMonitorFrameListener LocalMonitor:(LocalMonitor *)localMonitor Width:(unsigned int)width Height:(unsigned int)height FrameInterval:(long)frameInterval;
		[Export ("RegisterLocalMonitorFrameListener:LocalMonitor:Width:Height:FrameInterval:")]
		bool RegisterLocalMonitorFrameListener (IRegisterLocalMonitorFrameListener registerLocalMonitorFrameListener, LocalMonitor localMonitor, uint width, uint height, nint frameInterval);

		// -(BOOL)RegisterLocalSpeakerEventListener:(id<IRegisterLocalSpeakerEventListener>)registerLocalSpeakerEventListener;
		[Export ("RegisterLocalSpeakerEventListener:")]
		bool RegisterLocalSpeakerEventListener (IRegisterLocalSpeakerEventListener registerLocalSpeakerEventListener);

		// -(BOOL)RegisterLocalWindowShareEventListener:(id<IRegisterLocalWindowShareEventListener>)registerLocalWindowShareEventListener;
		[Export ("RegisterLocalWindowShareEventListener:")]
		bool RegisterLocalWindowShareEventListener (IRegisterLocalWindowShareEventListener registerLocalWindowShareEventListener);

		// -(BOOL)RegisterLocalWindowShareFrameListener:(id<IRegisterLocalWindowShareFrameListener>)registerLocalWindowShareFrameListener LocalWindowShare:(LocalWindowShare *)localWindowShare Width:(unsigned int)width Height:(unsigned int)height FrameInterval:(long)frameInterval;
		[Export ("RegisterLocalWindowShareFrameListener:LocalWindowShare:Width:Height:FrameInterval:")]
		bool RegisterLocalWindowShareFrameListener (IRegisterLocalWindowShareFrameListener registerLocalWindowShareFrameListener, LocalWindowShare localWindowShare, uint width, uint height, nint frameInterval);

		// -(BOOL)RegisterLogEventListener:(id<IRegisterLogEventListener>)registerLogEventListener Filter:(const char *)filter;
		[Export ("RegisterLogEventListener:Filter:")]
		bool RegisterLogEventListener (IRegisterLogEventListener registerLogEventListener, [PlainString]string filter);

		// -(BOOL)RegisterMessageEventListener:(id<IRegisterMessageEventListener>)registerMessageEventListener;
		[Export ("RegisterMessageEventListener:")]
		bool RegisterMessageEventListener (IRegisterMessageEventListener registerMessageEventListener);

		// -(BOOL)RegisterNetworkInterfaceEventListener:(id<IRegisterNetworkInterfaceEventListener>)registerNetworkInterfaceEventListener;
		[Export ("RegisterNetworkInterfaceEventListener:")]
		bool RegisterNetworkInterfaceEventListener (IRegisterNetworkInterfaceEventListener registerNetworkInterfaceEventListener);

		// -(BOOL)RegisterParticipantEventListener:(id<IRegisterParticipantEventListener>)registerParticipantEventListener;
		[Export ("RegisterParticipantEventListener:")]
		bool RegisterParticipantEventListener (IRegisterParticipantEventListener registerParticipantEventListener);

		// -(BOOL)RegisterRecoderInCallEventListener:(id<IRegisterRecoderInCallEventListener>)registerRecoderInCallEventListener;
		[Export ("RegisterRecoderInCallEventListener:")]
		bool RegisterRecoderInCallEventListener (IRegisterRecoderInCallEventListener registerRecoderInCallEventListener);

		// -(BOOL)RegisterRemoteCameraEventListener:(id<IRegisterRemoteCameraEventListener>)registerRemoteCameraEventListener;
		[Export ("RegisterRemoteCameraEventListener:")]
		bool RegisterRemoteCameraEventListener (IRegisterRemoteCameraEventListener registerRemoteCameraEventListener);

		// -(BOOL)RegisterRemoteCameraFrameListener:(id<IRegisterRemoteCameraFrameListener>)registerRemoteCameraFrameListener RemoteCamera:(RemoteCamera *)remoteCamera Width:(unsigned int)width Height:(unsigned int)height FrameInterval:(long)frameInterval;
		[Export ("RegisterRemoteCameraFrameListener:RemoteCamera:Width:Height:FrameInterval:")]
		bool RegisterRemoteCameraFrameListener (IRegisterRemoteCameraFrameListener registerRemoteCameraFrameListener, RemoteCamera remoteCamera, uint width, uint height, nint frameInterval);

		// -(BOOL)RegisterRemoteMicrophoneEventListener:(id<IRegisterRemoteMicrophoneEventListener>)registerRemoteMicrophoneEventListener;
		[Export ("RegisterRemoteMicrophoneEventListener:")]
		bool RegisterRemoteMicrophoneEventListener (IRegisterRemoteMicrophoneEventListener registerRemoteMicrophoneEventListener);

		// -(BOOL)RegisterRemoteMicrophoneFrameListener:(id<IRegisterRemoteMicrophoneFrameListener>)registerRemoteMicrophoneFrameListener RemoteMicrophone:(RemoteMicrophone *)remoteMicrophone;
		[Export ("RegisterRemoteMicrophoneFrameListener:RemoteMicrophone:")]
		bool RegisterRemoteMicrophoneFrameListener (IRegisterRemoteMicrophoneFrameListener registerRemoteMicrophoneFrameListener, RemoteMicrophone remoteMicrophone);

		// -(BOOL)RegisterRemoteWindowShareEventListener:(id<IRegisterRemoteWindowShareEventListener>)registerRemoteWindowShareEventListener;
		[Export ("RegisterRemoteWindowShareEventListener:")]
		bool RegisterRemoteWindowShareEventListener (IRegisterRemoteWindowShareEventListener registerRemoteWindowShareEventListener);

		// -(BOOL)RegisterRemoteWindowShareFrameListener:(id<IRegisterRemoteWindowShareFrameListener>)registerRemoteWindowShareFrameListener RemoteWindowShare:(RemoteWindowShare *)remoteWindowShare Width:(unsigned int)width Height:(unsigned int)height FrameInterval:(long)frameInterval;
		[Export ("RegisterRemoteWindowShareFrameListener:RemoteWindowShare:Width:Height:FrameInterval:")]
		bool RegisterRemoteWindowShareFrameListener (IRegisterRemoteWindowShareFrameListener registerRemoteWindowShareFrameListener, RemoteWindowShare remoteWindowShare, uint width, uint height, nint frameInterval);

		// -(BOOL)RegisterResourceManagerEventListener:(id<IRegisterResourceManagerEventListener>)registerResourceManagerEventListener;
		[Export ("RegisterResourceManagerEventListener:")]
		bool RegisterResourceManagerEventListener (IRegisterResourceManagerEventListener registerResourceManagerEventListener);

		// -(BOOL)RegisterWebProxyEventListener:(id<IRegisterWebProxyEventListener>)registerWebProxyEventListener;
		[Export ("RegisterWebProxyEventListener:")]
		bool RegisterWebProxyEventListener (IRegisterWebProxyEventListener registerWebProxyEventListener);

		// -(BOOL)SelectDefaultCamera;
		[Export ("SelectDefaultCamera")]
		bool SelectDefaultCamera();

		// -(BOOL)SelectDefaultMicrophone;
		[Export ("SelectDefaultMicrophone")]
		bool SelectDefaultMicrophone();

		// -(BOOL)SelectDefaultNetworkInterfaceForMedia;
		[Export ("SelectDefaultNetworkInterfaceForMedia")]
		bool SelectDefaultNetworkInterfaceForMedia();

		// -(BOOL)SelectDefaultNetworkInterfaceForSignaling;
		[Export ("SelectDefaultNetworkInterfaceForSignaling")]
		bool SelectDefaultNetworkInterfaceForSignaling();

		// -(BOOL)SelectDefaultSpeaker;
		[Export ("SelectDefaultSpeaker")]
		bool SelectDefaultSpeaker();

		// -(BOOL)SelectLocalCamera:(LocalCamera *)localCamera;
		[Export ("SelectLocalCamera:")]
		bool SelectLocalCamera (LocalCamera localCamera);

		// -(BOOL)SelectLocalMicrophone:(LocalMicrophone *)localMicrophone;
		[Export ("SelectLocalMicrophone:")]
		bool SelectLocalMicrophone (LocalMicrophone localMicrophone);

		// -(BOOL)SelectLocalMonitor:(LocalMonitor *)localMonitor;
		[Export ("SelectLocalMonitor:")]
		bool SelectLocalMonitor (LocalMonitor localMonitor);

		// -(BOOL)SelectLocalSpeaker:(LocalSpeaker *)localSpeaker;
		[Export ("SelectLocalSpeaker:")]
		bool SelectLocalSpeaker (LocalSpeaker localSpeaker);

		// -(BOOL)SelectLocalWindowShare:(LocalWindowShare *)localWindowShare;
		[Export ("SelectLocalWindowShare:")]
		bool SelectLocalWindowShare (LocalWindowShare localWindowShare);

		// -(BOOL)SelectNetworkInterfaceForMedia:(NetworkInterface *)networkInterface;
		[Export ("SelectNetworkInterfaceForMedia:")]
		bool SelectNetworkInterfaceForMedia (NetworkInterface networkInterface);

		// -(BOOL)SelectNetworkInterfaceForSignaling:(NetworkInterface *)networkInterface;
		[Export ("SelectNetworkInterfaceForSignaling:")]
		bool SelectNetworkInterfaceForSignaling (NetworkInterface networkInterface);

		// -(BOOL)SendChatMessage:(const char *)message;
		[Export ("SendChatMessage:")]
		bool SendChatMessage ([PlainString]string message);

		// -(BOOL)SetAdvancedOptions:(const char *)options;
		[Export ("SetAdvancedOptions:")]
		bool SetAdvancedOptions ([PlainString]string options);

		// -(BOOL)SetCameraPrivacy:(BOOL)privacy;
		[Export ("SetCameraPrivacy:")]
		bool SetCameraPrivacy (bool privacy);

		// -(void)SetCertificateAuthorityList:(const char *)certificateAuthorityList;
		[Export ("SetCertificateAuthorityList:")]
		void SetCertificateAuthorityList ([PlainString]string certificateAuthorityList);

		// -(BOOL)SetCpuTradeOffProfile:(ConnectorTradeOffProfile)profile;
		[Export ("SetCpuTradeOffProfile:")]
		bool SetCpuTradeOffProfile (ConnectorTradeOffProfile profile);

		// -(BOOL)SetLocation:(double)latitude Longitude:(double)longitude;
		[Export ("SetLocation:Longitude:")]
		bool SetLocation (double latitude, double longitude);

		// -(BOOL)SetMicrophonePrivacy:(BOOL)privacy;
		[Export ("SetMicrophonePrivacy:")]
		bool SetMicrophonePrivacy (bool privacy);

		// -(BOOL)SetMode:(ConnectorMode)mode;
		[Export ("SetMode:")]
		bool SetMode (ConnectorMode mode);

		// -(BOOL)SetSpeakerPrivacy:(BOOL)privacy;
		[Export ("SetSpeakerPrivacy:")]
		bool SetSpeakerPrivacy (bool privacy);

		// -(BOOL)SetViewAnimationSpeed:(void *)viewId SpeedPercentage:(unsigned int)speedPercentage;
		[Export ("SetViewAnimationSpeed:SpeedPercentage:")]
		bool SetViewAnimationSpeed (ref IntPtr viewId, uint speedPercentage);

		// -(BOOL)SetViewBackgroundColor:(void *)viewId Red:(unsigned char)red Green:(unsigned char)green Blue:(unsigned char)blue;
		[Export ("SetViewBackgroundColor:Red:Green:Blue:")]
		bool SetViewBackgroundColor (ref IntPtr viewId, byte red, byte green, byte blue);

		// -(void)SetWebProxyAddressCredentials:(const char *)proxyAddress Username:(const char *)username Password:(const char *)password;
		[Export ("SetWebProxyAddressCredentials:Username:Password:")]
		void SetWebProxyAddressCredentials ([PlainString]string proxyAddress, [PlainString]string username, [PlainString]string password);

		// -(BOOL)ShowAudioMeters:(void *)viewId ShowMeters:(BOOL)showMeters;
		[Export ("ShowAudioMeters:ShowMeters:")]
		bool ShowAudioMeters (ref IntPtr viewId, bool showMeters);

		// -(BOOL)ShowPreview:(BOOL)preview;
		[Export ("ShowPreview:")]
		bool ShowPreview (bool preview);

		// -(BOOL)ShowViewAt:(void *)viewId X:(int)x Y:(int)y Width:(unsigned int)width Height:(unsigned int)height;
		[Export ("ShowViewAt:X:Y:Width:Height:")]
		bool ShowViewAt (ref IntPtr viewId, int x, int y, uint width, uint height);

		// -(BOOL)ShowViewLabel:(void *)viewId ShowLabel:(BOOL)showLabel;
		[Export ("ShowViewLabel:ShowLabel:")]
		bool ShowViewLabel (ref IntPtr viewId, bool showLabel);

		// -(BOOL)UnregisterLocalCameraEventListener;
		[Export ("UnregisterLocalCameraEventListener")]
		bool UnregisterLocalCameraEventListener();

		// -(BOOL)UnregisterLocalCameraFrameListener:(LocalCamera *)localCamera;
		[Export ("UnregisterLocalCameraFrameListener:")]
		bool UnregisterLocalCameraFrameListener (LocalCamera localCamera);

		// -(BOOL)UnregisterLocalMicrophoneEventListener;
		[Export ("UnregisterLocalMicrophoneEventListener")]
		bool UnregisterLocalMicrophoneEventListener();

		// -(BOOL)UnregisterLocalMicrophoneFrameListener:(LocalMicrophone *)localMicrophone;
		[Export ("UnregisterLocalMicrophoneFrameListener:")]
		bool UnregisterLocalMicrophoneFrameListener (LocalMicrophone localMicrophone);

		// -(BOOL)UnregisterLocalMonitorEventListener;
		[Export ("UnregisterLocalMonitorEventListener")]
		bool UnregisterLocalMonitorEventListener();

		// -(BOOL)UnregisterLocalMonitorFrameListener:(LocalMonitor *)localMonitor;
		[Export ("UnregisterLocalMonitorFrameListener:")]
		bool UnregisterLocalMonitorFrameListener (LocalMonitor localMonitor);

		// -(BOOL)UnregisterLocalSpeakerEventListener;
		[Export ("UnregisterLocalSpeakerEventListener")]
		bool UnregisterLocalSpeakerEventListener();

		// -(BOOL)UnregisterLocalWindowShareEventListener;
		[Export ("UnregisterLocalWindowShareEventListener")]
		bool UnregisterLocalWindowShareEventListener();

		// -(BOOL)UnregisterLocalWindowShareFrameListener:(LocalWindowShare *)localWindowShare;
		[Export ("UnregisterLocalWindowShareFrameListener:")]
		bool UnregisterLocalWindowShareFrameListener (LocalWindowShare localWindowShare);

		// -(BOOL)UnregisterLogEventListener;
		[Export ("UnregisterLogEventListener")]
		bool UnregisterLogEventListener();

		// -(BOOL)UnregisterMessageEventListener;
		[Export ("UnregisterMessageEventListener")]
		bool UnregisterMessageEventListener();

		// -(BOOL)UnregisterNetworkInterfaceEventListener;
		[Export ("UnregisterNetworkInterfaceEventListener")]
		bool UnregisterNetworkInterfaceEventListener();

		// -(BOOL)UnregisterParticipantEventListener;
		[Export ("UnregisterParticipantEventListener")]
		bool UnregisterParticipantEventListener();

		// -(BOOL)UnregisterRecoderInCallEventListener;
		[Export ("UnregisterRecoderInCallEventListener")]
		bool UnregisterRecoderInCallEventListener();

		// -(BOOL)UnregisterRemoteCameraEventListener;
		[Export ("UnregisterRemoteCameraEventListener")]
		bool UnregisterRemoteCameraEventListener();

		// -(BOOL)UnregisterRemoteCameraFrameListener:(RemoteCamera *)remoteCamera;
		[Export ("UnregisterRemoteCameraFrameListener:")]
		bool UnregisterRemoteCameraFrameListener (RemoteCamera remoteCamera);

		// -(BOOL)UnregisterRemoteMicrophoneEventListener;
		[Export ("UnregisterRemoteMicrophoneEventListener")]
		bool UnregisterRemoteMicrophoneEventListener();

		// -(BOOL)UnregisterRemoteMicrophoneFrameListener:(RemoteMicrophone *)remoteMicrophone;
		[Export ("UnregisterRemoteMicrophoneFrameListener:")]
		bool UnregisterRemoteMicrophoneFrameListener (RemoteMicrophone remoteMicrophone);

		// -(BOOL)UnregisterRemoteWindowShareEventListener;
		[Export ("UnregisterRemoteWindowShareEventListener")]
		bool UnregisterRemoteWindowShareEventListener();

		// -(BOOL)UnregisterRemoteWindowShareFrameListener:(RemoteWindowShare *)remoteWindowShare;
		[Export ("UnregisterRemoteWindowShareFrameListener:")]
		bool UnregisterRemoteWindowShareFrameListener (RemoteWindowShare remoteWindowShare);

		// -(BOOL)UnregisterResourceManagerEventListener;
		[Export ("UnregisterResourceManagerEventListener")]
		bool UnregisterResourceManagerEventListener();

		// -(BOOL)UnregisterWebProxyEventListener;
		[Export ("UnregisterWebProxyEventListener")]
		bool UnregisterWebProxyEventListener();

		// -(id)initWithObject:(void *)rPtr;
		[Export ("initWithObject:")]
		IntPtr Constructor (ref IntPtr rPtr);

		// -(void *)GetObjectPtr;
		[Export ("GetObjectPtr")]
		IntPtr GetObjectPtr();
	}
}
