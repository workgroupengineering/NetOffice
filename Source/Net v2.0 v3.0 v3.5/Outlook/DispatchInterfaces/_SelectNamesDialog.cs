//Generated by LateBindingApi.CodeGenerator
using System;
using NetRuntimeSystem = System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.ComponentModel;
using System.Reflection;
using LateBindingApi.Core;
namespace NetOffice.OutlookApi
{
	///<summary>
	/// DispatchInterface _SelectNamesDialog SupportByLibrary OL12 OL14 
	///</summary>
	[SupportByLibrary("OL12","OL14")]
	[EntityTypeAttribute(EntityType.IsDispatchInterface)]
	public class _SelectNamesDialog : COMObject
	{
		#pragma warning disable
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public _SelectNamesDialog(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public _SelectNamesDialog(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public _SelectNamesDialog(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public _SelectNamesDialog()
		{
		}
		
		#endregion
		
		#region Properties

		/// <summary>
		/// SupportByLibrary OL12 OL14 
		/// </summary>
		[SupportByLibrary("OL12","OL14")]
		public NetOffice.OutlookApi._Application Application
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Application", paramsArray);
				NetOffice.OutlookApi._Application newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.OutlookApi._Application;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary OL12 OL14 
		/// </summary>
		[SupportByLibrary("OL12","OL14")]
		public NetOffice.OutlookApi.Enums.OlObjectClass Class
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Class", paramsArray);
				return (NetOffice.OutlookApi.Enums.OlObjectClass)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary OL12 OL14 
		/// </summary>
		[SupportByLibrary("OL12","OL14")]
		public NetOffice.OutlookApi._NameSpace Session
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Session", paramsArray);
				NetOffice.OutlookApi._NameSpace newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.OutlookApi._NameSpace;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary OL12 OL14 
		/// </summary>
		[SupportByLibrary("OL12","OL14")]
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
		/// SupportByLibrary OL12 OL14 
		/// </summary>
		[SupportByLibrary("OL12","OL14")]
		public string Caption
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Caption", paramsArray);
				return (string)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Caption", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary OL12 OL14 
		/// </summary>
		[SupportByLibrary("OL12","OL14")]
		public NetOffice.OutlookApi.Recipients Recipients
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Recipients", paramsArray);
				NetOffice.OutlookApi.Recipients newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.OutlookApi.Recipients;
				return newObject;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Recipients", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary OL12 OL14 
		/// </summary>
		[SupportByLibrary("OL12","OL14")]
		public string BccLabel
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "BccLabel", paramsArray);
				return (string)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "BccLabel", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary OL12 OL14 
		/// </summary>
		[SupportByLibrary("OL12","OL14")]
		public string CcLabel
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "CcLabel", paramsArray);
				return (string)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "CcLabel", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary OL12 OL14 
		/// </summary>
		[SupportByLibrary("OL12","OL14")]
		public string ToLabel
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ToLabel", paramsArray);
				return (string)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "ToLabel", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary OL12 OL14 
		/// </summary>
		[SupportByLibrary("OL12","OL14")]
		public bool AllowMultipleSelection
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "AllowMultipleSelection", paramsArray);
				return (bool)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "AllowMultipleSelection", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary OL12 OL14 
		/// </summary>
		[SupportByLibrary("OL12","OL14")]
		public bool ForceResolution
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ForceResolution", paramsArray);
				return (bool)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "ForceResolution", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary OL12 OL14 
		/// </summary>
		[SupportByLibrary("OL12","OL14")]
		public bool ShowOnlyInitialAddressList
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ShowOnlyInitialAddressList", paramsArray);
				return (bool)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "ShowOnlyInitialAddressList", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary OL12 OL14 
		/// </summary>
		[SupportByLibrary("OL12","OL14")]
		public NetOffice.OutlookApi.Enums.OlRecipientSelectors NumberOfRecipientSelectors
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "NumberOfRecipientSelectors", paramsArray);
				return (NetOffice.OutlookApi.Enums.OlRecipientSelectors)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "NumberOfRecipientSelectors", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary OL12 OL14 
		/// </summary>
		[SupportByLibrary("OL12","OL14")]
		public NetOffice.OutlookApi.AddressList InitialAddressList
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "InitialAddressList", paramsArray);
				NetOffice.OutlookApi.AddressList newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.OutlookApi.AddressList;
				return newObject;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "InitialAddressList", paramsArray);
			}
		}

		#endregion

		#region Methods

		/// <summary>
		/// SupportByLibrary OL12 OL14 
		/// </summary>
		[SupportByLibrary("OL12","OL14")]
		public bool Display()
		{
			object[] paramsArray = null;
			object returnItem = Invoker.MethodReturn(this, "Display", paramsArray);
			return (bool)returnItem;
		}

		/// <summary>
		/// SupportByLibrary OL12 OL14 
		/// </summary>
		/// <param name="defaultMode">NetOffice.OutlookApi.Enums.OlDefaultSelectNamesDisplayMode defaultMode</param>
		[SupportByLibrary("OL12","OL14")]
		public void SetDefaultDisplayMode(NetOffice.OutlookApi.Enums.OlDefaultSelectNamesDisplayMode defaultMode)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(defaultMode);
			Invoker.Method(this, "SetDefaultDisplayMode", paramsArray);
		}

		#endregion
		#pragma warning restore
	}
}