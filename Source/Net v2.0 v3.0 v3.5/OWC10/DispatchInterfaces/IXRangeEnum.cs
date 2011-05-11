//Generated by LateBindingApi.CodeGenerator
using System;
using NetRuntimeSystem = System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.ComponentModel;
using System.Reflection;
using LateBindingApi.Core;
namespace NetOffice.OWC10Api
{
	///<summary>
	/// DispatchInterface IXRangeEnum SupportByLibrary XWC1.0 
	///</summary>
	[SupportByLibrary("XWC1.0")]
	[EntityTypeAttribute(EntityType.IsDispatchInterface)]
	public class IXRangeEnum : COMObject
	{
		#pragma warning disable
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IXRangeEnum(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IXRangeEnum(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IXRangeEnum(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IXRangeEnum()
		{
		}
		
		#endregion
		
		#region Properties

		/// <summary>
		/// SupportByLibrary XWC1.0 
		/// </summary>
		[SupportByLibrary("XWC1.0")]
		public UIntPtr RowCount
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "RowCount", paramsArray);
				return (UIntPtr)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary XWC1.0 
		/// </summary>
		[SupportByLibrary("XWC1.0")]
		public UIntPtr ColCount
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ColCount", paramsArray);
				return (UIntPtr)returnItem;
			}
		}

		#endregion

		#region Methods

		/// <summary>
		/// SupportByLibrary XWC1.0 
		/// </summary>
		/// <param name="cElt">Int32 cElt</param>
		/// <param name="rgvar">ref object rgvar</param>
		/// <param name="pcEltFetched">ref Int32 pcEltFetched</param>
		[SupportByLibrary("XWC1.0")]
		public void Next(Int32 cElt, ref object rgvar, ref Int32 pcEltFetched)
		{
			ParameterModifier[] modifiers = Invoker.CreateParamModifiers(false,true,true);
			object[] paramsArray = Invoker.ValidateParamsArray(cElt, rgvar, pcEltFetched);
			Invoker.Method(this, "Next", paramsArray, modifiers);
			rgvar = (object)paramsArray[1];
			pcEltFetched = (Int32)paramsArray[2];
		}

		/// <summary>
		/// SupportByLibrary XWC1.0 
		/// </summary>
		/// <param name="cElt">Int32 cElt</param>
		[SupportByLibrary("XWC1.0")]
		public void Skip(Int32 cElt)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(cElt);
			Invoker.Method(this, "Skip", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary XWC1.0 
		/// </summary>
		[SupportByLibrary("XWC1.0")]
		public void Reset()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "Reset", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary XWC1.0 
		/// </summary>
		/// <param name="ppEnum">ref NetOffice.OWC10Api.IXRangeEnum ppEnum</param>
		[SupportByLibrary("XWC1.0")]
		public void Clone(ref NetOffice.OWC10Api.IXRangeEnum ppEnum)
		{
			ParameterModifier[] modifiers = Invoker.CreateParamModifiers(true);
			object[] paramsArray = Invoker.ValidateParamsArray(ppEnum);
			Invoker.Method(this, "Clone", paramsArray, modifiers);
			ppEnum = (NetOffice.OWC10Api.IXRangeEnum)paramsArray[0];
		}

		/// <summary>
		/// SupportByLibrary XWC1.0 
		/// </summary>
		/// <param name="nTraverseCode">UIntPtr nTraverseCode</param>
		[SupportByLibrary("XWC1.0")]
		public void SetTraversal(UIntPtr nTraverseCode)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(nTraverseCode);
			Invoker.Method(this, "SetTraversal", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary XWC1.0 
		/// </summary>
		/// <param name="Out">ref object Out</param>
		/// <param name="In">ref object In</param>
		/// <param name="vt">Int16 vt</param>
		[SupportByLibrary("XWC1.0")]
		public void ChangeType(ref object _out, ref object _in, Int16 vt)
		{
			ParameterModifier[] modifiers = Invoker.CreateParamModifiers(true,true,false);
			object[] paramsArray = Invoker.ValidateParamsArray(_out, _in, vt);
			Invoker.Method(this, "ChangeType", paramsArray, modifiers);
			_out = (object)paramsArray[0];
			_in = (object)paramsArray[1];
		}

		/// <summary>
		/// SupportByLibrary XWC1.0 
		/// </summary>
		/// <param name="cElt">Int32 cElt</param>
		/// <param name="iStart">Int32 iStart</param>
		/// <param name="rvarDest">ref object rvarDest</param>
		/// <param name="pcFetched">ref Int32 pcFetched</param>
		/// <param name="vtCoerceTo">Int16 vtCoerceTo</param>
		/// <param name="vtbCoerceFrom">Int32 vtbCoerceFrom</param>
		/// <param name="Fill">ref object Fill</param>
		[SupportByLibrary("XWC1.0")]
		public void GetElements(Int32 cElt, Int32 iStart, ref object rvarDest, ref Int32 pcFetched, Int16 vtCoerceTo, Int32 vtbCoerceFrom, ref object fill)
		{
			ParameterModifier[] modifiers = Invoker.CreateParamModifiers(false,false,true,true,false,false,true);
			object[] paramsArray = Invoker.ValidateParamsArray(cElt, iStart, rvarDest, pcFetched, vtCoerceTo, vtbCoerceFrom, fill);
			Invoker.Method(this, "GetElements", paramsArray, modifiers);
			rvarDest = (object)paramsArray[2];
			pcFetched = (Int32)paramsArray[3];
			fill = (object)paramsArray[6];
		}

		#endregion
		#pragma warning restore
	}
}