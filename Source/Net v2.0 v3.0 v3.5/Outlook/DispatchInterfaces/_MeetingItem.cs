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
	/// DispatchInterface _MeetingItem SupportByLibrary OL09 OL10 OL11 OL12 OL14 
	///</summary>
	[SupportByLibrary("OL09","OL10","OL11","OL12","OL14")]
	[EntityTypeAttribute(EntityType.IsDispatchInterface)]
	public class _MeetingItem : COMObject
	{
		#pragma warning disable
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public _MeetingItem(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public _MeetingItem(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public _MeetingItem(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public _MeetingItem()
		{
		}
		
		#endregion
		
		#region Properties

		/// <summary>
		/// SupportByLibrary OL09 OL10 OL11 OL12 OL14 
		/// </summary>
		[SupportByLibrary("OL09","OL10","OL11","OL12","OL14")]
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
		/// SupportByLibrary OL09 OL10 OL11 OL12 OL14 
		/// </summary>
		[SupportByLibrary("OL09","OL10","OL11","OL12","OL14")]
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
		/// SupportByLibrary OL09 OL10 OL11 OL12 OL14 
		/// </summary>
		[SupportByLibrary("OL09","OL10","OL11","OL12","OL14")]
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
		/// SupportByLibrary OL09 OL10 OL11 OL12 OL14 
		/// </summary>
		[SupportByLibrary("OL09","OL10","OL11","OL12","OL14")]
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
		/// SupportByLibrary OL09 OL10 OL11 OL12 OL14 
		/// </summary>
		[SupportByLibrary("OL09","OL10","OL11","OL12","OL14")]
		public NetOffice.OutlookApi.Actions Actions
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Actions", paramsArray);
				NetOffice.OutlookApi.Actions newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.OutlookApi.Actions;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary OL09 OL10 OL11 OL12 OL14 
		/// </summary>
		[SupportByLibrary("OL09","OL10","OL11","OL12","OL14")]
		public NetOffice.OutlookApi.Attachments Attachments
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Attachments", paramsArray);
				NetOffice.OutlookApi.Attachments newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.OutlookApi.Attachments;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary OL09 OL10 OL11 OL12 OL14 
		/// </summary>
		[SupportByLibrary("OL09","OL10","OL11","OL12","OL14")]
		public string BillingInformation
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "BillingInformation", paramsArray);
				return (string)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "BillingInformation", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary OL09 OL10 OL11 OL12 OL14 
		/// </summary>
		[SupportByLibrary("OL09","OL10","OL11","OL12","OL14")]
		public string Body
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Body", paramsArray);
				return (string)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Body", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary OL09 OL10 OL11 OL12 OL14 
		/// </summary>
		[SupportByLibrary("OL09","OL10","OL11","OL12","OL14")]
		public string Categories
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Categories", paramsArray);
				return (string)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Categories", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary OL09 OL10 OL11 OL12 OL14 
		/// </summary>
		[SupportByLibrary("OL09","OL10","OL11","OL12","OL14")]
		public string Companies
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Companies", paramsArray);
				return (string)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Companies", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary OL09 OL10 OL11 OL12 OL14 
		/// </summary>
		[SupportByLibrary("OL09","OL10","OL11","OL12","OL14")]
		public string ConversationIndex
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ConversationIndex", paramsArray);
				return (string)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary OL09 OL10 OL11 OL12 OL14 
		/// </summary>
		[SupportByLibrary("OL09","OL10","OL11","OL12","OL14")]
		public string ConversationTopic
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ConversationTopic", paramsArray);
				return (string)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary OL09 OL10 OL11 OL12 OL14 
		/// </summary>
		[SupportByLibrary("OL09","OL10","OL11","OL12","OL14")]
		public DateTime CreationTime
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "CreationTime", paramsArray);
				return (DateTime)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary OL09 OL10 OL11 OL12 OL14 
		/// </summary>
		[SupportByLibrary("OL09","OL10","OL11","OL12","OL14")]
		public string EntryID
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "EntryID", paramsArray);
				return (string)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary OL09 OL10 OL11 OL12 OL14 
		/// </summary>
		[SupportByLibrary("OL09","OL10","OL11","OL12","OL14")]
		public NetOffice.OutlookApi.FormDescription FormDescription
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "FormDescription", paramsArray);
				NetOffice.OutlookApi.FormDescription newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.OutlookApi.FormDescription;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary OL09 OL10 OL11 OL12 OL14 
		/// </summary>
		[SupportByLibrary("OL09","OL10","OL11","OL12","OL14")]
		public NetOffice.OutlookApi._Inspector GetInspector
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "GetInspector", paramsArray);
				NetOffice.OutlookApi._Inspector newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.OutlookApi._Inspector;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary OL09 OL10 OL11 OL12 OL14 
		/// </summary>
		[SupportByLibrary("OL09","OL10","OL11","OL12","OL14")]
		public NetOffice.OutlookApi.Enums.OlImportance Importance
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Importance", paramsArray);
				return (NetOffice.OutlookApi.Enums.OlImportance)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Importance", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary OL09 OL10 OL11 OL12 OL14 
		/// </summary>
		[SupportByLibrary("OL09","OL10","OL11","OL12","OL14")]
		public DateTime LastModificationTime
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "LastModificationTime", paramsArray);
				return (DateTime)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary OL09 OL10 OL11 OL12 OL14 
		/// </summary>
		[SupportByLibrary("OL09","OL10","OL11","OL12","OL14")]
		public COMObject MAPIOBJECT
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "MAPIOBJECT", paramsArray);
				COMObject newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem);
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary OL09 OL10 OL11 OL12 OL14 
		/// </summary>
		[SupportByLibrary("OL09","OL10","OL11","OL12","OL14")]
		public string MessageClass
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "MessageClass", paramsArray);
				return (string)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "MessageClass", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary OL09 OL10 OL11 OL12 OL14 
		/// </summary>
		[SupportByLibrary("OL09","OL10","OL11","OL12","OL14")]
		public string Mileage
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Mileage", paramsArray);
				return (string)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Mileage", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary OL09 OL10 OL11 OL12 OL14 
		/// </summary>
		[SupportByLibrary("OL09","OL10","OL11","OL12","OL14")]
		public bool NoAging
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "NoAging", paramsArray);
				return (bool)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "NoAging", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary OL09 OL10 OL11 OL12 OL14 
		/// </summary>
		[SupportByLibrary("OL09","OL10","OL11","OL12","OL14")]
		public Int32 OutlookInternalVersion
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "OutlookInternalVersion", paramsArray);
				return (Int32)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary OL09 OL10 OL11 OL12 OL14 
		/// </summary>
		[SupportByLibrary("OL09","OL10","OL11","OL12","OL14")]
		public string OutlookVersion
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "OutlookVersion", paramsArray);
				return (string)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary OL09 OL10 OL11 OL12 OL14 
		/// </summary>
		[SupportByLibrary("OL09","OL10","OL11","OL12","OL14")]
		public bool Saved
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Saved", paramsArray);
				return (bool)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary OL09 OL10 OL11 OL12 OL14 
		/// </summary>
		[SupportByLibrary("OL09","OL10","OL11","OL12","OL14")]
		public NetOffice.OutlookApi.Enums.OlSensitivity Sensitivity
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Sensitivity", paramsArray);
				return (NetOffice.OutlookApi.Enums.OlSensitivity)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Sensitivity", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary OL09 OL10 OL11 OL12 OL14 
		/// </summary>
		[SupportByLibrary("OL09","OL10","OL11","OL12","OL14")]
		public Int32 Size
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Size", paramsArray);
				return (Int32)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary OL09 OL10 OL11 OL12 OL14 
		/// </summary>
		[SupportByLibrary("OL09","OL10","OL11","OL12","OL14")]
		public string Subject
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Subject", paramsArray);
				return (string)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Subject", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary OL09 OL10 OL11 OL12 OL14 
		/// </summary>
		[SupportByLibrary("OL09","OL10","OL11","OL12","OL14")]
		public bool UnRead
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "UnRead", paramsArray);
				return (bool)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "UnRead", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary OL09 OL10 OL11 OL12 OL14 
		/// </summary>
		[SupportByLibrary("OL09","OL10","OL11","OL12","OL14")]
		public NetOffice.OutlookApi.UserProperties UserProperties
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "UserProperties", paramsArray);
				NetOffice.OutlookApi.UserProperties newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.OutlookApi.UserProperties;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary OL09 OL10 OL11 OL12 OL14 
		/// </summary>
		[SupportByLibrary("OL09","OL10","OL11","OL12","OL14")]
		public bool AutoForwarded
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "AutoForwarded", paramsArray);
				return (bool)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "AutoForwarded", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary OL09 OL10 OL11 OL12 OL14 
		/// </summary>
		[SupportByLibrary("OL09","OL10","OL11","OL12","OL14")]
		public DateTime DeferredDeliveryTime
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "DeferredDeliveryTime", paramsArray);
				return (DateTime)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "DeferredDeliveryTime", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary OL09 OL10 OL11 OL12 OL14 
		/// </summary>
		[SupportByLibrary("OL09","OL10","OL11","OL12","OL14")]
		public bool DeleteAfterSubmit
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "DeleteAfterSubmit", paramsArray);
				return (bool)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "DeleteAfterSubmit", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary OL09 OL10 OL11 OL12 OL14 
		/// </summary>
		[SupportByLibrary("OL09","OL10","OL11","OL12","OL14")]
		public DateTime ExpiryTime
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ExpiryTime", paramsArray);
				return (DateTime)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "ExpiryTime", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary OL09 OL10 OL11 OL12 OL14 
		/// </summary>
		[SupportByLibrary("OL09","OL10","OL11","OL12","OL14")]
		public DateTime FlagDueBy
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "FlagDueBy", paramsArray);
				return (DateTime)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "FlagDueBy", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary OL09 OL10 OL11 OL12 OL14 
		/// </summary>
		[SupportByLibrary("OL09","OL10","OL11","OL12","OL14")]
		public string FlagRequest
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "FlagRequest", paramsArray);
				return (string)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "FlagRequest", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary OL09 OL10 OL11 OL12 OL14 
		/// </summary>
		[SupportByLibrary("OL09","OL10","OL11","OL12","OL14")]
		public NetOffice.OutlookApi.Enums.OlFlagStatus FlagStatus
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "FlagStatus", paramsArray);
				return (NetOffice.OutlookApi.Enums.OlFlagStatus)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "FlagStatus", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary OL09 OL10 OL11 OL12 OL14 
		/// </summary>
		[SupportByLibrary("OL09","OL10","OL11","OL12","OL14")]
		public bool OriginatorDeliveryReportRequested
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "OriginatorDeliveryReportRequested", paramsArray);
				return (bool)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "OriginatorDeliveryReportRequested", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary OL09 OL10 OL11 OL12 OL14 
		/// </summary>
		[SupportByLibrary("OL09","OL10","OL11","OL12","OL14")]
		public DateTime ReceivedTime
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ReceivedTime", paramsArray);
				return (DateTime)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "ReceivedTime", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary OL09 OL10 OL11 OL12 OL14 
		/// </summary>
		[SupportByLibrary("OL09","OL10","OL11","OL12","OL14")]
		public NetOffice.OutlookApi.Recipients Recipients
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Recipients", paramsArray);
				NetOffice.OutlookApi.Recipients newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.OutlookApi.Recipients;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary OL09 OL10 OL11 OL12 OL14 
		/// </summary>
		[SupportByLibrary("OL09","OL10","OL11","OL12","OL14")]
		public bool ReminderSet
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ReminderSet", paramsArray);
				return (bool)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "ReminderSet", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary OL09 OL10 OL11 OL12 OL14 
		/// </summary>
		[SupportByLibrary("OL09","OL10","OL11","OL12","OL14")]
		public DateTime ReminderTime
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ReminderTime", paramsArray);
				return (DateTime)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "ReminderTime", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary OL09 OL10 OL11 OL12 OL14 
		/// </summary>
		[SupportByLibrary("OL09","OL10","OL11","OL12","OL14")]
		public NetOffice.OutlookApi.Recipients ReplyRecipients
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ReplyRecipients", paramsArray);
				NetOffice.OutlookApi.Recipients newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.OutlookApi.Recipients;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary OL09 OL10 OL11 OL12 OL14 
		/// </summary>
		[SupportByLibrary("OL09","OL10","OL11","OL12","OL14")]
		public NetOffice.OutlookApi.MAPIFolder SaveSentMessageFolder
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "SaveSentMessageFolder", paramsArray);
				NetOffice.OutlookApi.MAPIFolder newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.OutlookApi.MAPIFolder;
				return newObject;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "SaveSentMessageFolder", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary OL09 OL10 OL11 OL12 OL14 
		/// </summary>
		[SupportByLibrary("OL09","OL10","OL11","OL12","OL14")]
		public string SenderName
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "SenderName", paramsArray);
				return (string)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary OL09 OL10 OL11 OL12 OL14 
		/// </summary>
		[SupportByLibrary("OL09","OL10","OL11","OL12","OL14")]
		public bool Sent
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Sent", paramsArray);
				return (bool)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary OL09 OL10 OL11 OL12 OL14 
		/// </summary>
		[SupportByLibrary("OL09","OL10","OL11","OL12","OL14")]
		public DateTime SentOn
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "SentOn", paramsArray);
				return (DateTime)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary OL09 OL10 OL11 OL12 OL14 
		/// </summary>
		[SupportByLibrary("OL09","OL10","OL11","OL12","OL14")]
		public bool Submitted
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Submitted", paramsArray);
				return (bool)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary OL09 OL10 OL11 OL12 OL14 
		/// </summary>
		[SupportByLibrary("OL09","OL10","OL11","OL12","OL14")]
		public NetOffice.OutlookApi.Links Links
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Links", paramsArray);
				NetOffice.OutlookApi.Links newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.OutlookApi.Links;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary OL10 OL11 OL12 OL14 
		/// </summary>
		[SupportByLibrary("OL10","OL11","OL12","OL14")]
		public NetOffice.OutlookApi.Enums.OlDownloadState DownloadState
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "DownloadState", paramsArray);
				return (NetOffice.OutlookApi.Enums.OlDownloadState)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary OL10 OL11 OL12 OL14 
		/// </summary>
		[SupportByLibrary("OL10","OL11","OL12","OL14")]
		public NetOffice.OutlookApi.ItemProperties ItemProperties
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ItemProperties", paramsArray);
				NetOffice.OutlookApi.ItemProperties newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.OutlookApi.ItemProperties;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary OL10 OL11 OL12 OL14 
		/// </summary>
		[SupportByLibrary("OL10","OL11","OL12","OL14")]
		public NetOffice.OutlookApi.Enums.OlRemoteStatus MarkForDownload
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "MarkForDownload", paramsArray);
				return (NetOffice.OutlookApi.Enums.OlRemoteStatus)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "MarkForDownload", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary OL10 OL11 OL12 OL14 
		/// </summary>
		[SupportByLibrary("OL10","OL11","OL12","OL14")]
		public bool IsConflict
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "IsConflict", paramsArray);
				return (bool)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary OL11 OL12 OL14 
		/// </summary>
		[SupportByLibrary("OL11","OL12","OL14")]
		public string MeetingWorkspaceURL
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "MeetingWorkspaceURL", paramsArray);
				return (string)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary OL11 OL12 OL14 
		/// </summary>
		[SupportByLibrary("OL11","OL12","OL14")]
		public NetOffice.OutlookApi.Enums.OlFlagIcon FlagIcon
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "FlagIcon", paramsArray);
				return (NetOffice.OutlookApi.Enums.OlFlagIcon)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "FlagIcon", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary OL11 OL12 OL14 
		/// </summary>
		[SupportByLibrary("OL11","OL12","OL14")]
		public bool AutoResolvedWinner
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "AutoResolvedWinner", paramsArray);
				return (bool)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary OL11 OL12 OL14 
		/// </summary>
		[SupportByLibrary("OL11","OL12","OL14")]
		public NetOffice.OutlookApi.Conflicts Conflicts
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Conflicts", paramsArray);
				NetOffice.OutlookApi.Conflicts newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.OutlookApi.Conflicts;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary OL11 OL12 OL14 
		/// </summary>
		[SupportByLibrary("OL11","OL12","OL14")]
		public string SenderEmailAddress
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "SenderEmailAddress", paramsArray);
				return (string)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary OL11 OL12 OL14 
		/// </summary>
		[SupportByLibrary("OL11","OL12","OL14")]
		public string SenderEmailType
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "SenderEmailType", paramsArray);
				return (string)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary OL12 OL14 
		/// </summary>
		[SupportByLibrary("OL12","OL14")]
		public NetOffice.OutlookApi.PropertyAccessor PropertyAccessor
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "PropertyAccessor", paramsArray);
				NetOffice.OutlookApi.PropertyAccessor newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.OutlookApi.PropertyAccessor;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary OL14 
		/// </summary>
		[SupportByLibrary("OL14")]
		public string ConversationID
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ConversationID", paramsArray);
				return (string)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary OL14 
		/// </summary>
		[SupportByLibrary("OL14")]
		public NetOffice.OutlookApi.Account SendUsingAccount
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "SendUsingAccount", paramsArray);
				NetOffice.OutlookApi.Account newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.OutlookApi.Account;
				return newObject;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "SendUsingAccount", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary OL14 
		/// </summary>
		[SupportByLibrary("OL14")]
		public bool IsLatestVersion
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "IsLatestVersion", paramsArray);
				return (bool)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary OL14 
		/// </summary>
		[SupportByLibrary("OL14")]
		public object RTFBody
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "RTFBody", paramsArray);
				Type returnItemType = returnItem.GetType();
				if(true == returnItemType.IsCOMObject)
				{
					COMObject newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem, returnItemType);
					return newObject;
				}
				else
				{
					return  returnItem;
				}
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "RTFBody", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary OL14 
		/// </summary>
		[SupportByLibrary("OL14")]
		public DateTime RetentionExpirationDate
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "RetentionExpirationDate", paramsArray);
				return (DateTime)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary OL14 
		/// </summary>
		[SupportByLibrary("OL14")]
		public string RetentionPolicyName
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "RetentionPolicyName", paramsArray);
				return (string)returnItem;
			}
		}

		#endregion

		#region Methods

		/// <summary>
		/// SupportByLibrary OL09 OL10 OL11 OL12 OL14 
		/// </summary>
		/// <param name="SaveMode">NetOffice.OutlookApi.Enums.OlInspectorClose SaveMode</param>
		[SupportByLibrary("OL09","OL10","OL11","OL12","OL14")]
		public void Close(NetOffice.OutlookApi.Enums.OlInspectorClose saveMode)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(saveMode);
			Invoker.Method(this, "Close", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary OL09 OL10 OL11 OL12 OL14 
		/// </summary>
		[SupportByLibrary("OL09","OL10","OL11","OL12","OL14")]
		public COMObject Copy()
		{
			object[] paramsArray = null;
			object returnItem = Invoker.MethodReturn(this, "Copy", paramsArray);
			COMObject newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem);
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary OL09 OL10 OL11 OL12 OL14 
		/// </summary>
		[SupportByLibrary("OL09","OL10","OL11","OL12","OL14")]
		public void Delete()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "Delete", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary OL09 OL10 OL11 OL12 OL14 
		/// </summary>
		/// <param name="Modal">optional object Modal</param>
		[SupportByLibrary("OL09","OL10","OL11","OL12","OL14")]
		public void Display(object modal)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(modal);
			Invoker.Method(this, "Display", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary OL09 OL10 OL11 OL12 OL14 
		/// </summary>
		[SupportByLibrary("OL09","OL10","OL11","OL12","OL14")]
		public void Display()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "Display", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary OL09 OL10 OL11 OL12 OL14 
		/// </summary>
		/// <param name="DestFldr">NetOffice.OutlookApi.MAPIFolder DestFldr</param>
		[SupportByLibrary("OL09","OL10","OL11","OL12","OL14")]
		public COMObject Move(NetOffice.OutlookApi.MAPIFolder destFldr)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(destFldr);
			object returnItem = Invoker.MethodReturn(this, "Move", paramsArray);
			COMObject newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem);
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary OL09 OL10 OL11 OL12 OL14 
		/// </summary>
		[SupportByLibrary("OL09","OL10","OL11","OL12","OL14")]
		public void PrintOut()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "PrintOut", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary OL09 OL10 OL11 OL12 OL14 
		/// </summary>
		[SupportByLibrary("OL09","OL10","OL11","OL12","OL14")]
		public void Save()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "Save", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary OL09 OL10 OL11 OL12 OL14 
		/// </summary>
		/// <param name="Path">string Path</param>
		/// <param name="Type">optional object Type</param>
		[SupportByLibrary("OL09","OL10","OL11","OL12","OL14")]
		public void SaveAs(string path, object type)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(path, type);
			Invoker.Method(this, "SaveAs", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary OL09 OL10 OL11 OL12 OL14 
		/// </summary>
		/// <param name="Path">string Path</param>
		[SupportByLibrary("OL09","OL10","OL11","OL12","OL14")]
		public void SaveAs(string path)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(path);
			Invoker.Method(this, "SaveAs", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary OL09 OL10 OL11 OL12 OL14 
		/// </summary>
		[SupportByLibrary("OL09","OL10","OL11","OL12","OL14")]
		public NetOffice.OutlookApi.MeetingItem Forward()
		{
			object[] paramsArray = null;
			object returnItem = Invoker.MethodReturn(this, "Forward", paramsArray);
			NetOffice.OutlookApi.MeetingItem newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem) as NetOffice.OutlookApi.MeetingItem;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary OL09 OL10 OL11 OL12 OL14 
		/// </summary>
		/// <param name="AddToCalendar">bool AddToCalendar</param>
		[SupportByLibrary("OL09","OL10","OL11","OL12","OL14")]
		public NetOffice.OutlookApi.AppointmentItem GetAssociatedAppointment(bool addToCalendar)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(addToCalendar);
			object returnItem = Invoker.MethodReturn(this, "GetAssociatedAppointment", paramsArray);
			NetOffice.OutlookApi.AppointmentItem newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem) as NetOffice.OutlookApi.AppointmentItem;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary OL09 OL10 OL11 OL12 OL14 
		/// </summary>
		[SupportByLibrary("OL09","OL10","OL11","OL12","OL14")]
		public NetOffice.OutlookApi.MailItem Reply()
		{
			object[] paramsArray = null;
			object returnItem = Invoker.MethodReturn(this, "Reply", paramsArray);
			NetOffice.OutlookApi.MailItem newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem) as NetOffice.OutlookApi.MailItem;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary OL09 OL10 OL11 OL12 OL14 
		/// </summary>
		[SupportByLibrary("OL09","OL10","OL11","OL12","OL14")]
		public NetOffice.OutlookApi.MailItem ReplyAll()
		{
			object[] paramsArray = null;
			object returnItem = Invoker.MethodReturn(this, "ReplyAll", paramsArray);
			NetOffice.OutlookApi.MailItem newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem) as NetOffice.OutlookApi.MailItem;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary OL09 OL10 OL11 OL12 OL14 
		/// </summary>
		[SupportByLibrary("OL09","OL10","OL11","OL12","OL14")]
		public void Send()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "Send", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary OL10 OL11 OL12 OL14 
		/// </summary>
		[SupportByLibrary("OL10","OL11","OL12","OL14")]
		public void ShowCategoriesDialog()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "ShowCategoriesDialog", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary OL14 
		/// </summary>
		[SupportByLibrary("OL14")]
		public NetOffice.OutlookApi._Conversation GetConversation()
		{
			object[] paramsArray = null;
			object returnItem = Invoker.MethodReturn(this, "GetConversation", paramsArray);
			NetOffice.OutlookApi._Conversation newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem) as NetOffice.OutlookApi._Conversation;
			return newObject;
		}

		#endregion
		#pragma warning restore
	}
}