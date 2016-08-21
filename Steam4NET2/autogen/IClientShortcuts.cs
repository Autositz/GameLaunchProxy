// This file is automatically generated.
using System;
using System.Text;
using System.Runtime.InteropServices;

namespace Steam4NET
{

	[StructLayout(LayoutKind.Sequential,Pack=4)]
	public class IClientShortcutsVTable
	{
		public IntPtr GetUniqueLocalAppId0;
		public IntPtr GetGameIDForAppID1;
		public IntPtr GetAppIDForGameID2;
		public IntPtr GetShortcutCount3;
		public IntPtr GetShortcutAppIDByIndex4;
		public IntPtr GetShortcutAppNameByIndex5;
		public IntPtr GetShortcutExeByIndex6;
		public IntPtr GetShortcutUserTagCountByIndex7;
		public IntPtr GetShortcutUserTagByIndex8;
		public IntPtr BIsShortcutRemoteByIndex9;
		public IntPtr BIsTemporaryShortcutByIndex10;
		public IntPtr BIsOpenVRShortcutByIndex11;
		public IntPtr GetShortcutAppNameByAppID12;
		public IntPtr GetShortcutExeByAppID13;
		public IntPtr GetShortcutStartDirByAppID14;
		public IntPtr GetShortcutIconByAppID15;
		public IntPtr GetShortcutPathByAppID16;
		public IntPtr GetShortcutUserTagCountByAppID17;
		public IntPtr GetShortcutUserTagByAppID18;
		public IntPtr BIsShortcutRemoteByAppID19;
		public IntPtr BIsShortcutHiddenByAppID20;
		public IntPtr BIsTemporaryShortcutByAppID21;
		public IntPtr BIsOpenVRShortcutByAppID22;
		public IntPtr BAllowDesktopConfigByAppID23;
		public IntPtr AddShortcut24;
		public IntPtr AddTemporaryShortcut25;
		public IntPtr AddOpenVRShortcut26;
		public IntPtr SetShortcutFromFullpath27;
		public IntPtr SetShortcutAppName28;
		public IntPtr SetShortcutExe29;
		public IntPtr SetShortcutStartDir30;
		public IntPtr SetShortcutIcon31;
		public IntPtr ClearShortcutUserTags32;
		public IntPtr AddShortcutUserTag33;
		public IntPtr SetShortcutHidden34;
		public IntPtr SetAllowDesktopConfig35;
		public IntPtr SetOpenVRShortcut36;
		public IntPtr RemoveShortcut37;
		public IntPtr RemoveAllTemporaryShortcuts38;
		public IntPtr LaunchShortcut39;
		private IntPtr DTorIClientShortcuts40;
	};
	
