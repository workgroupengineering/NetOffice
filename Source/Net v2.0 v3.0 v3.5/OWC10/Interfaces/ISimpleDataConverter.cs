//Generated by LateBindingApi.CodeGenerator
using System;
using NetRuntimeSystem = System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Reflection;
using LateBindingApi.Core;
namespace NetOffice.OWC10Api
{
	///<summary>
	/// Interface ISimpleDataConverter SupportByLibrary XWC1.0 
	///</summary>
	[SupportByLibrary("XWC1.0")]
	[EntityTypeAttribute(EntityType.IsInterface)]
	public class ISimpleDataConverter : COMObject
	{
		#pragma warning disable
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public ISimpleDataConverter(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public ISimpleDataConverter(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public ISimpleDataConverter(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public ISimpleDataConverter()
		{
		}
		
		#endregion
		
		#region Properties

		#endregion

		#region Methods

		/// <summary>
		/// SupportByLibrary XWC1.0 
		/// </summary>
		/// <param name="varSrc">object varSrc</param>
		/// <param name="vtDest">Int32 vtDest</param>
		/// <param name="pUnknownElement">object pUnknownElement</param>
		/// <param name="pvarDest">ref object pvarDest</param>
		[SupportByLibrary("XWC1.0")]
		public Int32 ConvertData(object varSrc, Int32 vtDest, object pUnknownElement, ref object pvarDest)
		{
			ParameterModifier[] modifiers = Invoker.CreateParamModifiers(false,false,false,true);
			object[] paramsArray = Invoker.ValidateParamsArray(varSrc, vtDest, pUnknownElement, pvarDest);
			object returnItem = Invoker.MethodReturn(this, "ConvertData", paramsArray);
			pvarDest = (object)paramsArray[3];
			return (Int32)returnItem;
		}

		/// <summary>
		/// SupportByLibrary XWC1.0 
		/// </summary>
		/// <param name="vt1">Int32 vt1</param>
		/// <param name="vt2">Int32 vt2</param>
		[SupportByLibrary("XWC1.0")]
		public Int32 CanConvertData(Int32 vt1, Int32 vt2)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(vt1, vt2);
			object returnItem = Invoker.MethodReturn(this, "CanConvertData", paramsArray);
			return (Int32)returnItem;
		}

		#endregion
		#pragma warning restore
	}
}