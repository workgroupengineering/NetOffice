//Generated by LateBindingApi.CodeGenerator
using System;
using NetRuntimeSystem = System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.ComponentModel;
using System.Reflection;
using LateBindingApi.Core;
namespace NetOffice.MSComctlLibApi
{
	///<summary>
	/// DispatchInterface IImageList SupportByLibrary WCC6.0 
	///</summary>
	[SupportByLibrary("WCC6.0")]
	[EntityTypeAttribute(EntityType.IsDispatchInterface)]
	public class IImageList : COMObject
	{
		#pragma warning disable
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IImageList(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IImageList(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IImageList(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IImageList()
		{
		}
		
		#endregion
		
		#region Properties

		/// <summary>
		/// SupportByLibrary WCC6.0 
		/// </summary>
		[SupportByLibrary("WCC6.0")]
		public Int16 ImageHeight
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ImageHeight", paramsArray);
				return (Int16)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "ImageHeight", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary WCC6.0 
		/// </summary>
		[SupportByLibrary("WCC6.0")]
		public Int16 ImageWidth
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ImageWidth", paramsArray);
				return (Int16)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "ImageWidth", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary WCC6.0 
		/// </summary>
		[SupportByLibrary("WCC6.0")]
		public Int32 MaskColor
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "MaskColor", paramsArray);
				return (Int32)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "MaskColor", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary WCC6.0 
		/// </summary>
		[SupportByLibrary("WCC6.0")]
		public bool UseMaskColor
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "UseMaskColor", paramsArray);
				return (bool)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "UseMaskColor", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary WCC6.0 
		/// </summary>
		[SupportByLibrary("WCC6.0")]
		public NetOffice.MSComctlLibApi.IImages ListImages
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ListImages", paramsArray);
				NetOffice.MSComctlLibApi.IImages newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.MSComctlLibApi.IImages;
				return newObject;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "ListImages", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary WCC6.0 
		/// </summary>
		[SupportByLibrary("WCC6.0")]
		public Int32 hImageList
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "hImageList", paramsArray);
				return (Int32)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "hImageList", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary WCC6.0 
		/// </summary>
		[SupportByLibrary("WCC6.0")]
		public Int32 BackColor
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "BackColor", paramsArray);
				return (Int32)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "BackColor", paramsArray);
			}
		}

		#endregion

		#region Methods

		/// <summary>
		/// SupportByLibrary WCC6.0 
		/// </summary>
		/// <param name="Key1">ref object Key1</param>
		/// <param name="Key2">ref object Key2</param>
		[SupportByLibrary("WCC6.0")]
		public stdole.Picture Overlay(ref object key1, ref object key2)
		{
			ParameterModifier[] modifiers = Invoker.CreateParamModifiers(true,true);
			object[] paramsArray = Invoker.ValidateParamsArray(key1, key2);
			object returnItem = Invoker.MethodReturn(this, "Overlay", paramsArray, modifiers);
			stdole.Picture newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem) as stdole.Picture;
			key1 = (object)paramsArray[0];
			key2 = (object)paramsArray[1];
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary WCC6.0 
		/// </summary>
		[SupportByLibrary("WCC6.0")]
		public void AboutBox()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "AboutBox", paramsArray);
		}

		#endregion
		#pragma warning restore
	}
}