	[InteropHelp.InterfaceVersion("CLIENTSHORTCUTS_INTERFACE_VERSION001")]
	public class IClientShortcuts : InteropHelp.NativeWrapper<IClientShortcutsVTable>
	{
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate UInt32 NativeGetUniqueLocalAppId( IntPtr thisptr );
		public UInt32 GetUniqueLocalAppId(  ) 
		{
			return this.GetFunction<NativeGetUniqueLocalAppId>( this.Functions.GetUniqueLocalAppId0 )( this.ObjectAddress ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate void NativeGetGameIDForAppIDU( IntPtr thisptr, ref UInt64 retarg, UInt32 unAppID );
		public CGameID GetGameIDForAppID( UInt32 unAppID ) 
		{
			UInt64 ret = 0; this.GetFunction<NativeGetGameIDForAppIDU>( this.Functions.GetGameIDForAppID1 )( this.ObjectAddress, ref ret, unAppID ); return new CGameID(ret);
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate UInt32 NativeGetAppIDForGameIDC( IntPtr thisptr, UInt64 gameID );
		public UInt32 GetAppIDForGameID( CGameID gameID ) 
		{
			return this.GetFunction<NativeGetAppIDForGameIDC>( this.Functions.GetAppIDForGameID2 )( this.ObjectAddress, gameID.ConvertToUint64() ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate UInt32 NativeGetShortcutCount( IntPtr thisptr );
		public UInt32 GetShortcutCount(  ) 
		{
			return this.GetFunction<NativeGetShortcutCount>( this.Functions.GetShortcutCount3 )( this.ObjectAddress ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate UInt32 NativeGetShortcutAppIDByIndexU( IntPtr thisptr, UInt32 uIndex );
		public UInt32 GetShortcutAppIDByIndex( UInt32 uIndex ) 
		{
			return this.GetFunction<NativeGetShortcutAppIDByIndexU>( this.Functions.GetShortcutAppIDByIndex4 )( this.ObjectAddress, uIndex ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate IntPtr NativeGetShortcutAppNameByIndexU( IntPtr thisptr, UInt32 uIndex );
		public string GetShortcutAppNameByIndex( UInt32 uIndex ) 
		{
			return InteropHelp.DecodeANSIReturn( Marshal.PtrToStringAnsi( this.GetFunction<NativeGetShortcutAppNameByIndexU>( this.Functions.GetShortcutAppNameByIndex5 )( this.ObjectAddress, uIndex ) ) ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate IntPtr NativeGetShortcutExeByIndexU( IntPtr thisptr, UInt32 uIndex );
		public string GetShortcutExeByIndex( UInt32 uIndex ) 
		{
			return InteropHelp.DecodeANSIReturn( Marshal.PtrToStringAnsi( this.GetFunction<NativeGetShortcutExeByIndexU>( this.Functions.GetShortcutExeByIndex6 )( this.ObjectAddress, uIndex ) ) ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate UInt32 NativeGetShortcutUserTagCountByIndexU( IntPtr thisptr, UInt32 uIndex );
		public UInt32 GetShortcutUserTagCountByIndex( UInt32 uIndex ) 
		{
			return this.GetFunction<NativeGetShortcutUserTagCountByIndexU>( this.Functions.GetShortcutUserTagCountByIndex7 )( this.ObjectAddress, uIndex ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate IntPtr NativeGetShortcutUserTagByIndexUU( IntPtr thisptr, UInt32 uIndex, UInt32 arg1 );
		public string GetShortcutUserTagByIndex( UInt32 uIndex, UInt32 arg1 ) 
		{
			return InteropHelp.DecodeANSIReturn( Marshal.PtrToStringAnsi( this.GetFunction<NativeGetShortcutUserTagByIndexUU>( this.Functions.GetShortcutUserTagByIndex8 )( this.ObjectAddress, uIndex, arg1 ) ) ); 
		}
		
		[return: MarshalAs(UnmanagedType.I1)]
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeBIsShortcutRemoteByIndexU( IntPtr thisptr, UInt32 uIndex );
		public bool BIsShortcutRemoteByIndex( UInt32 uIndex ) 
		{
			return this.GetFunction<NativeBIsShortcutRemoteByIndexU>( this.Functions.BIsShortcutRemoteByIndex9 )( this.ObjectAddress, uIndex ); 
		}
		
		[return: MarshalAs(UnmanagedType.I1)]
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeBIsTemporaryShortcutByIndexU( IntPtr thisptr, UInt32 uIndex );
		public bool BIsTemporaryShortcutByIndex( UInt32 uIndex ) 
		{
			return this.GetFunction<NativeBIsTemporaryShortcutByIndexU>( this.Functions.BIsTemporaryShortcutByIndex10 )( this.ObjectAddress, uIndex ); 
		}
		
		[return: MarshalAs(UnmanagedType.I1)]
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeBIsOpenVRShortcutByIndexU( IntPtr thisptr, UInt32 uIndex );
		public bool BIsOpenVRShortcutByIndex( UInt32 uIndex ) 
		{
			return this.GetFunction<NativeBIsOpenVRShortcutByIndexU>( this.Functions.BIsOpenVRShortcutByIndex11 )( this.ObjectAddress, uIndex ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate IntPtr NativeGetShortcutAppNameByAppIDU( IntPtr thisptr, UInt32 unAppID );
		public string GetShortcutAppNameByAppID( UInt32 unAppID ) 
		{
			return InteropHelp.DecodeANSIReturn( Marshal.PtrToStringAnsi( this.GetFunction<NativeGetShortcutAppNameByAppIDU>( this.Functions.GetShortcutAppNameByAppID12 )( this.ObjectAddress, unAppID ) ) ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate IntPtr NativeGetShortcutExeByAppIDU( IntPtr thisptr, UInt32 unAppID );
		public string GetShortcutExeByAppID( UInt32 unAppID ) 
		{
			return InteropHelp.DecodeANSIReturn( Marshal.PtrToStringAnsi( this.GetFunction<NativeGetShortcutExeByAppIDU>( this.Functions.GetShortcutExeByAppID13 )( this.ObjectAddress, unAppID ) ) ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate IntPtr NativeGetShortcutStartDirByAppIDU( IntPtr thisptr, UInt32 unAppID );
		public string GetShortcutStartDirByAppID( UInt32 unAppID ) 
		{
			return InteropHelp.DecodeANSIReturn( Marshal.PtrToStringAnsi( this.GetFunction<NativeGetShortcutStartDirByAppIDU>( this.Functions.GetShortcutStartDirByAppID14 )( this.ObjectAddress, unAppID ) ) ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate IntPtr NativeGetShortcutIconByAppIDU( IntPtr thisptr, UInt32 unAppID );
		public string GetShortcutIconByAppID( UInt32 unAppID ) 
		{
			return InteropHelp.DecodeANSIReturn( Marshal.PtrToStringAnsi( this.GetFunction<NativeGetShortcutIconByAppIDU>( this.Functions.GetShortcutIconByAppID15 )( this.ObjectAddress, unAppID ) ) ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate IntPtr NativeGetShortcutPathByAppIDU( IntPtr thisptr, UInt32 unAppID );
		public string GetShortcutPathByAppID( UInt32 unAppID ) 
		{
			return InteropHelp.DecodeANSIReturn( Marshal.PtrToStringAnsi( this.GetFunction<NativeGetShortcutPathByAppIDU>( this.Functions.GetShortcutPathByAppID16 )( this.ObjectAddress, unAppID ) ) ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate UInt32 NativeGetShortcutUserTagCountByAppIDU( IntPtr thisptr, UInt32 unAppID );
		public UInt32 GetShortcutUserTagCountByAppID( UInt32 unAppID ) 
		{
			return this.GetFunction<NativeGetShortcutUserTagCountByAppIDU>( this.Functions.GetShortcutUserTagCountByAppID17 )( this.ObjectAddress, unAppID ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate IntPtr NativeGetShortcutUserTagByAppIDUU( IntPtr thisptr, UInt32 unAppID, UInt32 arg1 );
		public string GetShortcutUserTagByAppID( UInt32 unAppID, UInt32 arg1 ) 
		{
			return InteropHelp.DecodeANSIReturn( Marshal.PtrToStringAnsi( this.GetFunction<NativeGetShortcutUserTagByAppIDUU>( this.Functions.GetShortcutUserTagByAppID18 )( this.ObjectAddress, unAppID, arg1 ) ) ); 
		}
		
		[return: MarshalAs(UnmanagedType.I1)]
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeBIsShortcutRemoteByAppIDU( IntPtr thisptr, UInt32 unAppID );
		public bool BIsShortcutRemoteByAppID( UInt32 unAppID ) 
		{
			return this.GetFunction<NativeBIsShortcutRemoteByAppIDU>( this.Functions.BIsShortcutRemoteByAppID19 )( this.ObjectAddress, unAppID ); 
		}
		
		[return: MarshalAs(UnmanagedType.I1)]
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeBIsShortcutHiddenByAppIDU( IntPtr thisptr, UInt32 unAppID );
		public bool BIsShortcutHiddenByAppID( UInt32 unAppID ) 
		{
			return this.GetFunction<NativeBIsShortcutHiddenByAppIDU>( this.Functions.BIsShortcutHiddenByAppID20 )( this.ObjectAddress, unAppID ); 
		}
		
		[return: MarshalAs(UnmanagedType.I1)]
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeBIsTemporaryShortcutByAppIDU( IntPtr thisptr, UInt32 unAppID );
		public bool BIsTemporaryShortcutByAppID( UInt32 unAppID ) 
		{
			return this.GetFunction<NativeBIsTemporaryShortcutByAppIDU>( this.Functions.BIsTemporaryShortcutByAppID21 )( this.ObjectAddress, unAppID ); 
		}
		
		[return: MarshalAs(UnmanagedType.I1)]
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeBIsOpenVRShortcutByAppIDU( IntPtr thisptr, UInt32 unAppID );
		public bool BIsOpenVRShortcutByAppID( UInt32 unAppID ) 
		{
			return this.GetFunction<NativeBIsOpenVRShortcutByAppIDU>( this.Functions.BIsOpenVRShortcutByAppID22 )( this.ObjectAddress, unAppID ); 
		}
		
		[return: MarshalAs(UnmanagedType.I1)]
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeBAllowDesktopConfigByAppIDU( IntPtr thisptr, UInt32 unAppID );
		public bool BAllowDesktopConfigByAppID( UInt32 unAppID ) 
		{
			return this.GetFunction<NativeBAllowDesktopConfigByAppIDU>( this.Functions.BAllowDesktopConfigByAppID23 )( this.ObjectAddress, unAppID ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate UInt32 NativeAddShortcutSSS( IntPtr thisptr, string arg0, string arg1, string arg2 );
		public UInt32 AddShortcut( string arg0, string arg1, string arg2 ) 
		{
			return this.GetFunction<NativeAddShortcutSSS>( this.Functions.AddShortcut24 )( this.ObjectAddress, arg0, arg1, arg2 ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate UInt32 NativeAddTemporaryShortcutSSS( IntPtr thisptr, string arg0, string arg1, string arg2 );
		public UInt32 AddTemporaryShortcut( string arg0, string arg1, string arg2 ) 
		{
			return this.GetFunction<NativeAddTemporaryShortcutSSS>( this.Functions.AddTemporaryShortcut25 )( this.ObjectAddress, arg0, arg1, arg2 ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate UInt32 NativeAddOpenVRShortcutSSS( IntPtr thisptr, string arg0, string arg1, string arg2 );
		public UInt32 AddOpenVRShortcut( string arg0, string arg1, string arg2 ) 
		{
			return this.GetFunction<NativeAddOpenVRShortcutSSS>( this.Functions.AddOpenVRShortcut26 )( this.ObjectAddress, arg0, arg1, arg2 ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate void NativeSetShortcutFromFullpathUS( IntPtr thisptr, UInt32 arg0, string arg1 );
		public void SetShortcutFromFullpath( UInt32 arg0, string arg1 ) 
		{
			this.GetFunction<NativeSetShortcutFromFullpathUS>( this.Functions.SetShortcutFromFullpath27 )( this.ObjectAddress, arg0, arg1 ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate void NativeSetShortcutAppNameUS( IntPtr thisptr, UInt32 arg0, string arg1 );
		public void SetShortcutAppName( UInt32 arg0, string arg1 ) 
		{
			this.GetFunction<NativeSetShortcutAppNameUS>( this.Functions.SetShortcutAppName28 )( this.ObjectAddress, arg0, arg1 ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate void NativeSetShortcutExeUS( IntPtr thisptr, UInt32 arg0, string arg1 );
		public void SetShortcutExe( UInt32 arg0, string arg1 ) 
		{
			this.GetFunction<NativeSetShortcutExeUS>( this.Functions.SetShortcutExe29 )( this.ObjectAddress, arg0, arg1 ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate void NativeSetShortcutStartDirUS( IntPtr thisptr, UInt32 arg0, string arg1 );
		public void SetShortcutStartDir( UInt32 arg0, string arg1 ) 
		{
			this.GetFunction<NativeSetShortcutStartDirUS>( this.Functions.SetShortcutStartDir30 )( this.ObjectAddress, arg0, arg1 ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate void NativeSetShortcutIconUS( IntPtr thisptr, UInt32 arg0, string arg1 );
		public void SetShortcutIcon( UInt32 arg0, string arg1 ) 
		{
			this.GetFunction<NativeSetShortcutIconUS>( this.Functions.SetShortcutIcon31 )( this.ObjectAddress, arg0, arg1 ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate void NativeClearShortcutUserTagsU( IntPtr thisptr, UInt32 arg0 );
		public void ClearShortcutUserTags( UInt32 arg0 ) 
		{
			this.GetFunction<NativeClearShortcutUserTagsU>( this.Functions.ClearShortcutUserTags32 )( this.ObjectAddress, arg0 ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate void NativeAddShortcutUserTagUS( IntPtr thisptr, UInt32 arg0, string arg1 );
		public void AddShortcutUserTag( UInt32 arg0, string arg1 ) 
		{
			this.GetFunction<NativeAddShortcutUserTagUS>( this.Functions.AddShortcutUserTag33 )( this.ObjectAddress, arg0, arg1 ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate void NativeSetShortcutHiddenUB( IntPtr thisptr, UInt32 arg0, [MarshalAs(UnmanagedType.I1)] bool arg1 );
		public void SetShortcutHidden( UInt32 arg0, bool arg1 ) 
		{
			this.GetFunction<NativeSetShortcutHiddenUB>( this.Functions.SetShortcutHidden34 )( this.ObjectAddress, arg0, arg1 ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate void NativeSetAllowDesktopConfigUB( IntPtr thisptr, UInt32 arg0, [MarshalAs(UnmanagedType.I1)] bool arg1 );
		public void SetAllowDesktopConfig( UInt32 arg0, bool arg1 ) 
		{
			this.GetFunction<NativeSetAllowDesktopConfigUB>( this.Functions.SetAllowDesktopConfig35 )( this.ObjectAddress, arg0, arg1 ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate void NativeSetOpenVRShortcutUB( IntPtr thisptr, UInt32 arg0, [MarshalAs(UnmanagedType.I1)] bool arg1 );
		public void SetOpenVRShortcut( UInt32 arg0, bool arg1 ) 
		{
			this.GetFunction<NativeSetOpenVRShortcutUB>( this.Functions.SetOpenVRShortcut36 )( this.ObjectAddress, arg0, arg1 ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate void NativeRemoveShortcutU( IntPtr thisptr, UInt32 arg0 );
		public void RemoveShortcut( UInt32 arg0 ) 
		{
			this.GetFunction<NativeRemoveShortcutU>( this.Functions.RemoveShortcut37 )( this.ObjectAddress, arg0 ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate void NativeRemoveAllTemporaryShortcuts( IntPtr thisptr );
		public void RemoveAllTemporaryShortcuts(  ) 
		{
			this.GetFunction<NativeRemoveAllTemporaryShortcuts>( this.Functions.RemoveAllTemporaryShortcuts38 )( this.ObjectAddress ); 
		}
		
		[return: MarshalAs(UnmanagedType.I1)]
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeLaunchShortcutU( IntPtr thisptr, UInt32 arg0 );
		public bool LaunchShortcut( UInt32 arg0 ) 
		{
			return this.GetFunction<NativeLaunchShortcutU>( this.Functions.LaunchShortcut39 )( this.ObjectAddress, arg0 ); 
		}
		
	};
}