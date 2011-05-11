//Generated by LateBindingApi.CodeGenerator
using System;
using NetRuntimeSystem = System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.ComponentModel;
using System.Reflection;
using LateBindingApi.Core;
namespace NetOffice.AccessApi
{
	///<summary>
	/// DispatchInterface _RecordsetEvents SupportByLibrary AC09 AC10 AC11 AC12 AC14 
	///</summary>
	[SupportByLibrary("AC09","AC10","AC11","AC12","AC14")]
	[EntityTypeAttribute(EntityType.IsDispatchInterface)]
	public class _RecordsetEvents : COMObject
	{
		#pragma warning disable
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public _RecordsetEvents(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public _RecordsetEvents(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public _RecordsetEvents(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public _RecordsetEvents()
		{
		}
		
		#endregion
		
		#region Properties

		#endregion

		#region Methods

		/// <summary>
		/// SupportByLibrary AC09 AC10 AC11 AC12 AC14 
		/// </summary>
		/// <param name="cFields">Int32 cFields</param>
		/// <param name="Fields">object Fields</param>
		/// <param name="adStatus">NetOffice.ADODBApi.Enums.EventStatusEnum adStatus</param>
		/// <param name="pRecordset">object pRecordset</param>
		[SupportByLibrary("AC09","AC10","AC11","AC12","AC14")]
		public void WillChangeField(Int32 cFields, object fields, NetOffice.ADODBApi.Enums.EventStatusEnum adStatus, object pRecordset)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(cFields, fields, adStatus, pRecordset);
			Invoker.Method(this, "WillChangeField", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary AC09 AC10 AC11 AC12 AC14 
		/// </summary>
		/// <param name="cFields">Int32 cFields</param>
		/// <param name="Fields">object Fields</param>
		/// <param name="pError">object pError</param>
		/// <param name="adStatus">NetOffice.ADODBApi.Enums.EventStatusEnum adStatus</param>
		/// <param name="pRecordset">object pRecordset</param>
		[SupportByLibrary("AC09","AC10","AC11","AC12","AC14")]
		public void FieldChangeComplete(Int32 cFields, object fields, object pError, NetOffice.ADODBApi.Enums.EventStatusEnum adStatus, object pRecordset)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(cFields, fields, pError, adStatus, pRecordset);
			Invoker.Method(this, "FieldChangeComplete", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary AC09 AC10 AC11 AC12 AC14 
		/// </summary>
		/// <param name="adReason">NetOffice.ADODBApi.Enums.EventReasonEnum adReason</param>
		/// <param name="cRecords">Int32 cRecords</param>
		/// <param name="adStatus">NetOffice.ADODBApi.Enums.EventStatusEnum adStatus</param>
		/// <param name="pRecordset">object pRecordset</param>
		[SupportByLibrary("AC09","AC10","AC11","AC12","AC14")]
		public void WillChangeRecord(NetOffice.ADODBApi.Enums.EventReasonEnum adReason, Int32 cRecords, NetOffice.ADODBApi.Enums.EventStatusEnum adStatus, object pRecordset)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(adReason, cRecords, adStatus, pRecordset);
			Invoker.Method(this, "WillChangeRecord", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary AC09 AC10 AC11 AC12 AC14 
		/// </summary>
		/// <param name="adReason">NetOffice.ADODBApi.Enums.EventReasonEnum adReason</param>
		/// <param name="cRecords">Int32 cRecords</param>
		/// <param name="pError">object pError</param>
		/// <param name="adStatus">NetOffice.ADODBApi.Enums.EventStatusEnum adStatus</param>
		/// <param name="pRecordset">object pRecordset</param>
		[SupportByLibrary("AC09","AC10","AC11","AC12","AC14")]
		public void RecordChangeComplete(NetOffice.ADODBApi.Enums.EventReasonEnum adReason, Int32 cRecords, object pError, NetOffice.ADODBApi.Enums.EventStatusEnum adStatus, object pRecordset)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(adReason, cRecords, pError, adStatus, pRecordset);
			Invoker.Method(this, "RecordChangeComplete", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary AC09 AC10 AC11 AC12 AC14 
		/// </summary>
		/// <param name="adReason">NetOffice.ADODBApi.Enums.EventReasonEnum adReason</param>
		/// <param name="adStatus">NetOffice.ADODBApi.Enums.EventStatusEnum adStatus</param>
		/// <param name="pRecordset">object pRecordset</param>
		[SupportByLibrary("AC09","AC10","AC11","AC12","AC14")]
		public void WillChangeRecordset(NetOffice.ADODBApi.Enums.EventReasonEnum adReason, NetOffice.ADODBApi.Enums.EventStatusEnum adStatus, object pRecordset)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(adReason, adStatus, pRecordset);
			Invoker.Method(this, "WillChangeRecordset", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary AC09 AC10 AC11 AC12 AC14 
		/// </summary>
		/// <param name="adReason">NetOffice.ADODBApi.Enums.EventReasonEnum adReason</param>
		/// <param name="pError">object pError</param>
		/// <param name="adStatus">NetOffice.ADODBApi.Enums.EventStatusEnum adStatus</param>
		/// <param name="pRecordset">object pRecordset</param>
		[SupportByLibrary("AC09","AC10","AC11","AC12","AC14")]
		public void RecordsetChangeComplete(NetOffice.ADODBApi.Enums.EventReasonEnum adReason, object pError, NetOffice.ADODBApi.Enums.EventStatusEnum adStatus, object pRecordset)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(adReason, pError, adStatus, pRecordset);
			Invoker.Method(this, "RecordsetChangeComplete", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary AC09 AC10 AC11 AC12 AC14 
		/// </summary>
		/// <param name="adReason">NetOffice.ADODBApi.Enums.EventReasonEnum adReason</param>
		/// <param name="adStatus">NetOffice.ADODBApi.Enums.EventStatusEnum adStatus</param>
		/// <param name="pRecordset">object pRecordset</param>
		[SupportByLibrary("AC09","AC10","AC11","AC12","AC14")]
		public void WillMove(NetOffice.ADODBApi.Enums.EventReasonEnum adReason, NetOffice.ADODBApi.Enums.EventStatusEnum adStatus, object pRecordset)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(adReason, adStatus, pRecordset);
			Invoker.Method(this, "WillMove", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary AC09 AC10 AC11 AC12 AC14 
		/// </summary>
		/// <param name="adReason">NetOffice.ADODBApi.Enums.EventReasonEnum adReason</param>
		/// <param name="pError">object pError</param>
		/// <param name="adStatus">NetOffice.ADODBApi.Enums.EventStatusEnum adStatus</param>
		/// <param name="pRecordset">object pRecordset</param>
		[SupportByLibrary("AC09","AC10","AC11","AC12","AC14")]
		public void MoveComplete(NetOffice.ADODBApi.Enums.EventReasonEnum adReason, object pError, NetOffice.ADODBApi.Enums.EventStatusEnum adStatus, object pRecordset)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(adReason, pError, adStatus, pRecordset);
			Invoker.Method(this, "MoveComplete", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary AC09 AC10 AC11 AC12 AC14 
		/// </summary>
		/// <param name="fMoreData">ref Int16 fMoreData</param>
		/// <param name="adStatus">NetOffice.ADODBApi.Enums.EventStatusEnum adStatus</param>
		/// <param name="pRecordset">object pRecordset</param>
		[SupportByLibrary("AC09","AC10","AC11","AC12","AC14")]
		public void EndOfRecordset(ref Int16 fMoreData, NetOffice.ADODBApi.Enums.EventStatusEnum adStatus, object pRecordset)
		{
			ParameterModifier[] modifiers = Invoker.CreateParamModifiers(true,false,false);
			object[] paramsArray = Invoker.ValidateParamsArray(fMoreData, adStatus, pRecordset);
			Invoker.Method(this, "EndOfRecordset", paramsArray, modifiers);
			fMoreData = (Int16)paramsArray[0];
		}

		/// <summary>
		/// SupportByLibrary AC09 AC10 AC11 AC12 AC14 
		/// </summary>
		/// <param name="Progress">Int32 Progress</param>
		/// <param name="MaxProgress">Int32 MaxProgress</param>
		/// <param name="adStatus">NetOffice.ADODBApi.Enums.EventStatusEnum adStatus</param>
		/// <param name="pRecordset">object pRecordset</param>
		[SupportByLibrary("AC09","AC10","AC11","AC12","AC14")]
		public void FetchProgress(Int32 progress, Int32 maxProgress, NetOffice.ADODBApi.Enums.EventStatusEnum adStatus, object pRecordset)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(progress, maxProgress, adStatus, pRecordset);
			Invoker.Method(this, "FetchProgress", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary AC09 AC10 AC11 AC12 AC14 
		/// </summary>
		/// <param name="pError">object pError</param>
		/// <param name="adStatus">NetOffice.ADODBApi.Enums.EventStatusEnum adStatus</param>
		/// <param name="pRecordset">object pRecordset</param>
		[SupportByLibrary("AC09","AC10","AC11","AC12","AC14")]
		public void FetchComplete(object pError, NetOffice.ADODBApi.Enums.EventStatusEnum adStatus, object pRecordset)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(pError, adStatus, pRecordset);
			Invoker.Method(this, "FetchComplete", paramsArray);
		}

		#endregion
		#pragma warning restore
	}
}