//Generated by LateBindingApi.CodeGenerator
using System;
using NetRuntimeSystem = System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.ComponentModel;
using System.Reflection;
using LateBindingApi.Core;
namespace NetOffice.OfficeApi
{
	///<summary>
	/// DispatchInterface LanguageSettings SupportByLibrary OF09 OF10 OF11 OF12 OF14 
	///</summary>
	[SupportByLibrary("OF09","OF10","OF11","OF12","OF14")]
	[EntityTypeAttribute(EntityType.IsDispatchInterface)]
	public class LanguageSettings : _IMsoDispObj
	{
		#pragma warning disable
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public LanguageSettings(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public LanguageSettings(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public LanguageSettings(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public LanguageSettings()
		{
		}
		
		#endregion
		
		#region Properties

		/// <summary>
		/// SupportByLibrary OF09 OF10 OF11 OF12 OF14 
		/// </summary>
		/// <param name="Id">NetOffice.OfficeApi.Enums.MsoAppLanguageID Id</param>
		[SupportByLibrary("OF09","OF10","OF11","OF12","OF14")]
		public Int32 get_LanguageID(NetOffice.OfficeApi.Enums.MsoAppLanguageID id)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(id);
			object returnItem = Invoker.PropertyGet(this, "LanguageID", paramsArray);
			return (Int32)returnItem;
		}

		/// <summary>
		/// SupportByLibrary OF09 OF10 OF11 OF12 OF14 
		/// </summary>
		/// <param name="lid">NetOffice.OfficeApi.Enums.MsoLanguageID lid</param>
		[SupportByLibrary("OF09","OF10","OF11","OF12","OF14")]
		public bool get_LanguagePreferredForEditing(NetOffice.OfficeApi.Enums.MsoLanguageID lid)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(lid);
			object returnItem = Invoker.PropertyGet(this, "LanguagePreferredForEditing", paramsArray);
			return (bool)returnItem;
		}

		/// <summary>
		/// SupportByLibrary OF10 OF11 OF12 OF14 
		/// </summary>
		[SupportByLibrary("OF10","OF11","OF12","OF14")]
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

		#endregion

		#region Methods

		#endregion
		#pragma warning restore
	}
}