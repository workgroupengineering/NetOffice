//Generated by LateBindingApi.CodeGenerator
using System;
using NetRuntimeSystem = System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.ComponentModel;
using System.Reflection;
using LateBindingApi.Core;
namespace NetOffice.VBIDEApi
{
	///<summary>
	/// DispatchInterface _VBComponents SupportByLibrary VBE5.3 VBE12 
	///</summary>
	[SupportByLibrary("VBE5.3","VBE12")]
	[EntityTypeAttribute(EntityType.IsDispatchInterface)]
	public class _VBComponents : _VBComponents_Old
	{
		#pragma warning disable
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public _VBComponents(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public _VBComponents(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public _VBComponents(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public _VBComponents()
		{
		}
		
		#endregion
		
		#region Properties

		#endregion

		#region Methods

		/// <summary>
		/// SupportByLibrary VBE5.3 VBE12 
		/// </summary>
		/// <param name="ProgId">string ProgId</param>
		[SupportByLibrary("VBE5.3","VBE12")]
		public NetOffice.VBIDEApi.VBComponent AddCustom(string progId)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(progId);
			object returnItem = Invoker.MethodReturn(this, "AddCustom", paramsArray);
			NetOffice.VBIDEApi.VBComponent newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem) as NetOffice.VBIDEApi.VBComponent;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary VBE5.3 VBE12 
		/// </summary>
		/// <param name="index">Int32 index</param>
		[SupportByLibrary("VBE5.3","VBE12")]
		public NetOffice.VBIDEApi.VBComponent AddMTDesigner(Int32 index)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(index);
			object returnItem = Invoker.MethodReturn(this, "AddMTDesigner", paramsArray);
			NetOffice.VBIDEApi.VBComponent newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem) as NetOffice.VBIDEApi.VBComponent;
			return newObject;
		}

		#endregion
		#pragma warning restore
	}
}