// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using HexaGen.Runtime;
using System.Numerics;

namespace Hexa.NET.ImGui
{
	public unsafe partial class ImGui
	{

		/// <summary>
		/// To be documented.
		/// </summary>
		public static void RenderText(ref ImFont self, ref ImDrawList drawList, float size, Vector2 pos, uint col, Vector4 clipRect, string textBegin, ref byte textEnd, float wrapWidth)
		{
			fixed (ImFont* pself = &self)
			{
				fixed (ImDrawList* pdrawList = &drawList)
				{
					byte* pStr0 = null;
					int pStrSize0 = 0;
					if (textBegin != null)
					{
						pStrSize0 = Utils.GetByteCountUTF8(textBegin);
						if (pStrSize0 >= Utils.MaxStackallocSize)
						{
							pStr0 = Utils.Alloc<byte>(pStrSize0 + 1);
						}
						else
						{
							byte* pStrStack0 = stackalloc byte[pStrSize0 + 1];
							pStr0 = pStrStack0;
						}
						int pStrOffset0 = Utils.EncodeStringUTF8(textBegin, pStr0, pStrSize0);
						pStr0[pStrOffset0] = 0;
					}
					fixed (byte* ptextEnd = &textEnd)
					{
						RenderTextNative((ImFont*)pself, (ImDrawList*)pdrawList, size, pos, col, clipRect, pStr0, (byte*)ptextEnd, wrapWidth, (byte)(0));
						if (pStrSize0 >= Utils.MaxStackallocSize)
						{
							Utils.Free(pStr0);
						}
					}
				}
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public static void RenderText(ref ImFont self, ref ImDrawList drawList, float size, Vector2 pos, uint col, Vector4 clipRect, string textBegin, ref byte textEnd)
		{
			fixed (ImFont* pself = &self)
			{
				fixed (ImDrawList* pdrawList = &drawList)
				{
					byte* pStr0 = null;
					int pStrSize0 = 0;
					if (textBegin != null)
					{
						pStrSize0 = Utils.GetByteCountUTF8(textBegin);
						if (pStrSize0 >= Utils.MaxStackallocSize)
						{
							pStr0 = Utils.Alloc<byte>(pStrSize0 + 1);
						}
						else
						{
							byte* pStrStack0 = stackalloc byte[pStrSize0 + 1];
							pStr0 = pStrStack0;
						}
						int pStrOffset0 = Utils.EncodeStringUTF8(textBegin, pStr0, pStrSize0);
						pStr0[pStrOffset0] = 0;
					}
					fixed (byte* ptextEnd = &textEnd)
					{
						RenderTextNative((ImFont*)pself, (ImDrawList*)pdrawList, size, pos, col, clipRect, pStr0, (byte*)ptextEnd, (float)(0.0f), (byte)(0));
						if (pStrSize0 >= Utils.MaxStackallocSize)
						{
							Utils.Free(pStr0);
						}
					}
				}
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public static void RenderText(ref ImFont self, ref ImDrawList drawList, float size, Vector2 pos, uint col, Vector4 clipRect, string textBegin, ref byte textEnd, bool cpuFineClip)
		{
			fixed (ImFont* pself = &self)
			{
				fixed (ImDrawList* pdrawList = &drawList)
				{
					byte* pStr0 = null;
					int pStrSize0 = 0;
					if (textBegin != null)
					{
						pStrSize0 = Utils.GetByteCountUTF8(textBegin);
						if (pStrSize0 >= Utils.MaxStackallocSize)
						{
							pStr0 = Utils.Alloc<byte>(pStrSize0 + 1);
						}
						else
						{
							byte* pStrStack0 = stackalloc byte[pStrSize0 + 1];
							pStr0 = pStrStack0;
						}
						int pStrOffset0 = Utils.EncodeStringUTF8(textBegin, pStr0, pStrSize0);
						pStr0[pStrOffset0] = 0;
					}
					fixed (byte* ptextEnd = &textEnd)
					{
						RenderTextNative((ImFont*)pself, (ImDrawList*)pdrawList, size, pos, col, clipRect, pStr0, (byte*)ptextEnd, (float)(0.0f), cpuFineClip ? (byte)1 : (byte)0);
						if (pStrSize0 >= Utils.MaxStackallocSize)
						{
							Utils.Free(pStr0);
						}
					}
				}
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public static void RenderText(ref ImFont self, ref ImDrawList drawList, float size, Vector2 pos, uint col, Vector4 clipRect, string textBegin, ReadOnlySpan<byte> textEnd, float wrapWidth, bool cpuFineClip)
		{
			fixed (ImFont* pself = &self)
			{
				fixed (ImDrawList* pdrawList = &drawList)
				{
					byte* pStr0 = null;
					int pStrSize0 = 0;
					if (textBegin != null)
					{
						pStrSize0 = Utils.GetByteCountUTF8(textBegin);
						if (pStrSize0 >= Utils.MaxStackallocSize)
						{
							pStr0 = Utils.Alloc<byte>(pStrSize0 + 1);
						}
						else
						{
							byte* pStrStack0 = stackalloc byte[pStrSize0 + 1];
							pStr0 = pStrStack0;
						}
						int pStrOffset0 = Utils.EncodeStringUTF8(textBegin, pStr0, pStrSize0);
						pStr0[pStrOffset0] = 0;
					}
					fixed (byte* ptextEnd = textEnd)
					{
						RenderTextNative((ImFont*)pself, (ImDrawList*)pdrawList, size, pos, col, clipRect, pStr0, (byte*)ptextEnd, wrapWidth, cpuFineClip ? (byte)1 : (byte)0);
						if (pStrSize0 >= Utils.MaxStackallocSize)
						{
							Utils.Free(pStr0);
						}
					}
				}
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public static void RenderText(ref ImFont self, ref ImDrawList drawList, float size, Vector2 pos, uint col, Vector4 clipRect, string textBegin, ReadOnlySpan<byte> textEnd, float wrapWidth)
		{
			fixed (ImFont* pself = &self)
			{
				fixed (ImDrawList* pdrawList = &drawList)
				{
					byte* pStr0 = null;
					int pStrSize0 = 0;
					if (textBegin != null)
					{
						pStrSize0 = Utils.GetByteCountUTF8(textBegin);
						if (pStrSize0 >= Utils.MaxStackallocSize)
						{
							pStr0 = Utils.Alloc<byte>(pStrSize0 + 1);
						}
						else
						{
							byte* pStrStack0 = stackalloc byte[pStrSize0 + 1];
							pStr0 = pStrStack0;
						}
						int pStrOffset0 = Utils.EncodeStringUTF8(textBegin, pStr0, pStrSize0);
						pStr0[pStrOffset0] = 0;
					}
					fixed (byte* ptextEnd = textEnd)
					{
						RenderTextNative((ImFont*)pself, (ImDrawList*)pdrawList, size, pos, col, clipRect, pStr0, (byte*)ptextEnd, wrapWidth, (byte)(0));
						if (pStrSize0 >= Utils.MaxStackallocSize)
						{
							Utils.Free(pStr0);
						}
					}
				}
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public static void RenderText(ref ImFont self, ref ImDrawList drawList, float size, Vector2 pos, uint col, Vector4 clipRect, string textBegin, ReadOnlySpan<byte> textEnd)
		{
			fixed (ImFont* pself = &self)
			{
				fixed (ImDrawList* pdrawList = &drawList)
				{
					byte* pStr0 = null;
					int pStrSize0 = 0;
					if (textBegin != null)
					{
						pStrSize0 = Utils.GetByteCountUTF8(textBegin);
						if (pStrSize0 >= Utils.MaxStackallocSize)
						{
							pStr0 = Utils.Alloc<byte>(pStrSize0 + 1);
						}
						else
						{
							byte* pStrStack0 = stackalloc byte[pStrSize0 + 1];
							pStr0 = pStrStack0;
						}
						int pStrOffset0 = Utils.EncodeStringUTF8(textBegin, pStr0, pStrSize0);
						pStr0[pStrOffset0] = 0;
					}
					fixed (byte* ptextEnd = textEnd)
					{
						RenderTextNative((ImFont*)pself, (ImDrawList*)pdrawList, size, pos, col, clipRect, pStr0, (byte*)ptextEnd, (float)(0.0f), (byte)(0));
						if (pStrSize0 >= Utils.MaxStackallocSize)
						{
							Utils.Free(pStr0);
						}
					}
				}
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public static void RenderText(ref ImFont self, ref ImDrawList drawList, float size, Vector2 pos, uint col, Vector4 clipRect, string textBegin, ReadOnlySpan<byte> textEnd, bool cpuFineClip)
		{
			fixed (ImFont* pself = &self)
			{
				fixed (ImDrawList* pdrawList = &drawList)
				{
					byte* pStr0 = null;
					int pStrSize0 = 0;
					if (textBegin != null)
					{
						pStrSize0 = Utils.GetByteCountUTF8(textBegin);
						if (pStrSize0 >= Utils.MaxStackallocSize)
						{
							pStr0 = Utils.Alloc<byte>(pStrSize0 + 1);
						}
						else
						{
							byte* pStrStack0 = stackalloc byte[pStrSize0 + 1];
							pStr0 = pStrStack0;
						}
						int pStrOffset0 = Utils.EncodeStringUTF8(textBegin, pStr0, pStrSize0);
						pStr0[pStrOffset0] = 0;
					}
					fixed (byte* ptextEnd = textEnd)
					{
						RenderTextNative((ImFont*)pself, (ImDrawList*)pdrawList, size, pos, col, clipRect, pStr0, (byte*)ptextEnd, (float)(0.0f), cpuFineClip ? (byte)1 : (byte)0);
						if (pStrSize0 >= Utils.MaxStackallocSize)
						{
							Utils.Free(pStr0);
						}
					}
				}
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void BuildLookupTableNative(ImFont* self)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<ImFont*, void>)funcTable[667])(self);
			#else
			((delegate* unmanaged[Cdecl]<nint, void>)funcTable[667])((nint)self);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public static void BuildLookupTable(ImFontPtr self)
		{
			BuildLookupTableNative(self);
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public static void BuildLookupTable(ref ImFont self)
		{
			fixed (ImFont* pself = &self)
			{
				BuildLookupTableNative((ImFont*)pself);
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void ClearOutputDataNative(ImFont* self)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<ImFont*, void>)funcTable[668])(self);
			#else
			((delegate* unmanaged[Cdecl]<nint, void>)funcTable[668])((nint)self);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public static void ClearOutputData(ImFontPtr self)
		{
			ClearOutputDataNative(self);
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public static void ClearOutputData(ref ImFont self)
		{
			fixed (ImFont* pself = &self)
			{
				ClearOutputDataNative((ImFont*)pself);
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void GrowIndexNative(ImFont* self, int newSize)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<ImFont*, int, void>)funcTable[669])(self, newSize);
			#else
			((delegate* unmanaged[Cdecl]<nint, int, void>)funcTable[669])((nint)self, newSize);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public static void GrowIndex(ImFontPtr self, int newSize)
		{
			GrowIndexNative(self, newSize);
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public static void GrowIndex(ref ImFont self, int newSize)
		{
			fixed (ImFont* pself = &self)
			{
				GrowIndexNative((ImFont*)pself, newSize);
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void AddGlyphNative(ImFont* self, ImFontConfig* srcCfg, uint c, float x0, float y0, float x1, float y1, float u0, float v0, float u1, float v1, float advanceX)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<ImFont*, ImFontConfig*, uint, float, float, float, float, float, float, float, float, float, void>)funcTable[670])(self, srcCfg, c, x0, y0, x1, y1, u0, v0, u1, v1, advanceX);
			#else
			((delegate* unmanaged[Cdecl]<nint, nint, uint, float, float, float, float, float, float, float, float, float, void>)funcTable[670])((nint)self, (nint)srcCfg, c, x0, y0, x1, y1, u0, v0, u1, v1, advanceX);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public static void AddGlyph(ImFontPtr self, ImFontConfigPtr srcCfg, uint c, float x0, float y0, float x1, float y1, float u0, float v0, float u1, float v1, float advanceX)
		{
			AddGlyphNative(self, srcCfg, c, x0, y0, x1, y1, u0, v0, u1, v1, advanceX);
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public static void AddGlyph(ref ImFont self, ImFontConfigPtr srcCfg, uint c, float x0, float y0, float x1, float y1, float u0, float v0, float u1, float v1, float advanceX)
		{
			fixed (ImFont* pself = &self)
			{
				AddGlyphNative((ImFont*)pself, srcCfg, c, x0, y0, x1, y1, u0, v0, u1, v1, advanceX);
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public static void AddGlyph(ImFontPtr self, ref ImFontConfig srcCfg, uint c, float x0, float y0, float x1, float y1, float u0, float v0, float u1, float v1, float advanceX)
		{
			fixed (ImFontConfig* psrcCfg = &srcCfg)
			{
				AddGlyphNative(self, (ImFontConfig*)psrcCfg, c, x0, y0, x1, y1, u0, v0, u1, v1, advanceX);
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public static void AddGlyph(ref ImFont self, ref ImFontConfig srcCfg, uint c, float x0, float y0, float x1, float y1, float u0, float v0, float u1, float v1, float advanceX)
		{
			fixed (ImFont* pself = &self)
			{
				fixed (ImFontConfig* psrcCfg = &srcCfg)
				{
					AddGlyphNative((ImFont*)pself, (ImFontConfig*)psrcCfg, c, x0, y0, x1, y1, u0, v0, u1, v1, advanceX);
				}
			}
		}

		/// <summary>
		/// Makes 'dst' characterglyph points to 'src' characterglyph. Currently needs to be called AFTER fonts have been built.<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void AddRemapCharNative(ImFont* self, uint dst, uint src, byte overwriteDst)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<ImFont*, uint, uint, byte, void>)funcTable[671])(self, dst, src, overwriteDst);
			#else
			((delegate* unmanaged[Cdecl]<nint, uint, uint, byte, void>)funcTable[671])((nint)self, dst, src, overwriteDst);
			#endif
		}

		/// <summary>
		/// Makes 'dst' characterglyph points to 'src' characterglyph. Currently needs to be called AFTER fonts have been built.<br/>
		/// </summary>
		public static void AddRemapChar(ImFontPtr self, uint dst, uint src, bool overwriteDst)
		{
			AddRemapCharNative(self, dst, src, overwriteDst ? (byte)1 : (byte)0);
		}

		/// <summary>
		/// Makes 'dst' characterglyph points to 'src' characterglyph. Currently needs to be called AFTER fonts have been built.<br/>
		/// </summary>
		public static void AddRemapChar(ImFontPtr self, uint dst, uint src)
		{
			AddRemapCharNative(self, dst, src, (byte)(1));
		}

		/// <summary>
		/// Makes 'dst' characterglyph points to 'src' characterglyph. Currently needs to be called AFTER fonts have been built.<br/>
		/// </summary>
		public static void AddRemapChar(ref ImFont self, uint dst, uint src, bool overwriteDst)
		{
			fixed (ImFont* pself = &self)
			{
				AddRemapCharNative((ImFont*)pself, dst, src, overwriteDst ? (byte)1 : (byte)0);
			}
		}

		/// <summary>
		/// Makes 'dst' characterglyph points to 'src' characterglyph. Currently needs to be called AFTER fonts have been built.<br/>
		/// </summary>
		public static void AddRemapChar(ref ImFont self, uint dst, uint src)
		{
			fixed (ImFont* pself = &self)
			{
				AddRemapCharNative((ImFont*)pself, dst, src, (byte)(1));
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static byte IsGlyphRangeUnusedNative(ImFont* self, uint cBegin, uint cLast)
		{
			#if NET5_0_OR_GREATER
			return ((delegate* unmanaged[Cdecl]<ImFont*, uint, uint, byte>)funcTable[672])(self, cBegin, cLast);
			#else
			return (byte)((delegate* unmanaged[Cdecl]<nint, uint, uint, byte>)funcTable[672])((nint)self, cBegin, cLast);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public static bool IsGlyphRangeUnused(ImFontPtr self, uint cBegin, uint cLast)
		{
			byte ret = IsGlyphRangeUnusedNative(self, cBegin, cLast);
			return ret != 0;
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public static bool IsGlyphRangeUnused(ref ImFont self, uint cBegin, uint cLast)
		{
			fixed (ImFont* pself = &self)
			{
				byte ret = IsGlyphRangeUnusedNative((ImFont*)pself, cBegin, cLast);
				return ret != 0;
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static ImGuiViewport* ImGuiViewportNative()
		{
			#if NET5_0_OR_GREATER
			return ((delegate* unmanaged[Cdecl]<ImGuiViewport*>)funcTable[673])();
			#else
			return (ImGuiViewport*)((delegate* unmanaged[Cdecl]<nint>)funcTable[673])();
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public static ImGuiViewportPtr ImGuiViewport()
		{
			ImGuiViewportPtr ret = ImGuiViewportNative();
			return ret;
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void DestroyNative(ImGuiViewport* self)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<ImGuiViewport*, void>)funcTable[674])(self);
			#else
			((delegate* unmanaged[Cdecl]<nint, void>)funcTable[674])((nint)self);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public static void Destroy(ImGuiViewportPtr self)
		{
			DestroyNative(self);
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public static void Destroy(ref ImGuiViewport self)
		{
			fixed (ImGuiViewport* pself = &self)
			{
				DestroyNative((ImGuiViewport*)pself);
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void GetCenterNative(Vector2* pOut, ImGuiViewport* self)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<Vector2*, ImGuiViewport*, void>)funcTable[675])(pOut, self);
			#else
			((delegate* unmanaged[Cdecl]<nint, nint, void>)funcTable[675])((nint)pOut, (nint)self);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public static Vector2 GetCenter(ImGuiViewportPtr self)
		{
			Vector2 ret;
			GetCenterNative(&ret, self);
			return ret;
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public static void GetCenter(Vector2* pOut, ImGuiViewportPtr self)
		{
			GetCenterNative(pOut, self);
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public static void GetCenter(ref Vector2 pOut, ImGuiViewportPtr self)
		{
			fixed (Vector2* ppOut = &pOut)
			{
				GetCenterNative((Vector2*)ppOut, self);
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public static Vector2 GetCenter(ref ImGuiViewport self)
		{
			fixed (ImGuiViewport* pself = &self)
			{
				Vector2 ret;
				GetCenterNative(&ret, (ImGuiViewport*)pself);
				return ret;
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public static void GetCenter(Vector2* pOut, ref ImGuiViewport self)
		{
			fixed (ImGuiViewport* pself = &self)
			{
				GetCenterNative(pOut, (ImGuiViewport*)pself);
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public static void GetCenter(ref Vector2 pOut, ref ImGuiViewport self)
		{
			fixed (Vector2* ppOut = &pOut)
			{
				fixed (ImGuiViewport* pself = &self)
				{
					GetCenterNative((Vector2*)ppOut, (ImGuiViewport*)pself);
				}
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void GetWorkCenterNative(Vector2* pOut, ImGuiViewport* self)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<Vector2*, ImGuiViewport*, void>)funcTable[676])(pOut, self);
			#else
			((delegate* unmanaged[Cdecl]<nint, nint, void>)funcTable[676])((nint)pOut, (nint)self);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public static Vector2 GetWorkCenter(ImGuiViewportPtr self)
		{
			Vector2 ret;
			GetWorkCenterNative(&ret, self);
			return ret;
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public static void GetWorkCenter(Vector2* pOut, ImGuiViewportPtr self)
		{
			GetWorkCenterNative(pOut, self);
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public static void GetWorkCenter(ref Vector2 pOut, ImGuiViewportPtr self)
		{
			fixed (Vector2* ppOut = &pOut)
			{
				GetWorkCenterNative((Vector2*)ppOut, self);
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public static Vector2 GetWorkCenter(ref ImGuiViewport self)
		{
			fixed (ImGuiViewport* pself = &self)
			{
				Vector2 ret;
				GetWorkCenterNative(&ret, (ImGuiViewport*)pself);
				return ret;
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public static void GetWorkCenter(Vector2* pOut, ref ImGuiViewport self)
		{
			fixed (ImGuiViewport* pself = &self)
			{
				GetWorkCenterNative(pOut, (ImGuiViewport*)pself);
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public static void GetWorkCenter(ref Vector2 pOut, ref ImGuiViewport self)
		{
			fixed (Vector2* ppOut = &pOut)
			{
				fixed (ImGuiViewport* pself = &self)
				{
					GetWorkCenterNative((Vector2*)ppOut, (ImGuiViewport*)pself);
				}
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static ImGuiPlatformIO* ImGuiPlatformIONative()
		{
			#if NET5_0_OR_GREATER
			return ((delegate* unmanaged[Cdecl]<ImGuiPlatformIO*>)funcTable[677])();
			#else
			return (ImGuiPlatformIO*)((delegate* unmanaged[Cdecl]<nint>)funcTable[677])();
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public static ImGuiPlatformIOPtr ImGuiPlatformIO()
		{
			ImGuiPlatformIOPtr ret = ImGuiPlatformIONative();
			return ret;
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void DestroyNative(ImGuiPlatformIO* self)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<ImGuiPlatformIO*, void>)funcTable[678])(self);
			#else
			((delegate* unmanaged[Cdecl]<nint, void>)funcTable[678])((nint)self);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public static void Destroy(ImGuiPlatformIOPtr self)
		{
			DestroyNative(self);
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public static void Destroy(ref ImGuiPlatformIO self)
		{
			fixed (ImGuiPlatformIO* pself = &self)
			{
				DestroyNative((ImGuiPlatformIO*)pself);
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static ImGuiPlatformMonitor* ImGuiPlatformMonitorNative()
		{
			#if NET5_0_OR_GREATER
			return ((delegate* unmanaged[Cdecl]<ImGuiPlatformMonitor*>)funcTable[679])();
			#else
			return (ImGuiPlatformMonitor*)((delegate* unmanaged[Cdecl]<nint>)funcTable[679])();
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public static ImGuiPlatformMonitorPtr ImGuiPlatformMonitor()
		{
			ImGuiPlatformMonitorPtr ret = ImGuiPlatformMonitorNative();
			return ret;
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void DestroyNative(ImGuiPlatformMonitor* self)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<ImGuiPlatformMonitor*, void>)funcTable[680])(self);
			#else
			((delegate* unmanaged[Cdecl]<nint, void>)funcTable[680])((nint)self);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public static void Destroy(ImGuiPlatformMonitorPtr self)
		{
			DestroyNative(self);
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public static void Destroy(ref ImGuiPlatformMonitor self)
		{
			fixed (ImGuiPlatformMonitor* pself = &self)
			{
				DestroyNative((ImGuiPlatformMonitor*)pself);
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static ImGuiPlatformImeData* ImGuiPlatformImeDataNative()
		{
			#if NET5_0_OR_GREATER
			return ((delegate* unmanaged[Cdecl]<ImGuiPlatformImeData*>)funcTable[681])();
			#else
			return (ImGuiPlatformImeData*)((delegate* unmanaged[Cdecl]<nint>)funcTable[681])();
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public static ImGuiPlatformImeDataPtr ImGuiPlatformImeData()
		{
			ImGuiPlatformImeDataPtr ret = ImGuiPlatformImeDataNative();
			return ret;
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void DestroyNative(ImGuiPlatformImeData* self)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<ImGuiPlatformImeData*, void>)funcTable[682])(self);
			#else
			((delegate* unmanaged[Cdecl]<nint, void>)funcTable[682])((nint)self);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public static void Destroy(ImGuiPlatformImeDataPtr self)
		{
			DestroyNative(self);
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public static void Destroy(ref ImGuiPlatformImeData self)
		{
			fixed (ImGuiPlatformImeData* pself = &self)
			{
				DestroyNative((ImGuiPlatformImeData*)pself);
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static ImFontBuilderIO* GetBuilderForFreeTypeNative()
		{
			#if NET5_0_OR_GREATER
			return ((delegate* unmanaged[Cdecl]<ImFontBuilderIO*>)funcTable[683])();
			#else
			return (ImFontBuilderIO*)((delegate* unmanaged[Cdecl]<nint>)funcTable[683])();
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public static ImFontBuilderIOPtr GetBuilderForFreeType()
		{
			ImFontBuilderIOPtr ret = GetBuilderForFreeTypeNative();
			return ret;
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void SetAllocatorFunctionsNative(delegate*<delegate*<ulong, void*, void*>, delegate*<void*, void*, void>, void*, void*> allocFunc, delegate*<delegate*<ulong, void*, void*>, delegate*<void*, void*, void>, void*, void> freeFunc, void* userData)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<delegate*<delegate*<ulong, void*, void*>, delegate*<void*, void*, void>, void*, void*>, delegate*<delegate*<ulong, void*, void*>, delegate*<void*, void*, void>, void*, void>, void*, void>)funcTable[684])(allocFunc, freeFunc, userData);
			#else
			((delegate* unmanaged[Cdecl]<nint, nint, nint, void>)funcTable[684])((nint)allocFunc, (nint)freeFunc, (nint)userData);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public static void SetAllocatorFunctions(delegate*<delegate*<ulong, void*, void*>, delegate*<void*, void*, void>, void*, void*> allocFunc, delegate*<delegate*<ulong, void*, void*>, delegate*<void*, void*, void>, void*, void> freeFunc, void* userData)
		{
			SetAllocatorFunctionsNative(allocFunc, freeFunc, userData);
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public static void SetAllocatorFunctions(delegate*<delegate*<ulong, void*, void*>, delegate*<void*, void*, void>, void*, void*> allocFunc, delegate*<delegate*<ulong, void*, void*>, delegate*<void*, void*, void>, void*, void> freeFunc)
		{
			SetAllocatorFunctionsNative(allocFunc, freeFunc, (void*)(default));
		}

		/// <summary>
		/// pass text data straight to log (without being displayed)<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void LogTextNative(byte* fmt)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<byte*, void>)funcTable[685])(fmt);
			#else
			((delegate* unmanaged[Cdecl]<nint, void>)funcTable[685])((nint)fmt);
			#endif
		}

		/// <summary>
		/// pass text data straight to log (without being displayed)<br/>
		/// </summary>
		public static void LogText(byte* fmt)
		{
			LogTextNative(fmt);
		}

		/// <summary>
		/// pass text data straight to log (without being displayed)<br/>
		/// </summary>
		public static void LogText(ref byte fmt)
		{
			fixed (byte* pfmt = &fmt)
			{
				LogTextNative((byte*)pfmt);
			}
		}

		/// <summary>
		/// pass text data straight to log (without being displayed)<br/>
		/// </summary>
		public static void LogText(ReadOnlySpan<byte> fmt)
		{
			fixed (byte* pfmt = fmt)
			{
				LogTextNative((byte*)pfmt);
			}
		}

		/// <summary>
		/// pass text data straight to log (without being displayed)<br/>
		/// </summary>
		public static void LogText(string fmt)
		{
			byte* pStr0 = null;
			int pStrSize0 = 0;
			if (fmt != null)
			{
				pStrSize0 = Utils.GetByteCountUTF8(fmt);
				if (pStrSize0 >= Utils.MaxStackallocSize)
				{
					pStr0 = Utils.Alloc<byte>(pStrSize0 + 1);
				}
				else
				{
					byte* pStrStack0 = stackalloc byte[pStrSize0 + 1];
					pStr0 = pStrStack0;
				}
				int pStrOffset0 = Utils.EncodeStringUTF8(fmt, pStr0, pStrSize0);
				pStr0[pStrOffset0] = 0;
			}
			LogTextNative(pStr0);
			if (pStrSize0 >= Utils.MaxStackallocSize)
			{
				Utils.Free(pStr0);
			}
		}

		/// <summary>
		/// no appendfV<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void appendfNative(ImGuiTextBuffer* self, byte* fmt)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<ImGuiTextBuffer*, byte*, void>)funcTable[686])(self, fmt);
			#else
			((delegate* unmanaged[Cdecl]<nint, nint, void>)funcTable[686])((nint)self, (nint)fmt);
			#endif
		}

		/// <summary>
		/// no appendfV<br/>
		/// </summary>
		public static void appendf(ImGuiTextBufferPtr self, byte* fmt)
		{
			appendfNative(self, fmt);
		}

		/// <summary>
		/// no appendfV<br/>
		/// </summary>
		public static void appendf(ref ImGuiTextBuffer self, byte* fmt)
		{
			fixed (ImGuiTextBuffer* pself = &self)
			{
				appendfNative((ImGuiTextBuffer*)pself, fmt);
			}
		}

		/// <summary>
		/// no appendfV<br/>
		/// </summary>
		public static void appendf(ImGuiTextBufferPtr self, ref byte fmt)
		{
			fixed (byte* pfmt = &fmt)
			{
				appendfNative(self, (byte*)pfmt);
			}
		}

		/// <summary>
		/// no appendfV<br/>
		/// </summary>
		public static void appendf(ImGuiTextBufferPtr self, ReadOnlySpan<byte> fmt)
		{
			fixed (byte* pfmt = fmt)
			{
				appendfNative(self, (byte*)pfmt);
			}
		}

		/// <summary>
		/// no appendfV<br/>
		/// </summary>
		public static void appendf(ImGuiTextBufferPtr self, string fmt)
		{
			byte* pStr0 = null;
			int pStrSize0 = 0;
			if (fmt != null)
			{
				pStrSize0 = Utils.GetByteCountUTF8(fmt);
				if (pStrSize0 >= Utils.MaxStackallocSize)
				{
					pStr0 = Utils.Alloc<byte>(pStrSize0 + 1);
				}
				else
				{
					byte* pStrStack0 = stackalloc byte[pStrSize0 + 1];
					pStr0 = pStrStack0;
				}
				int pStrOffset0 = Utils.EncodeStringUTF8(fmt, pStr0, pStrSize0);
				pStr0[pStrOffset0] = 0;
			}
			appendfNative(self, pStr0);
			if (pStrSize0 >= Utils.MaxStackallocSize)
			{
				Utils.Free(pStr0);
			}
		}

		/// <summary>
		/// no appendfV<br/>
		/// </summary>
		public static void appendf(ref ImGuiTextBuffer self, ref byte fmt)
		{
			fixed (ImGuiTextBuffer* pself = &self)
			{
				fixed (byte* pfmt = &fmt)
				{
					appendfNative((ImGuiTextBuffer*)pself, (byte*)pfmt);
				}
			}
		}

		/// <summary>
		/// no appendfV<br/>
		/// </summary>
		public static void appendf(ref ImGuiTextBuffer self, ReadOnlySpan<byte> fmt)
		{
			fixed (ImGuiTextBuffer* pself = &self)
			{
				fixed (byte* pfmt = fmt)
				{
					appendfNative((ImGuiTextBuffer*)pself, (byte*)pfmt);
				}
			}
		}

		/// <summary>
		/// no appendfV<br/>
		/// </summary>
		public static void appendf(ref ImGuiTextBuffer self, string fmt)
		{
			fixed (ImGuiTextBuffer* pself = &self)
			{
				byte* pStr0 = null;
				int pStrSize0 = 0;
				if (fmt != null)
				{
					pStrSize0 = Utils.GetByteCountUTF8(fmt);
					if (pStrSize0 >= Utils.MaxStackallocSize)
					{
						pStr0 = Utils.Alloc<byte>(pStrSize0 + 1);
					}
					else
					{
						byte* pStrStack0 = stackalloc byte[pStrSize0 + 1];
						pStr0 = pStrStack0;
					}
					int pStrOffset0 = Utils.EncodeStringUTF8(fmt, pStr0, pStrSize0);
					pStr0[pStrOffset0] = 0;
				}
				appendfNative((ImGuiTextBuffer*)pself, pStr0);
				if (pStrSize0 >= Utils.MaxStackallocSize)
				{
					Utils.Free(pStr0);
				}
			}
		}

		/// <summary>
		/// for getting FLT_MAX in bindings<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static float GETFLTMAXNative()
		{
			#if NET5_0_OR_GREATER
			return ((delegate* unmanaged[Cdecl]<float>)funcTable[687])();
			#else
			return (float)((delegate* unmanaged[Cdecl]<float>)funcTable[687])();
			#endif
		}

		/// <summary>
		/// for getting FLT_MAX in bindings<br/>
		/// </summary>
		public static float GETFLTMAX()
		{
			float ret = GETFLTMAXNative();
			return ret;
		}

		/// <summary>
		/// for getting FLT_MIN in bindings<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static float GETFLTMINNative()
		{
			#if NET5_0_OR_GREATER
			return ((delegate* unmanaged[Cdecl]<float>)funcTable[688])();
			#else
			return (float)((delegate* unmanaged[Cdecl]<float>)funcTable[688])();
			#endif
		}

		/// <summary>
		/// for getting FLT_MIN in bindings<br/>
		/// </summary>
		public static float GETFLTMIN()
		{
			float ret = GETFLTMINNative();
			return ret;
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static ImVector<uint>* ImVectorImWcharCreateNative()
		{
			#if NET5_0_OR_GREATER
			return ((delegate* unmanaged[Cdecl]<ImVector<uint>*>)funcTable[689])();
			#else
			return (ImVector<uint>*)((delegate* unmanaged[Cdecl]<nint>)funcTable[689])();
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public static ImVector<uint>* ImVectorImWcharCreate()
		{
			ImVector<uint>* ret = ImVectorImWcharCreateNative();
			return ret;
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void ImVectorImWcharDestroyNative(ImVector<uint>* self)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<ImVector<uint>*, void>)funcTable[690])(self);
			#else
			((delegate* unmanaged[Cdecl]<nint, void>)funcTable[690])((nint)self);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public static void ImVectorImWcharDestroy(ImVector<uint>* self)
		{
			ImVectorImWcharDestroyNative(self);
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public static void ImVectorImWcharDestroy(ref ImVector<uint> self)
		{
			fixed (ImVector<uint>* pself = &self)
			{
				ImVectorImWcharDestroyNative((ImVector<uint>*)pself);
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void ImVectorImWcharInitNative(ImVector<uint>* p)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<ImVector<uint>*, void>)funcTable[691])(p);
			#else
			((delegate* unmanaged[Cdecl]<nint, void>)funcTable[691])((nint)p);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public static void ImVectorImWcharInit(ImVector<uint>* p)
		{
			ImVectorImWcharInitNative(p);
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public static void ImVectorImWcharInit(ref ImVector<uint> p)
		{
			fixed (ImVector<uint>* pp = &p)
			{
				ImVectorImWcharInitNative((ImVector<uint>*)pp);
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void ImVectorImWcharUnInitNative(ImVector<uint>* p)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<ImVector<uint>*, void>)funcTable[692])(p);
			#else
			((delegate* unmanaged[Cdecl]<nint, void>)funcTable[692])((nint)p);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public static void ImVectorImWcharUnInit(ImVector<uint>* p)
		{
			ImVectorImWcharUnInitNative(p);
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public static void ImVectorImWcharUnInit(ref ImVector<uint> p)
		{
			fixed (ImVector<uint>* pp = &p)
			{
				ImVectorImWcharUnInitNative((ImVector<uint>*)pp);
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void PlatformIOSetPlatformGetWindowPosNative(ImGuiPlatformIO* platformIo, delegate*<ImGuiPlatformIO*, delegate*<ImGuiViewport*, Vector2*, void>, void> userCallback)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<ImGuiPlatformIO*, delegate*<ImGuiPlatformIO*, delegate*<ImGuiViewport*, Vector2*, void>, void>, void>)funcTable[693])(platformIo, userCallback);
			#else
			((delegate* unmanaged[Cdecl]<nint, nint, void>)funcTable[693])((nint)platformIo, (nint)userCallback);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public static void PlatformIOSetPlatformGetWindowPos(ImGuiPlatformIOPtr platformIo, delegate*<ImGuiPlatformIO*, delegate*<ImGuiViewport*, Vector2*, void>, void> userCallback)
		{
			PlatformIOSetPlatformGetWindowPosNative(platformIo, userCallback);
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public static void PlatformIOSetPlatformGetWindowPos(ref ImGuiPlatformIO platformIo, delegate*<ImGuiPlatformIO*, delegate*<ImGuiViewport*, Vector2*, void>, void> userCallback)
		{
			fixed (ImGuiPlatformIO* pplatformIo = &platformIo)
			{
				PlatformIOSetPlatformGetWindowPosNative((ImGuiPlatformIO*)pplatformIo, userCallback);
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void PlatformIOSetPlatformGetWindowSizeNative(ImGuiPlatformIO* platformIo, delegate*<ImGuiPlatformIO*, delegate*<ImGuiViewport*, Vector2*, void>, void> userCallback)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<ImGuiPlatformIO*, delegate*<ImGuiPlatformIO*, delegate*<ImGuiViewport*, Vector2*, void>, void>, void>)funcTable[694])(platformIo, userCallback);
			#else
			((delegate* unmanaged[Cdecl]<nint, nint, void>)funcTable[694])((nint)platformIo, (nint)userCallback);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public static void PlatformIOSetPlatformGetWindowSize(ImGuiPlatformIOPtr platformIo, delegate*<ImGuiPlatformIO*, delegate*<ImGuiViewport*, Vector2*, void>, void> userCallback)
		{
			PlatformIOSetPlatformGetWindowSizeNative(platformIo, userCallback);
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public static void PlatformIOSetPlatformGetWindowSize(ref ImGuiPlatformIO platformIo, delegate*<ImGuiPlatformIO*, delegate*<ImGuiViewport*, Vector2*, void>, void> userCallback)
		{
			fixed (ImGuiPlatformIO* pplatformIo = &platformIo)
			{
				PlatformIOSetPlatformGetWindowSizeNative((ImGuiPlatformIO*)pplatformIo, userCallback);
			}
		}

	}
}
