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
	/// DispatchInterface SmartDocument SupportByLibrary OF11 OF12 OF14 
	///</summary>
	[SupportByLibrary("OF11","OF12","OF14")]
	[EntityTypeAttribute(EntityType.IsDispatchInterface)]
	public class SmartDocument : _IMsoDispObj
	{
		#pragma warning disable
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public SmartDocument(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public SmartDocument(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public SmartDocument(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public SmartDocument()
		{
		}
		
		#endregion
		
		#region Properties

		/// <summary>
		/// SupportByLibrary OF11 OF12 OF14 
		/// </summary>
		[SupportByLibrary("OF11","OF12","OF14")]
		public string SolutionID
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "SolutionID", paramsArray);
				return (string)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "SolutionID", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary OF11 OF12 OF14 
		/// </summary>
		[SupportByLibrary("OF11","OF12","OF14")]
		public string SolutionURL
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "SolutionURL", paramsArray);
				return (string)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "SolutionURL", paramsArray);
			}
		}

		#endregion

		#region Methods

		/// <summary>
		/// SupportByLibrary OF11 OF12 OF14 
		/// </summary>
		/// <param name="ConsiderAllSchemas">bool ConsiderAllSchemas</param>
		[SupportByLibrary("OF11","OF12","OF14")]
		public void PickSolution(bool considerAllSchemas)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(considerAllSchemas);
			Invoker.Method(this, "PickSolution", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary OF11 OF12 OF14 
		/// </summary>
		[SupportByLibrary("OF11","OF12","OF14")]
		public void RefreshPane()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "RefreshPane", paramsArray);
		}

		#endregion
		#pragma warning restore
	}
}