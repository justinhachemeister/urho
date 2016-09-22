// WARNING - AUTOGENERATED - DO NOT EDIT
// 
// Generated using `sharpie urho`
// 
// Image.cs
// 
// Copyright 2015 Xamarin Inc. All rights reserved.

using System;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using Urho.Urho2D;
using Urho.Gui;
using Urho.Resources;
using Urho.IO;
using Urho.Navigation;
using Urho.Network;

namespace Urho.Resources
{
	/// <summary>
	/// %Image resource.
	/// </summary>
	public unsafe partial class Image : Resource
	{
		public Image (IntPtr handle) : base (handle)
		{
		}

		protected Image (UrhoObjectFlag emptyFlag) : base (emptyFlag)
		{
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern int Image_GetType (IntPtr handle);

		private StringHash UrhoGetType ()
		{
			Runtime.ValidateRefCounted (this);
			return new StringHash (Image_GetType (handle));
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr Image_GetTypeName (IntPtr handle);

		private string GetTypeName ()
		{
			Runtime.ValidateRefCounted (this);
			return Marshal.PtrToStringAnsi (Image_GetTypeName (handle));
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern int Image_GetTypeStatic ();

		private static StringHash GetTypeStatic ()
		{
			Runtime.Validate (typeof(Image));
			return new StringHash (Image_GetTypeStatic ());
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr Image_GetTypeNameStatic ();

		private static string GetTypeNameStatic ()
		{
			Runtime.Validate (typeof(Image));
			return Marshal.PtrToStringAnsi (Image_GetTypeNameStatic ());
		}

		public Image () : this (Application.CurrentContext)
		{
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr Image_Image (IntPtr context);

		public Image (Context context) : base (UrhoObjectFlag.Empty)
		{
			Runtime.Validate (typeof(Image));
			handle = Image_Image ((object)context == null ? IntPtr.Zero : context.Handle);
			Runtime.RegisterObject (this);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern void Image_RegisterObject (IntPtr context);

		/// <summary>
		/// Register object factory.
		/// </summary>
		public static void RegisterObject (Context context)
		{
			Runtime.Validate (typeof(Image));
			Image_RegisterObject ((object)context == null ? IntPtr.Zero : context.Handle);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern bool Image_BeginLoad (IntPtr handle, IntPtr source);

		/// <summary>
		/// Load resource from stream. May be called from a worker thread. Return true if successful.
		/// </summary>
		public override bool BeginLoad (File source)
		{
			Runtime.ValidateRefCounted (this);
			return Image_BeginLoad (handle, (object)source == null ? IntPtr.Zero : source.Handle);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern bool Image_Save (IntPtr handle, IntPtr dest);

		/// <summary>
		/// Save the image to a stream. Regardless of original format, the image is saved as png. Compressed image data is not supported. Return true if successful.
		/// </summary>
		public override bool Save (File dest)
		{
			Runtime.ValidateRefCounted (this);
			return Image_Save (handle, (object)dest == null ? IntPtr.Zero : dest.Handle);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern bool Image_SetSize (IntPtr handle, int width, int height, uint components);

		/// <summary>
		/// Set 2D size and number of color components. Old image data will be destroyed and new data is undefined. Return true if successful.
		/// </summary>
		public bool SetSize (int width, int height, uint components)
		{
			Runtime.ValidateRefCounted (this);
			return Image_SetSize (handle, width, height, components);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern bool Image_SetSize0 (IntPtr handle, int width, int height, int depth, uint components);

		/// <summary>
		/// Set 3D size and number of color components. Old image data will be destroyed and new data is undefined. Return true if successful.
		/// </summary>
		public bool SetSize (int width, int height, int depth, uint components)
		{
			Runtime.ValidateRefCounted (this);
			return Image_SetSize0 (handle, width, height, depth, components);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern void Image_SetData (IntPtr handle, byte* pixelData);

		/// <summary>
		/// Set new image data.
		/// </summary>
		public void SetData (byte* pixelData)
		{
			Runtime.ValidateRefCounted (this);
			Image_SetData (handle, pixelData);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern void Image_SetPixel (IntPtr handle, int x, int y, ref Urho.Color color);

		/// <summary>
		/// Set a 2D pixel.
		/// </summary>
		public void SetPixel (int x, int y, Urho.Color color)
		{
			Runtime.ValidateRefCounted (this);
			Image_SetPixel (handle, x, y, ref color);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern void Image_SetPixel1 (IntPtr handle, int x, int y, int z, ref Urho.Color color);

		/// <summary>
		/// Set a 3D pixel.
		/// </summary>
		public void SetPixel (int x, int y, int z, Urho.Color color)
		{
			Runtime.ValidateRefCounted (this);
			Image_SetPixel1 (handle, x, y, z, ref color);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern void Image_SetPixelInt (IntPtr handle, int x, int y, uint uintColor);

		/// <summary>
		/// Set a 2D pixel with an integer color. R component is in the 8 lowest bits.
		/// </summary>
		public void SetPixelInt (int x, int y, uint uintColor)
		{
			Runtime.ValidateRefCounted (this);
			Image_SetPixelInt (handle, x, y, uintColor);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern void Image_SetPixelInt2 (IntPtr handle, int x, int y, int z, uint uintColor);

		/// <summary>
		/// Set a 3D pixel with an integer color. R component is in the 8 lowest bits.
		/// </summary>
		public void SetPixelInt (int x, int y, int z, uint uintColor)
		{
			Runtime.ValidateRefCounted (this);
			Image_SetPixelInt2 (handle, x, y, z, uintColor);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern bool Image_LoadColorLUT (IntPtr handle, IntPtr source);

		/// <summary>
		/// Load as color LUT. Return true if successful.
		/// </summary>
		public bool LoadColorLUT (File source)
		{
			Runtime.ValidateRefCounted (this);
			return Image_LoadColorLUT (handle, (object)source == null ? IntPtr.Zero : source.Handle);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern bool Image_FlipHorizontal (IntPtr handle);

		/// <summary>
		/// Flip image horizontally. Return true if successful.
		/// </summary>
		public bool FlipHorizontal ()
		{
			Runtime.ValidateRefCounted (this);
			return Image_FlipHorizontal (handle);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern bool Image_FlipVertical (IntPtr handle);

		/// <summary>
		/// Flip image vertically. Return true if successful.
		/// </summary>
		public bool FlipVertical ()
		{
			Runtime.ValidateRefCounted (this);
			return Image_FlipVertical (handle);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern bool Image_Resize (IntPtr handle, int width, int height);

		/// <summary>
		/// Resize image by bilinear resampling. Return true if successful.
		/// </summary>
		public bool Resize (int width, int height)
		{
			Runtime.ValidateRefCounted (this);
			return Image_Resize (handle, width, height);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern void Image_Clear (IntPtr handle, ref Urho.Color color);

		/// <summary>
		/// Clear the image with a color.
		/// </summary>
		public void Clear (Urho.Color color)
		{
			Runtime.ValidateRefCounted (this);
			Image_Clear (handle, ref color);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern void Image_ClearInt (IntPtr handle, uint uintColor);

		/// <summary>
		/// Clear the image with an integer color. R component is in the 8 lowest bits.
		/// </summary>
		public void ClearInt (uint uintColor)
		{
			Runtime.ValidateRefCounted (this);
			Image_ClearInt (handle, uintColor);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern bool Image_SaveBMP (IntPtr handle, string fileName);

		/// <summary>
		/// Save in BMP format. Return true if successful.
		/// </summary>
		public bool SaveBMP (string fileName)
		{
			Runtime.ValidateRefCounted (this);
			return Image_SaveBMP (handle, fileName);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern bool Image_SavePNG (IntPtr handle, string fileName);

		/// <summary>
		/// Save in PNG format. Return true if successful.
		/// </summary>
		public bool SavePNG (string fileName)
		{
			Runtime.ValidateRefCounted (this);
			return Image_SavePNG (handle, fileName);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern bool Image_SaveTGA (IntPtr handle, string fileName);

		/// <summary>
		/// Save in TGA format. Return true if successful.
		/// </summary>
		public bool SaveTGA (string fileName)
		{
			Runtime.ValidateRefCounted (this);
			return Image_SaveTGA (handle, fileName);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern bool Image_SaveJPG (IntPtr handle, string fileName, int quality);

		/// <summary>
		/// Save in JPG format with compression quality. Return true if successful.
		/// </summary>
		public bool SaveJPG (string fileName, int quality)
		{
			Runtime.ValidateRefCounted (this);
			return Image_SaveJPG (handle, fileName, quality);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern bool Image_IsCubemap (IntPtr handle);

		/// <summary>
		/// Whether this texture is detected as a cubemap, only relevant for DDS.
		/// </summary>
		private bool IsCubemap ()
		{
			Runtime.ValidateRefCounted (this);
			return Image_IsCubemap (handle);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern bool Image_IsArray (IntPtr handle);

		/// <summary>
		/// Whether this texture has been detected as a volume, only relevant for DDS.
		/// </summary>
		private bool IsArray ()
		{
			Runtime.ValidateRefCounted (this);
			return Image_IsArray (handle);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern bool Image_IsSRGB (IntPtr handle);

		/// <summary>
		/// Whether this texture is in sRGB, only relevant for DDS.
		/// </summary>
		private bool IsSRGB ()
		{
			Runtime.ValidateRefCounted (this);
			return Image_IsSRGB (handle);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern Color Image_GetPixel (IntPtr handle, int x, int y);

		/// <summary>
		/// Return a 2D pixel color.
		/// </summary>
		public Color GetPixel (int x, int y)
		{
			Runtime.ValidateRefCounted (this);
			return Image_GetPixel (handle, x, y);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern Color Image_GetPixel3 (IntPtr handle, int x, int y, int z);

		/// <summary>
		/// Return a 3D pixel color.
		/// </summary>
		public Color GetPixel (int x, int y, int z)
		{
			Runtime.ValidateRefCounted (this);
			return Image_GetPixel3 (handle, x, y, z);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern uint Image_GetPixelInt (IntPtr handle, int x, int y);

		/// <summary>
		/// Return a 2D pixel integer color. R component is in the 8 lowest bits.
		/// </summary>
		public uint GetPixelInt (int x, int y)
		{
			Runtime.ValidateRefCounted (this);
			return Image_GetPixelInt (handle, x, y);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern uint Image_GetPixelInt4 (IntPtr handle, int x, int y, int z);

		/// <summary>
		/// Return a 3D pixel integer color. R component is in the 8 lowest bits.
		/// </summary>
		public uint GetPixelInt (int x, int y, int z)
		{
			Runtime.ValidateRefCounted (this);
			return Image_GetPixelInt4 (handle, x, y, z);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern Color Image_GetPixelBilinear (IntPtr handle, float x, float y);

		/// <summary>
		/// Return a bilinearly sampled 2D pixel color. X and Y have the range 0-1.
		/// </summary>
		public Color GetPixelBilinear (float x, float y)
		{
			Runtime.ValidateRefCounted (this);
			return Image_GetPixelBilinear (handle, x, y);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern Color Image_GetPixelTrilinear (IntPtr handle, float x, float y, float z);

		/// <summary>
		/// Return a trilinearly sampled 3D pixel color. X, Y and Z have the range 0-1.
		/// </summary>
		public Color GetPixelTrilinear (float x, float y, float z)
		{
			Runtime.ValidateRefCounted (this);
			return Image_GetPixelTrilinear (handle, x, y, z);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern int Image_GetWidth (IntPtr handle);

		/// <summary>
		/// Return width.
		/// </summary>
		private int GetWidth ()
		{
			Runtime.ValidateRefCounted (this);
			return Image_GetWidth (handle);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern int Image_GetHeight (IntPtr handle);

		/// <summary>
		/// Return height.
		/// </summary>
		private int GetHeight ()
		{
			Runtime.ValidateRefCounted (this);
			return Image_GetHeight (handle);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern int Image_GetDepth (IntPtr handle);

		/// <summary>
		/// Return depth.
		/// </summary>
		private int GetDepth ()
		{
			Runtime.ValidateRefCounted (this);
			return Image_GetDepth (handle);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern uint Image_GetComponents (IntPtr handle);

		/// <summary>
		/// Return number of color components.
		/// </summary>
		private uint GetComponents ()
		{
			Runtime.ValidateRefCounted (this);
			return Image_GetComponents (handle);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte* Image_GetData (IntPtr handle);

		/// <summary>
		/// Return pixel data.
		/// </summary>
		private byte* GetData ()
		{
			Runtime.ValidateRefCounted (this);
			return Image_GetData (handle);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern bool Image_IsCompressed (IntPtr handle);

		/// <summary>
		/// Return whether is compressed.
		/// </summary>
		private bool IsCompressed ()
		{
			Runtime.ValidateRefCounted (this);
			return Image_IsCompressed (handle);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern CompressedFormat Image_GetCompressedFormat (IntPtr handle);

		/// <summary>
		/// Return compressed format.
		/// </summary>
		private CompressedFormat GetCompressedFormat ()
		{
			Runtime.ValidateRefCounted (this);
			return Image_GetCompressedFormat (handle);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern uint Image_GetNumCompressedLevels (IntPtr handle);

		/// <summary>
		/// Return number of compressed mip levels. Returns 0 if the image is has not been loaded from a source file containing multiple mip levels.
		/// </summary>
		private uint GetNumCompressedLevels ()
		{
			Runtime.ValidateRefCounted (this);
			return Image_GetNumCompressedLevels (handle);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr Image_GetNextLevel (IntPtr handle);

		/// <summary>
		/// Return next mip level by bilinear filtering. Note that if the image is already 1x1x1, will keep returning an image of that size.
		/// </summary>
		private Image GetNextLevel ()
		{
			Runtime.ValidateRefCounted (this);
			return Runtime.LookupRefCounted<Image> (Image_GetNextLevel (handle));
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr Image_GetNextSibling (IntPtr handle);

		/// <summary>
		/// Return the next sibling image of an array or cubemap.
		/// </summary>
		private Image GetNextSibling ()
		{
			Runtime.ValidateRefCounted (this);
			return Runtime.LookupRefCounted<Image> (Image_GetNextSibling (handle));
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr Image_ConvertToRGBA (IntPtr handle);

		/// <summary>
		/// Return image converted to 4-component (RGBA) to circumvent modern rendering API's not supporting e.g. the luminance-alpha format.
		/// </summary>
		public Image ConvertToRGBA ()
		{
			Runtime.ValidateRefCounted (this);
			return Runtime.LookupRefCounted<Image> (Image_ConvertToRGBA (handle));
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern CompressedLevel Image_GetCompressedLevel (IntPtr handle, uint index);

		/// <summary>
		/// Return a compressed mip level.
		/// </summary>
		public CompressedLevel GetCompressedLevel (uint index)
		{
			Runtime.ValidateRefCounted (this);
			return Image_GetCompressedLevel (handle, index);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr Image_GetSubimage (IntPtr handle, ref Urho.IntRect rect);

		/// <summary>
		/// Return subimage from the image by the defined rect or null if failed. 3D images are not supported. You must free the subimage yourself.
		/// </summary>
		public Image GetSubimage (Urho.IntRect rect)
		{
			Runtime.ValidateRefCounted (this);
			return Runtime.LookupObject<Image> (Image_GetSubimage (handle, ref rect));
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern void Image_PrecalculateLevels (IntPtr handle);

		/// <summary>
		/// Precalculate the mip levels. Used by asynchronous texture loading.
		/// </summary>
		public void PrecalculateLevels ()
		{
			Runtime.ValidateRefCounted (this);
			Image_PrecalculateLevels (handle);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern void Image_CleanupLevels (IntPtr handle);

		/// <summary>
		/// Clean up the mip levels.
		/// </summary>
		public void CleanupLevels ()
		{
			Runtime.ValidateRefCounted (this);
			Image_CleanupLevels (handle);
		}

		public override StringHash Type {
			get {
				return UrhoGetType ();
			}
		}

		public override string TypeName {
			get {
				return GetTypeName ();
			}
		}

		public new static StringHash TypeStatic {
			get {
				return GetTypeStatic ();
			}
		}

		public new static string TypeNameStatic {
			get {
				return GetTypeNameStatic ();
			}
		}

		/// <summary>
		/// Return pixel data.
		/// </summary>
		public byte* Data {
			get {
				return GetData ();
			}
		}

		/// <summary>
		/// Whether this texture is detected as a cubemap, only relevant for DDS.
		/// </summary>
		public bool Cubemap {
			get {
				return IsCubemap ();
			}
		}

		/// <summary>
		/// Whether this texture has been detected as a volume, only relevant for DDS.
		/// </summary>
		public bool Array {
			get {
				return IsArray ();
			}
		}

		/// <summary>
		/// Whether this texture is in sRGB, only relevant for DDS.
		/// </summary>
		public bool SRGB {
			get {
				return IsSRGB ();
			}
		}

		/// <summary>
		/// Return width.
		/// </summary>
		public int Width {
			get {
				return GetWidth ();
			}
		}

		/// <summary>
		/// Return height.
		/// </summary>
		public int Height {
			get {
				return GetHeight ();
			}
		}

		/// <summary>
		/// Return depth.
		/// </summary>
		public int Depth {
			get {
				return GetDepth ();
			}
		}

		/// <summary>
		/// Return number of color components.
		/// </summary>
		public uint Components {
			get {
				return GetComponents ();
			}
		}

		/// <summary>
		/// Return whether is compressed.
		/// </summary>
		public bool Compressed {
			get {
				return IsCompressed ();
			}
		}

		/// <summary>
		/// Return compressed format.
		/// </summary>
		public CompressedFormat CompressedFormat {
			get {
				return GetCompressedFormat ();
			}
		}

		/// <summary>
		/// Return number of compressed mip levels. Returns 0 if the image is has not been loaded from a source file containing multiple mip levels.
		/// </summary>
		public uint NumCompressedLevels {
			get {
				return GetNumCompressedLevels ();
			}
		}

		/// <summary>
		/// Return next mip level by bilinear filtering. Note that if the image is already 1x1x1, will keep returning an image of that size.
		/// </summary>
		public Image NextLevel {
			get {
				return GetNextLevel ();
			}
		}

		/// <summary>
		/// Return the next sibling image of an array or cubemap.
		/// </summary>
		public Image NextSibling {
			get {
				return GetNextSibling ();
			}
		}
	}
}
