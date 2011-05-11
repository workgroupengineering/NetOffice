//Generated by LateBindingApi.CodeGenerator
using System;
using NetRuntimeSystem = System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Reflection;
using LateBindingApi.Core;
namespace NetOffice.MSDATASRCApi
{
	///<summary>
	/// Interface DataSourceListener SupportByLibrary DSI1.0 
	///</summary>
	[SupportByLibrary("DSI1.0")]
	[EntityTypeAttribute(EntityType.IsInterface)]
	public class DataSourceListener : COMObject
	{
		#pragma warning disable
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public DataSourceListener(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public DataSourceListener(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public DataSourceListener(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public DataSourceListener()
		{
		}
		
		#endregion
		
		#region Properties

		#endregion

		#region Methods

		/// <summary>
		/// SupportByLibrary DSI1.0 
		/// </summary>
		/// <param name="bstrDM">string bstrDM</param>
		[SupportByLibrary("DSI1.0")]
		public Int32 dataMemberChanged(string bstrDM)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(bstrDM);
			object returnItem = Invoker.MethodReturn(this, "dataMemberChanged", paramsArray);
			return (Int32)returnItem;
		}

		/// <summary>
		/// SupportByLibrary DSI1.0 
		/// </summary>
		/// <param name="bstrDM">string bstrDM</param>
		[SupportByLibrary("DSI1.0")]
		public Int32 dataMemberAdded(string bstrDM)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(bstrDM);
			object returnItem = Invoker.MethodReturn(this, "dataMemberAdded", paramsArray);
			return (Int32)returnItem;
		}

		/// <summary>
		/// SupportByLibrary DSI1.0 
		/// </summary>
		/// <param name="bstrDM">string bstrDM</param>
		[SupportByLibrary("DSI1.0")]
		public Int32 dataMemberRemoved(string bstrDM)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(bstrDM);
			object returnItem = Invoker.MethodReturn(this, "dataMemberRemoved", paramsArray);
			return (Int32)returnItem;
		}

		#endregion
		#pragma warning restore
	}
}