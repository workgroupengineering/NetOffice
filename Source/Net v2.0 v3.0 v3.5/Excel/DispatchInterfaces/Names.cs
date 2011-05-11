//Generated by LateBindingApi.CodeGenerator
using System;
using NetRuntimeSystem = System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.ComponentModel;
using System.Reflection;
using System.Collections;
using LateBindingApi.Core;
namespace NetOffice.ExcelApi
{
	///<summary>
	/// DispatchInterface Names SupportByLibrary XL09 XL10 XL11 XL12 XL14 
	///</summary>
	[SupportByLibrary("XL09","XL10","XL11","XL12","XL14")]
	[EntityTypeAttribute(EntityType.IsDispatchInterface)]
	public class Names : COMObject ,IEnumerable
	{
		#pragma warning disable
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Names(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Names(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Names(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Names()
		{
		}
		
		#endregion
		
		#region Properties

		/// <summary>
		/// SupportByLibrary XL09 XL10 XL11 XL12 XL14 
		/// </summary>
		[SupportByLibrary("XL09","XL10","XL11","XL12","XL14")]
		public NetOffice.ExcelApi.Application Application
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Application", paramsArray);
				NetOffice.ExcelApi.Application newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.ExcelApi.Application;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary XL09 XL10 XL11 XL12 XL14 
		/// </summary>
		[SupportByLibrary("XL09","XL10","XL11","XL12","XL14")]
		public NetOffice.ExcelApi.Enums.XlCreator Creator
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Creator", paramsArray);
				return (NetOffice.ExcelApi.Enums.XlCreator)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary XL09 XL10 XL11 XL12 XL14 
		/// </summary>
		[SupportByLibrary("XL09","XL10","XL11","XL12","XL14")]
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
		/// SupportByLibrary XL09 XL10 XL11 XL12 XL14 
		/// </summary>
		[SupportByLibrary("XL09","XL10","XL11","XL12","XL14")]
		public Int32 Count
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Count", paramsArray);
				return (Int32)returnItem;
			}
		}

		#endregion

		#region Methods

		/// <summary>
		/// SupportByLibrary XL09 XL10 XL11 XL12 XL14 
		/// </summary>
		/// <param name="Name">optional object Name</param>
		/// <param name="RefersTo">optional object RefersTo</param>
		/// <param name="Visible">optional object Visible</param>
		/// <param name="MacroType">optional object MacroType</param>
		/// <param name="ShortcutKey">optional object ShortcutKey</param>
		/// <param name="Category">optional object Category</param>
		/// <param name="NameLocal">optional object NameLocal</param>
		/// <param name="RefersToLocal">optional object RefersToLocal</param>
		/// <param name="CategoryLocal">optional object CategoryLocal</param>
		/// <param name="RefersToR1C1">optional object RefersToR1C1</param>
		/// <param name="RefersToR1C1Local">optional object RefersToR1C1Local</param>
		[SupportByLibrary("XL09","XL10","XL11","XL12","XL14")]
		public NetOffice.ExcelApi.Name Add(object name, object refersTo, object visible, object macroType, object shortcutKey, object category, object nameLocal, object refersToLocal, object categoryLocal, object refersToR1C1, object refersToR1C1Local)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(name, refersTo, visible, macroType, shortcutKey, category, nameLocal, refersToLocal, categoryLocal, refersToR1C1, refersToR1C1Local);
			object returnItem = Invoker.MethodReturn(this, "Add", paramsArray);
			NetOffice.ExcelApi.Name newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem) as NetOffice.ExcelApi.Name;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary XL09 XL10 XL11 XL12 XL14 
		/// </summary>
		[SupportByLibrary("XL09","XL10","XL11","XL12","XL14")]
		public NetOffice.ExcelApi.Name Add()
		{
			object[] paramsArray = null;
			object returnItem = Invoker.MethodReturn(this, "Add", paramsArray);
			NetOffice.ExcelApi.Name newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem) as NetOffice.ExcelApi.Name;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary XL09 XL10 XL11 XL12 XL14 
		/// </summary>
		/// <param name="Index">optional object Index</param>
		/// <param name="IndexLocal">optional object IndexLocal</param>
		/// <param name="RefersTo">optional object RefersTo</param>
		[SupportByLibrary("XL09","XL10","XL11","XL12","XL14")]
		public NetOffice.ExcelApi.Name Item(object index, object indexLocal, object refersTo)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(index, indexLocal, refersTo);
			object returnItem = Invoker.MethodReturn(this, "Item", paramsArray);
			NetOffice.ExcelApi.Name newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem) as NetOffice.ExcelApi.Name;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary XL09 XL10 XL11 XL12 XL14 
		/// </summary>
		[SupportByLibrary("XL09","XL10","XL11","XL12","XL14")]
		public NetOffice.ExcelApi.Name Item()
		{
			object[] paramsArray = null;
			object returnItem = Invoker.MethodReturn(this, "Item", paramsArray);
			NetOffice.ExcelApi.Name newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem) as NetOffice.ExcelApi.Name;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary XL09 XL10 XL11 XL12 XL14 
		/// </summary>
		/// <param name="Index">optional object Index</param>
		/// <param name="IndexLocal">optional object IndexLocal</param>
		/// <param name="RefersTo">optional object RefersTo</param>
		[SupportByLibrary("XL09","XL10","XL11","XL12","XL14")]
		[NetRuntimeSystem.Runtime.CompilerServices.IndexerName("IndexerItem")]
		public NetOffice.ExcelApi.Name this[object index, object indexLocal, object refersTo]
		{
			get
			{
				object[] paramsArray = Invoker.ValidateParamsArray(index, indexLocal, refersTo);
				object returnItem = Invoker.MethodReturn(this, "_Default", paramsArray);
				NetOffice.ExcelApi.Name newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem) as NetOffice.ExcelApi.Name;
				return newObject;
			}
		}

		#endregion
   
        #region IEnumerable Members
        
        [SupportByLibrary("XL09","XL10","XL11","XL12","XL14")]
		public IEnumerator GetEnumerator()
		{
			object enumProxy = Invoker.PropertyGet(this, "_NewEnum");
			COMObject enumerator = new COMObject(this, enumProxy);
			Invoker.Method(enumerator, "Reset", null);
			bool isMoveNextTrue = (bool)Invoker.MethodReturn(enumerator, "MoveNext", null);
            while (true == isMoveNextTrue)
            {
                object itemProxy = Invoker.PropertyGet(enumerator, "Current", null);
                COMObject returnClass = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, itemProxy);
                isMoveNextTrue = (bool)Invoker.MethodReturn(enumerator, "MoveNext", null);
				yield return returnClass;
            }
        }

        #endregion
		#pragma warning restore
	}
}