//Generated by LateBindingApi.CodeGenerator
using System;
using NetRuntimeSystem = System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Reflection;
using LateBindingApi.Core;
namespace NetOffice.ExcelApi
{
	///<summary>
	/// Interface IChartFillFormat SupportByLibrary XL09 XL10 XL11 XL12 XL14 
	///</summary>
	[SupportByLibrary("XL09","XL10","XL11","XL12","XL14")]
	[EntityTypeAttribute(EntityType.IsInterface)]
	public class IChartFillFormat : COMObject
	{
		#pragma warning disable
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IChartFillFormat(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IChartFillFormat(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IChartFillFormat(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IChartFillFormat()
		{
		}
		
		#endregion
		
		#region Properties

		/// <summary>
		/// SupportByLibrary XL09 XL10 XL11 XL12 XL14 
		/// </summary>
		[SupportByLibrary("XL09","XL10","XL11","XL12","XL14")]
		public NetOffice.ExcelApi.Application Application
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Application", paramsArray);
				NetOffice.ExcelApi.Application newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.ExcelApi.Application;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary XL09 XL10 XL11 XL12 XL14 
		/// </summary>
		[SupportByLibrary("XL09","XL10","XL11","XL12","XL14")]
		public NetOffice.ExcelApi.Enums.XlCreator Creator
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Creator", paramsArray);
				return (NetOffice.ExcelApi.Enums.XlCreator)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary XL09 XL10 XL11 XL12 XL14 
		/// </summary>
		[SupportByLibrary("XL09","XL10","XL11","XL12","XL14")]
		public COMObject Parent
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Parent", paramsArray);
				COMObject newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem);
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary XL09 XL10 XL11 XL12 XL14 
		/// </summary>
		[SupportByLibrary("XL09","XL10","XL11","XL12","XL14")]
		public NetOffice.ExcelApi.ChartColorFormat BackColor
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "BackColor", paramsArray);
				NetOffice.ExcelApi.ChartColorFormat newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.ExcelApi.ChartColorFormat;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary XL09 XL10 XL11 XL12 XL14 
		/// </summary>
		[SupportByLibrary("XL09","XL10","XL11","XL12","XL14")]
		public NetOffice.ExcelApi.ChartColorFormat ForeColor
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ForeColor", paramsArray);
				NetOffice.ExcelApi.ChartColorFormat newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.ExcelApi.ChartColorFormat;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary XL09 XL10 XL11 XL12 XL14 
		/// </summary>
		[SupportByLibrary("XL09","XL10","XL11","XL12","XL14")]
		public NetOffice.OfficeApi.Enums.MsoGradientColorType GradientColorType
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "GradientColorType", paramsArray);
				return (NetOffice.OfficeApi.Enums.MsoGradientColorType)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary XL09 XL10 XL11 XL12 XL14 
		/// </summary>
		[SupportByLibrary("XL09","XL10","XL11","XL12","XL14")]
		public Single GradientDegree
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "GradientDegree", paramsArray);
				return (Single)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary XL09 XL10 XL11 XL12 XL14 
		/// </summary>
		[SupportByLibrary("XL09","XL10","XL11","XL12","XL14")]
		public NetOffice.OfficeApi.Enums.MsoGradientStyle GradientStyle
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "GradientStyle", paramsArray);
				return (NetOffice.OfficeApi.Enums.MsoGradientStyle)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary XL09 XL10 XL11 XL12 XL14 
		/// </summary>
		[SupportByLibrary("XL09","XL10","XL11","XL12","XL14")]
		public Int32 GradientVariant
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "GradientVariant", paramsArray);
				return (Int32)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary XL09 XL10 XL11 XL12 XL14 
		/// </summary>
		[SupportByLibrary("XL09","XL10","XL11","XL12","XL14")]
		public NetOffice.OfficeApi.Enums.MsoPatternType Pattern
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Pattern", paramsArray);
				return (NetOffice.OfficeApi.Enums.MsoPatternType)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary XL09 XL10 XL11 XL12 XL14 
		/// </summary>
		[SupportByLibrary("XL09","XL10","XL11","XL12","XL14")]
		public NetOffice.OfficeApi.Enums.MsoPresetGradientType PresetGradientType
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "PresetGradientType", paramsArray);
				return (NetOffice.OfficeApi.Enums.MsoPresetGradientType)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary XL09 XL10 XL11 XL12 XL14 
		/// </summary>
		[SupportByLibrary("XL09","XL10","XL11","XL12","XL14")]
		public NetOffice.OfficeApi.Enums.MsoPresetTexture PresetTexture
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "PresetTexture", paramsArray);
				return (NetOffice.OfficeApi.Enums.MsoPresetTexture)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary XL09 XL10 XL11 XL12 XL14 
		/// </summary>
		[SupportByLibrary("XL09","XL10","XL11","XL12","XL14")]
		public string TextureName
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "TextureName", paramsArray);
				return (string)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary XL09 XL10 XL11 XL12 XL14 
		/// </summary>
		[SupportByLibrary("XL09","XL10","XL11","XL12","XL14")]
		public NetOffice.OfficeApi.Enums.MsoTextureType TextureType
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "TextureType", paramsArray);
				return (NetOffice.OfficeApi.Enums.MsoTextureType)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary XL09 XL10 XL11 XL12 XL14 
		/// </summary>
		[SupportByLibrary("XL09","XL10","XL11","XL12","XL14")]
		public NetOffice.OfficeApi.Enums.MsoFillType Type
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Type", paramsArray);
				return (NetOffice.OfficeApi.Enums.MsoFillType)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary XL09 XL10 XL11 XL12 XL14 
		/// </summary>
		[SupportByLibrary("XL09","XL10","XL11","XL12","XL14")]
		public NetOffice.OfficeApi.Enums.MsoTriState Visible
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Visible", paramsArray);
				return (NetOffice.OfficeApi.Enums.MsoTriState)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Visible", paramsArray);
			}
		}

		#endregion

		#region Methods

		/// <summary>
		/// SupportByLibrary XL09 XL10 XL11 XL12 XL14 
		/// </summary>
		/// <param name="Style">NetOffice.OfficeApi.Enums.MsoGradientStyle Style</param>
		/// <param name="Variant">Int32 Variant</param>
		/// <param name="Degree">Single Degree</param>
		[SupportByLibrary("XL09","XL10","XL11","XL12","XL14")]
		public Int32 OneColorGradient(NetOffice.OfficeApi.Enums.MsoGradientStyle style, Int32 variant, Single degree)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(style, variant, degree);
			object returnItem = Invoker.MethodReturn(this, "OneColorGradient", paramsArray);
			return (Int32)returnItem;
		}

		/// <summary>
		/// SupportByLibrary XL09 XL10 XL11 XL12 XL14 
		/// </summary>
		/// <param name="Style">NetOffice.OfficeApi.Enums.MsoGradientStyle Style</param>
		/// <param name="Variant">Int32 Variant</param>
		[SupportByLibrary("XL09","XL10","XL11","XL12","XL14")]
		public Int32 TwoColorGradient(NetOffice.OfficeApi.Enums.MsoGradientStyle style, Int32 variant)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(style, variant);
			object returnItem = Invoker.MethodReturn(this, "TwoColorGradient", paramsArray);
			return (Int32)returnItem;
		}

		/// <summary>
		/// SupportByLibrary XL09 XL10 XL11 XL12 XL14 
		/// </summary>
		/// <param name="PresetTexture">NetOffice.OfficeApi.Enums.MsoPresetTexture PresetTexture</param>
		[SupportByLibrary("XL09","XL10","XL11","XL12","XL14")]
		public Int32 PresetTextured(NetOffice.OfficeApi.Enums.MsoPresetTexture presetTexture)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(presetTexture);
			object returnItem = Invoker.MethodReturn(this, "PresetTextured", paramsArray);
			return (Int32)returnItem;
		}

		/// <summary>
		/// SupportByLibrary XL09 XL10 XL11 XL12 XL14 
		/// </summary>
		[SupportByLibrary("XL09","XL10","XL11","XL12","XL14")]
		public Int32 Solid()
		{
			object[] paramsArray = null;
			object returnItem = Invoker.MethodReturn(this, "Solid", paramsArray);
			return (Int32)returnItem;
		}

		/// <summary>
		/// SupportByLibrary XL09 XL10 XL11 XL12 XL14 
		/// </summary>
		/// <param name="Pattern">NetOffice.OfficeApi.Enums.MsoPatternType Pattern</param>
		[SupportByLibrary("XL09","XL10","XL11","XL12","XL14")]
		public Int32 Patterned(NetOffice.OfficeApi.Enums.MsoPatternType pattern)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(pattern);
			object returnItem = Invoker.MethodReturn(this, "Patterned", paramsArray);
			return (Int32)returnItem;
		}

		/// <summary>
		/// SupportByLibrary XL09 XL10 XL11 XL12 XL14 
		/// </summary>
		/// <param name="PictureFile">optional object PictureFile</param>
		/// <param name="PictureFormat">optional object PictureFormat</param>
		/// <param name="PictureStackUnit">optional object PictureStackUnit</param>
		/// <param name="PicturePlacement">optional object PicturePlacement</param>
		[SupportByLibrary("XL09","XL10","XL11","XL12","XL14")]
		public Int32 UserPicture(object pictureFile, object pictureFormat, object pictureStackUnit, object picturePlacement)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(pictureFile, pictureFormat, pictureStackUnit, picturePlacement);
			object returnItem = Invoker.MethodReturn(this, "UserPicture", paramsArray);
			return (Int32)returnItem;
		}

		/// <summary>
		/// SupportByLibrary XL09 XL10 XL11 XL12 XL14 
		/// </summary>
		[SupportByLibrary("XL09","XL10","XL11","XL12","XL14")]
		public Int32 UserPicture()
		{
			object[] paramsArray = null;
			object returnItem = Invoker.MethodReturn(this, "UserPicture", paramsArray);
			return (Int32)returnItem;
		}

		/// <summary>
		/// SupportByLibrary XL09 XL10 XL11 XL12 XL14 
		/// </summary>
		/// <param name="TextureFile">string TextureFile</param>
		[SupportByLibrary("XL09","XL10","XL11","XL12","XL14")]
		public Int32 UserTextured(string textureFile)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(textureFile);
			object returnItem = Invoker.MethodReturn(this, "UserTextured", paramsArray);
			return (Int32)returnItem;
		}

		/// <summary>
		/// SupportByLibrary XL09 XL10 XL11 XL12 XL14 
		/// </summary>
		/// <param name="Style">NetOffice.OfficeApi.Enums.MsoGradientStyle Style</param>
		/// <param name="Variant">Int32 Variant</param>
		/// <param name="PresetGradientType">NetOffice.OfficeApi.Enums.MsoPresetGradientType PresetGradientType</param>
		[SupportByLibrary("XL09","XL10","XL11","XL12","XL14")]
		public Int32 PresetGradient(NetOffice.OfficeApi.Enums.MsoGradientStyle style, Int32 variant, NetOffice.OfficeApi.Enums.MsoPresetGradientType presetGradientType)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(style, variant, presetGradientType);
			object returnItem = Invoker.MethodReturn(this, "PresetGradient", paramsArray);
			return (Int32)returnItem;
		}

		#endregion
		#pragma warning restore
	}
}