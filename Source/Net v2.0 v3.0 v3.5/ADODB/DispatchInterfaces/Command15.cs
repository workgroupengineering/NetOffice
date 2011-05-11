//Generated by LateBindingApi.CodeGenerator
using System;
using NetRuntimeSystem = System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.ComponentModel;
using System.Reflection;
using LateBindingApi.Core;
namespace NetOffice.ADODBApi
{
	///<summary>
	/// DispatchInterface Command15 SupportByLibrary ADO2.1 ADO2.5 
	///</summary>
	[SupportByLibrary("ADO2.1","ADO2.5")]
	[EntityTypeAttribute(EntityType.IsDispatchInterface)]
	public class Command15 : _ADO
	{
		#pragma warning disable
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Command15(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Command15(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Command15(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Command15()
		{
		}
		
		#endregion
		
		#region Properties

		/// <summary>
		/// SupportByLibrary ADO2.1 ADO2.5 
		/// </summary>
		[SupportByLibrary("ADO2.1","ADO2.5")]
		public NetOffice.ADODBApi._Connection ActiveConnection
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ActiveConnection", paramsArray);
				NetOffice.ADODBApi._Connection newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.ADODBApi._Connection;
				return newObject;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "ActiveConnection", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary ADO2.1 ADO2.5 
		/// </summary>
		[SupportByLibrary("ADO2.1","ADO2.5")]
		public string CommandText
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "CommandText", paramsArray);
				return (string)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "CommandText", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary ADO2.1 ADO2.5 
		/// </summary>
		[SupportByLibrary("ADO2.1","ADO2.5")]
		public Int32 CommandTimeout
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "CommandTimeout", paramsArray);
				return (Int32)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "CommandTimeout", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary ADO2.1 ADO2.5 
		/// </summary>
		[SupportByLibrary("ADO2.1","ADO2.5")]
		public bool Prepared
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Prepared", paramsArray);
				return (bool)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Prepared", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary ADO2.1 ADO2.5 
		/// </summary>
		[SupportByLibrary("ADO2.1","ADO2.5")]
		public NetOffice.ADODBApi.Parameters Parameters
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Parameters", paramsArray);
				NetOffice.ADODBApi.Parameters newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.ADODBApi.Parameters;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary ADO2.1 ADO2.5 
		/// </summary>
		[SupportByLibrary("ADO2.1","ADO2.5")]
		public NetOffice.ADODBApi.Enums.CommandTypeEnum CommandType
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "CommandType", paramsArray);
				return (NetOffice.ADODBApi.Enums.CommandTypeEnum)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "CommandType", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary ADO2.1 ADO2.5 
		/// </summary>
		[SupportByLibrary("ADO2.1","ADO2.5")]
		public string Name
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Name", paramsArray);
				return (string)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Name", paramsArray);
			}
		}

		#endregion

		#region Methods

		/// <summary>
		/// SupportByLibrary ADO2.1 ADO2.5 
		/// </summary>
		/// <param name="RecordsAffected">ref object RecordsAffected</param>
		/// <param name="Parameters">ref object Parameters</param>
		/// <param name="Options">Int32 Options</param>
		[SupportByLibrary("ADO2.1","ADO2.5")]
		public NetOffice.ADODBApi._Recordset Execute(ref object recordsAffected, ref object parameters, Int32 options)
		{
			ParameterModifier[] modifiers = Invoker.CreateParamModifiers(true,true,false);
			object[] paramsArray = Invoker.ValidateParamsArray(recordsAffected, parameters, options);
			object returnItem = Invoker.MethodReturn(this, "Execute", paramsArray, modifiers);
			NetOffice.ADODBApi._Recordset newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem) as NetOffice.ADODBApi._Recordset;
			recordsAffected = (object)paramsArray[0];
			parameters = (object)paramsArray[1];
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary ADO2.1 ADO2.5 
		/// </summary>
		/// <param name="Name">string Name</param>
		/// <param name="Type">NetOffice.ADODBApi.Enums.DataTypeEnum Type</param>
		/// <param name="Direction">NetOffice.ADODBApi.Enums.ParameterDirectionEnum Direction</param>
		/// <param name="Size">Int32 Size</param>
		/// <param name="Value">optional object Value</param>
		[SupportByLibrary("ADO2.1","ADO2.5")]
		public NetOffice.ADODBApi._Parameter CreateParameter(string name, NetOffice.ADODBApi.Enums.DataTypeEnum type, NetOffice.ADODBApi.Enums.ParameterDirectionEnum direction, Int32 size, object value)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(name, type, direction, size, value);
			object returnItem = Invoker.MethodReturn(this, "CreateParameter", paramsArray);
			NetOffice.ADODBApi._Parameter newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem) as NetOffice.ADODBApi._Parameter;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary ADO2.1 ADO2.5 
		/// </summary>
		/// <param name="Name">string Name</param>
		/// <param name="Type">NetOffice.ADODBApi.Enums.DataTypeEnum Type</param>
		/// <param name="Direction">NetOffice.ADODBApi.Enums.ParameterDirectionEnum Direction</param>
		/// <param name="Size">Int32 Size</param>
		[SupportByLibrary("ADO2.1","ADO2.5")]
		public NetOffice.ADODBApi._Parameter CreateParameter(string name, NetOffice.ADODBApi.Enums.DataTypeEnum type, NetOffice.ADODBApi.Enums.ParameterDirectionEnum direction, Int32 size)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(name, type, direction, size);
			object returnItem = Invoker.MethodReturn(this, "CreateParameter", paramsArray);
			NetOffice.ADODBApi._Parameter newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem) as NetOffice.ADODBApi._Parameter;
			return newObject;
		}

		#endregion
		#pragma warning restore
	}
}