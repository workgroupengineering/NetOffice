//Generated by LateBindingApi.CodeGenerator
using System;
using NetRuntimeSystem = System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.ComponentModel;
using System.Reflection;
using LateBindingApi.Core;
namespace NetOffice.WordApi
{
	///<summary>
	/// DispatchInterface IApplicationEvents4 SupportByLibrary WD11 WD12 WD14 
	///</summary>
	[SupportByLibrary("WD11","WD12","WD14")]
	[EntityTypeAttribute(EntityType.IsDispatchInterface)]
	public class IApplicationEvents4 : COMObject
	{
		#pragma warning disable
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IApplicationEvents4(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IApplicationEvents4(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IApplicationEvents4(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IApplicationEvents4()
		{
		}
		
		#endregion
		
		#region Properties

		#endregion

		#region Methods

		/// <summary>
		/// SupportByLibrary WD11 WD12 WD14 
		/// </summary>
		[SupportByLibrary("WD11","WD12","WD14")]
		public void Startup()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "Startup", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary WD11 WD12 WD14 
		/// </summary>
		[SupportByLibrary("WD11","WD12","WD14")]
		public void Quit()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "Quit", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary WD11 WD12 WD14 
		/// </summary>
		[SupportByLibrary("WD11","WD12","WD14")]
		public void DocumentChange()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "DocumentChange", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary WD11 WD12 WD14 
		/// </summary>
		/// <param name="Doc">NetOffice.WordApi.Document Doc</param>
		[SupportByLibrary("WD11","WD12","WD14")]
		public void DocumentOpen(NetOffice.WordApi.Document doc)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(doc);
			Invoker.Method(this, "DocumentOpen", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary WD11 WD12 WD14 
		/// </summary>
		/// <param name="Doc">NetOffice.WordApi.Document Doc</param>
		/// <param name="Cancel">ref bool Cancel</param>
		[SupportByLibrary("WD11","WD12","WD14")]
		public void DocumentBeforeClose(NetOffice.WordApi.Document doc, ref bool cancel)
		{
			ParameterModifier[] modifiers = Invoker.CreateParamModifiers(false,true);
			object[] paramsArray = Invoker.ValidateParamsArray(doc, cancel);
			Invoker.Method(this, "DocumentBeforeClose", paramsArray, modifiers);
			cancel = (bool)paramsArray[1];
		}

		/// <summary>
		/// SupportByLibrary WD11 WD12 WD14 
		/// </summary>
		/// <param name="Doc">NetOffice.WordApi.Document Doc</param>
		/// <param name="Cancel">ref bool Cancel</param>
		[SupportByLibrary("WD11","WD12","WD14")]
		public void DocumentBeforePrint(NetOffice.WordApi.Document doc, ref bool cancel)
		{
			ParameterModifier[] modifiers = Invoker.CreateParamModifiers(false,true);
			object[] paramsArray = Invoker.ValidateParamsArray(doc, cancel);
			Invoker.Method(this, "DocumentBeforePrint", paramsArray, modifiers);
			cancel = (bool)paramsArray[1];
		}

		/// <summary>
		/// SupportByLibrary WD11 WD12 WD14 
		/// </summary>
		/// <param name="Doc">NetOffice.WordApi.Document Doc</param>
		/// <param name="SaveAsUI">ref bool SaveAsUI</param>
		/// <param name="Cancel">ref bool Cancel</param>
		[SupportByLibrary("WD11","WD12","WD14")]
		public void DocumentBeforeSave(NetOffice.WordApi.Document doc, ref bool saveAsUI, ref bool cancel)
		{
			ParameterModifier[] modifiers = Invoker.CreateParamModifiers(false,true,true);
			object[] paramsArray = Invoker.ValidateParamsArray(doc, saveAsUI, cancel);
			Invoker.Method(this, "DocumentBeforeSave", paramsArray, modifiers);
			saveAsUI = (bool)paramsArray[1];
			cancel = (bool)paramsArray[2];
		}

		/// <summary>
		/// SupportByLibrary WD11 WD12 WD14 
		/// </summary>
		/// <param name="Doc">NetOffice.WordApi.Document Doc</param>
		[SupportByLibrary("WD11","WD12","WD14")]
		public void NewDocument(NetOffice.WordApi.Document doc)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(doc);
			Invoker.Method(this, "NewDocument", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary WD11 WD12 WD14 
		/// </summary>
		/// <param name="Doc">NetOffice.WordApi.Document Doc</param>
		/// <param name="Wn">NetOffice.WordApi.Window Wn</param>
		[SupportByLibrary("WD11","WD12","WD14")]
		public void WindowActivate(NetOffice.WordApi.Document doc, NetOffice.WordApi.Window wn)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(doc, wn);
			Invoker.Method(this, "WindowActivate", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary WD11 WD12 WD14 
		/// </summary>
		/// <param name="Doc">NetOffice.WordApi.Document Doc</param>
		/// <param name="Wn">NetOffice.WordApi.Window Wn</param>
		[SupportByLibrary("WD11","WD12","WD14")]
		public void WindowDeactivate(NetOffice.WordApi.Document doc, NetOffice.WordApi.Window wn)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(doc, wn);
			Invoker.Method(this, "WindowDeactivate", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary WD11 WD12 WD14 
		/// </summary>
		/// <param name="Sel">NetOffice.WordApi.Selection Sel</param>
		[SupportByLibrary("WD11","WD12","WD14")]
		public void WindowSelectionChange(NetOffice.WordApi.Selection sel)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(sel);
			Invoker.Method(this, "WindowSelectionChange", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary WD11 WD12 WD14 
		/// </summary>
		/// <param name="Sel">NetOffice.WordApi.Selection Sel</param>
		/// <param name="Cancel">ref bool Cancel</param>
		[SupportByLibrary("WD11","WD12","WD14")]
		public void WindowBeforeRightClick(NetOffice.WordApi.Selection sel, ref bool cancel)
		{
			ParameterModifier[] modifiers = Invoker.CreateParamModifiers(false,true);
			object[] paramsArray = Invoker.ValidateParamsArray(sel, cancel);
			Invoker.Method(this, "WindowBeforeRightClick", paramsArray, modifiers);
			cancel = (bool)paramsArray[1];
		}

		/// <summary>
		/// SupportByLibrary WD11 WD12 WD14 
		/// </summary>
		/// <param name="Sel">NetOffice.WordApi.Selection Sel</param>
		/// <param name="Cancel">ref bool Cancel</param>
		[SupportByLibrary("WD11","WD12","WD14")]
		public void WindowBeforeDoubleClick(NetOffice.WordApi.Selection sel, ref bool cancel)
		{
			ParameterModifier[] modifiers = Invoker.CreateParamModifiers(false,true);
			object[] paramsArray = Invoker.ValidateParamsArray(sel, cancel);
			Invoker.Method(this, "WindowBeforeDoubleClick", paramsArray, modifiers);
			cancel = (bool)paramsArray[1];
		}

		/// <summary>
		/// SupportByLibrary WD11 WD12 WD14 
		/// </summary>
		/// <param name="Doc">NetOffice.WordApi.Document Doc</param>
		[SupportByLibrary("WD11","WD12","WD14")]
		public void EPostagePropertyDialog(NetOffice.WordApi.Document doc)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(doc);
			Invoker.Method(this, "EPostagePropertyDialog", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary WD11 WD12 WD14 
		/// </summary>
		/// <param name="Doc">NetOffice.WordApi.Document Doc</param>
		[SupportByLibrary("WD11","WD12","WD14")]
		public void EPostageInsert(NetOffice.WordApi.Document doc)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(doc);
			Invoker.Method(this, "EPostageInsert", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary WD11 WD12 WD14 
		/// </summary>
		/// <param name="Doc">NetOffice.WordApi.Document Doc</param>
		/// <param name="DocResult">NetOffice.WordApi.Document DocResult</param>
		[SupportByLibrary("WD11","WD12","WD14")]
		public void MailMergeAfterMerge(NetOffice.WordApi.Document doc, NetOffice.WordApi.Document docResult)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(doc, docResult);
			Invoker.Method(this, "MailMergeAfterMerge", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary WD11 WD12 WD14 
		/// </summary>
		/// <param name="Doc">NetOffice.WordApi.Document Doc</param>
		[SupportByLibrary("WD11","WD12","WD14")]
		public void MailMergeAfterRecordMerge(NetOffice.WordApi.Document doc)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(doc);
			Invoker.Method(this, "MailMergeAfterRecordMerge", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary WD11 WD12 WD14 
		/// </summary>
		/// <param name="Doc">NetOffice.WordApi.Document Doc</param>
		/// <param name="StartRecord">Int32 StartRecord</param>
		/// <param name="EndRecord">Int32 EndRecord</param>
		/// <param name="Cancel">ref bool Cancel</param>
		[SupportByLibrary("WD11","WD12","WD14")]
		public void MailMergeBeforeMerge(NetOffice.WordApi.Document doc, Int32 startRecord, Int32 endRecord, ref bool cancel)
		{
			ParameterModifier[] modifiers = Invoker.CreateParamModifiers(false,false,false,true);
			object[] paramsArray = Invoker.ValidateParamsArray(doc, startRecord, endRecord, cancel);
			Invoker.Method(this, "MailMergeBeforeMerge", paramsArray, modifiers);
			cancel = (bool)paramsArray[3];
		}

		/// <summary>
		/// SupportByLibrary WD11 WD12 WD14 
		/// </summary>
		/// <param name="Doc">NetOffice.WordApi.Document Doc</param>
		/// <param name="Cancel">ref bool Cancel</param>
		[SupportByLibrary("WD11","WD12","WD14")]
		public void MailMergeBeforeRecordMerge(NetOffice.WordApi.Document doc, ref bool cancel)
		{
			ParameterModifier[] modifiers = Invoker.CreateParamModifiers(false,true);
			object[] paramsArray = Invoker.ValidateParamsArray(doc, cancel);
			Invoker.Method(this, "MailMergeBeforeRecordMerge", paramsArray, modifiers);
			cancel = (bool)paramsArray[1];
		}

		/// <summary>
		/// SupportByLibrary WD11 WD12 WD14 
		/// </summary>
		/// <param name="Doc">NetOffice.WordApi.Document Doc</param>
		[SupportByLibrary("WD11","WD12","WD14")]
		public void MailMergeDataSourceLoad(NetOffice.WordApi.Document doc)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(doc);
			Invoker.Method(this, "MailMergeDataSourceLoad", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary WD11 WD12 WD14 
		/// </summary>
		/// <param name="Doc">NetOffice.WordApi.Document Doc</param>
		/// <param name="Handled">ref bool Handled</param>
		[SupportByLibrary("WD11","WD12","WD14")]
		public void MailMergeDataSourceValidate(NetOffice.WordApi.Document doc, ref bool handled)
		{
			ParameterModifier[] modifiers = Invoker.CreateParamModifiers(false,true);
			object[] paramsArray = Invoker.ValidateParamsArray(doc, handled);
			Invoker.Method(this, "MailMergeDataSourceValidate", paramsArray, modifiers);
			handled = (bool)paramsArray[1];
		}

		/// <summary>
		/// SupportByLibrary WD11 WD12 WD14 
		/// </summary>
		/// <param name="Doc">NetOffice.WordApi.Document Doc</param>
		[SupportByLibrary("WD11","WD12","WD14")]
		public void MailMergeWizardSendToCustom(NetOffice.WordApi.Document doc)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(doc);
			Invoker.Method(this, "MailMergeWizardSendToCustom", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary WD11 WD12 WD14 
		/// </summary>
		/// <param name="Doc">NetOffice.WordApi.Document Doc</param>
		/// <param name="FromState">ref Int32 FromState</param>
		/// <param name="ToState">ref Int32 ToState</param>
		/// <param name="Handled">ref bool Handled</param>
		[SupportByLibrary("WD11","WD12","WD14")]
		public void MailMergeWizardStateChange(NetOffice.WordApi.Document doc, ref Int32 fromState, ref Int32 toState, ref bool handled)
		{
			ParameterModifier[] modifiers = Invoker.CreateParamModifiers(false,true,true,true);
			object[] paramsArray = Invoker.ValidateParamsArray(doc, fromState, toState, handled);
			Invoker.Method(this, "MailMergeWizardStateChange", paramsArray, modifiers);
			fromState = (Int32)paramsArray[1];
			toState = (Int32)paramsArray[2];
			handled = (bool)paramsArray[3];
		}

		/// <summary>
		/// SupportByLibrary WD11 WD12 WD14 
		/// </summary>
		/// <param name="Doc">NetOffice.WordApi.Document Doc</param>
		/// <param name="Wn">NetOffice.WordApi.Window Wn</param>
		[SupportByLibrary("WD11","WD12","WD14")]
		public void WindowSize(NetOffice.WordApi.Document doc, NetOffice.WordApi.Window wn)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(doc, wn);
			Invoker.Method(this, "WindowSize", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary WD11 WD12 WD14 
		/// </summary>
		/// <param name="Sel">NetOffice.WordApi.Selection Sel</param>
		/// <param name="OldXMLNode">NetOffice.WordApi.XMLNode OldXMLNode</param>
		/// <param name="NewXMLNode">NetOffice.WordApi.XMLNode NewXMLNode</param>
		/// <param name="Reason">ref Int32 Reason</param>
		[SupportByLibrary("WD11","WD12","WD14")]
		public void XMLSelectionChange(NetOffice.WordApi.Selection sel, NetOffice.WordApi.XMLNode oldXMLNode, NetOffice.WordApi.XMLNode newXMLNode, ref Int32 reason)
		{
			ParameterModifier[] modifiers = Invoker.CreateParamModifiers(false,false,false,true);
			object[] paramsArray = Invoker.ValidateParamsArray(sel, oldXMLNode, newXMLNode, reason);
			Invoker.Method(this, "XMLSelectionChange", paramsArray, modifiers);
			reason = (Int32)paramsArray[3];
		}

		/// <summary>
		/// SupportByLibrary WD11 WD12 WD14 
		/// </summary>
		/// <param name="XMLNode">NetOffice.WordApi.XMLNode XMLNode</param>
		[SupportByLibrary("WD11","WD12","WD14")]
		public void XMLValidationError(NetOffice.WordApi.XMLNode xMLNode)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(xMLNode);
			Invoker.Method(this, "XMLValidationError", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary WD11 WD12 WD14 
		/// </summary>
		/// <param name="Doc">NetOffice.WordApi.Document Doc</param>
		/// <param name="SyncEventType">NetOffice.OfficeApi.Enums.MsoSyncEventType SyncEventType</param>
		[SupportByLibrary("WD11","WD12","WD14")]
		public void DocumentSync(NetOffice.WordApi.Document doc, NetOffice.OfficeApi.Enums.MsoSyncEventType syncEventType)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(doc, syncEventType);
			Invoker.Method(this, "DocumentSync", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary WD11 WD12 WD14 
		/// </summary>
		/// <param name="Doc">NetOffice.WordApi.Document Doc</param>
		/// <param name="cpDeliveryAddrStart">Int32 cpDeliveryAddrStart</param>
		/// <param name="cpDeliveryAddrEnd">Int32 cpDeliveryAddrEnd</param>
		/// <param name="cpReturnAddrStart">Int32 cpReturnAddrStart</param>
		/// <param name="cpReturnAddrEnd">Int32 cpReturnAddrEnd</param>
		/// <param name="xaWidth">Int32 xaWidth</param>
		/// <param name="yaHeight">Int32 yaHeight</param>
		/// <param name="bstrPrinterName">string bstrPrinterName</param>
		/// <param name="bstrPaperFeed">string bstrPaperFeed</param>
		/// <param name="fPrint">bool fPrint</param>
		/// <param name="fCancel">ref bool fCancel</param>
		[SupportByLibrary("WD11","WD12","WD14")]
		public void EPostageInsertEx(NetOffice.WordApi.Document doc, Int32 cpDeliveryAddrStart, Int32 cpDeliveryAddrEnd, Int32 cpReturnAddrStart, Int32 cpReturnAddrEnd, Int32 xaWidth, Int32 yaHeight, string bstrPrinterName, string bstrPaperFeed, bool fPrint, ref bool fCancel)
		{
			ParameterModifier[] modifiers = Invoker.CreateParamModifiers(false,false,false,false,false,false,false,false,false,false,true);
			object[] paramsArray = Invoker.ValidateParamsArray(doc, cpDeliveryAddrStart, cpDeliveryAddrEnd, cpReturnAddrStart, cpReturnAddrEnd, xaWidth, yaHeight, bstrPrinterName, bstrPaperFeed, fPrint, fCancel);
			Invoker.Method(this, "EPostageInsertEx", paramsArray, modifiers);
			fCancel = (bool)paramsArray[10];
		}

		/// <summary>
		/// SupportByLibrary WD12 WD14 
		/// </summary>
		/// <param name="Doc">NetOffice.WordApi.Document Doc</param>
		/// <param name="Handled">ref bool Handled</param>
		[SupportByLibrary("WD12","WD14")]
		public Int32 MailMergeDataSourceValidate2(NetOffice.WordApi.Document doc, ref bool handled)
		{
			ParameterModifier[] modifiers = Invoker.CreateParamModifiers(false,true);
			object[] paramsArray = Invoker.ValidateParamsArray(doc, handled);
			object returnItem = Invoker.MethodReturn(this, "MailMergeDataSourceValidate2", paramsArray);
			handled = (bool)paramsArray[1];
			return (Int32)returnItem;
		}

		/// <summary>
		/// SupportByLibrary WD14 
		/// </summary>
		/// <param name="PvWindow">NetOffice.WordApi.ProtectedViewWindow PvWindow</param>
		[SupportByLibrary("WD14")]
		public Int32 ProtectedViewWindowOpen(NetOffice.WordApi.ProtectedViewWindow pvWindow)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(pvWindow);
			object returnItem = Invoker.MethodReturn(this, "ProtectedViewWindowOpen", paramsArray);
			return (Int32)returnItem;
		}

		/// <summary>
		/// SupportByLibrary WD14 
		/// </summary>
		/// <param name="PvWindow">NetOffice.WordApi.ProtectedViewWindow PvWindow</param>
		/// <param name="Cancel">ref bool Cancel</param>
		[SupportByLibrary("WD14")]
		public Int32 ProtectedViewWindowBeforeEdit(NetOffice.WordApi.ProtectedViewWindow pvWindow, ref bool cancel)
		{
			ParameterModifier[] modifiers = Invoker.CreateParamModifiers(false,true);
			object[] paramsArray = Invoker.ValidateParamsArray(pvWindow, cancel);
			object returnItem = Invoker.MethodReturn(this, "ProtectedViewWindowBeforeEdit", paramsArray);
			cancel = (bool)paramsArray[1];
			return (Int32)returnItem;
		}

		/// <summary>
		/// SupportByLibrary WD14 
		/// </summary>
		/// <param name="PvWindow">NetOffice.WordApi.ProtectedViewWindow PvWindow</param>
		/// <param name="CloseReason">Int32 CloseReason</param>
		/// <param name="Cancel">ref bool Cancel</param>
		[SupportByLibrary("WD14")]
		public Int32 ProtectedViewWindowBeforeClose(NetOffice.WordApi.ProtectedViewWindow pvWindow, Int32 closeReason, ref bool cancel)
		{
			ParameterModifier[] modifiers = Invoker.CreateParamModifiers(false,false,true);
			object[] paramsArray = Invoker.ValidateParamsArray(pvWindow, closeReason, cancel);
			object returnItem = Invoker.MethodReturn(this, "ProtectedViewWindowBeforeClose", paramsArray);
			cancel = (bool)paramsArray[2];
			return (Int32)returnItem;
		}

		/// <summary>
		/// SupportByLibrary WD14 
		/// </summary>
		/// <param name="PvWindow">NetOffice.WordApi.ProtectedViewWindow PvWindow</param>
		[SupportByLibrary("WD14")]
		public Int32 ProtectedViewWindowSize(NetOffice.WordApi.ProtectedViewWindow pvWindow)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(pvWindow);
			object returnItem = Invoker.MethodReturn(this, "ProtectedViewWindowSize", paramsArray);
			return (Int32)returnItem;
		}

		/// <summary>
		/// SupportByLibrary WD14 
		/// </summary>
		/// <param name="PvWindow">NetOffice.WordApi.ProtectedViewWindow PvWindow</param>
		[SupportByLibrary("WD14")]
		public Int32 ProtectedViewWindowActivate(NetOffice.WordApi.ProtectedViewWindow pvWindow)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(pvWindow);
			object returnItem = Invoker.MethodReturn(this, "ProtectedViewWindowActivate", paramsArray);
			return (Int32)returnItem;
		}

		/// <summary>
		/// SupportByLibrary WD14 
		/// </summary>
		/// <param name="PvWindow">NetOffice.WordApi.ProtectedViewWindow PvWindow</param>
		[SupportByLibrary("WD14")]
		public Int32 ProtectedViewWindowDeactivate(NetOffice.WordApi.ProtectedViewWindow pvWindow)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(pvWindow);
			object returnItem = Invoker.MethodReturn(this, "ProtectedViewWindowDeactivate", paramsArray);
			return (Int32)returnItem;
		}

		#endregion
		#pragma warning restore
	}
}