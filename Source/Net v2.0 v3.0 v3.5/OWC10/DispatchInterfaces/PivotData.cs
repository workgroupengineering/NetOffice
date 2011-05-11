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
	/// DispatchInterface PivotData SupportByLibrary XWC1.0 
	///</summary>
	[SupportByLibrary("XWC1.0")]
	[EntityTypeAttribute(EntityType.IsDispatchInterface)]
	public class PivotData : COMObject
	{
		#pragma warning disable
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public PivotData(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public PivotData(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public PivotData(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public PivotData()
		{
		}
		
		#endregion
		
		#region Properties

		/// <summary>
		/// SupportByLibrary XWC1.0 
		/// </summary>
		[SupportByLibrary("XWC1.0")]
		public NetOffice.OWC10Api.PivotView View
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "View", paramsArray);
				NetOffice.OWC10Api.PivotView newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.OWC10Api.PivotView;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary XWC1.0 
		/// </summary>
		[SupportByLibrary("XWC1.0")]
		public NetOffice.OWC10Api.PivotResultRowAxis RowAxis
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "RowAxis", paramsArray);
				NetOffice.OWC10Api.PivotResultRowAxis newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.OWC10Api.PivotResultRowAxis;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary XWC1.0 
		/// </summary>
		[SupportByLibrary("XWC1.0")]
		public NetOffice.OWC10Api.PivotResultColumnAxis ColumnAxis
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ColumnAxis", paramsArray);
				NetOffice.OWC10Api.PivotResultColumnAxis newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.OWC10Api.PivotResultColumnAxis;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary XWC1.0 
		/// </summary>
		[SupportByLibrary("XWC1.0")]
		public NetOffice.OWC10Api.PivotResultFilterAxis FilterAxis
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "FilterAxis", paramsArray);
				NetOffice.OWC10Api.PivotResultFilterAxis newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.OWC10Api.PivotResultFilterAxis;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary XWC1.0 
		/// </summary>
		[SupportByLibrary("XWC1.0")]
		public NetOffice.OWC10Api.PivotResultDataAxis DataAxis
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "DataAxis", paramsArray);
				NetOffice.OWC10Api.PivotResultDataAxis newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.OWC10Api.PivotResultDataAxis;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary XWC1.0 
		/// </summary>
		[SupportByLibrary("XWC1.0")]
		public NetOffice.OWC10Api.PivotColumnMember Left
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Left", paramsArray);
				NetOffice.OWC10Api.PivotColumnMember newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.OWC10Api.PivotColumnMember;
				return newObject;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Left", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary XWC1.0 
		/// </summary>
		[SupportByLibrary("XWC1.0")]
		public NetOffice.OWC10Api.PivotRowMember Top
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Top", paramsArray);
				NetOffice.OWC10Api.PivotRowMember newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.OWC10Api.PivotRowMember;
				return newObject;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Top", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary XWC1.0 
		/// </summary>
		/// <param name="Row">NetOffice.OWC10Api.PivotRowMember Row</param>
		/// <param name="Column">NetOffice.OWC10Api.PivotColumnMember Column</param>
		[SupportByLibrary("XWC1.0")]
		public NetOffice.OWC10Api.PivotCell get_Cells(NetOffice.OWC10Api.PivotRowMember row, NetOffice.OWC10Api.PivotColumnMember column)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(row, column);
			object returnItem = Invoker.PropertyGet(this, "Cells", paramsArray);
			NetOffice.OWC10Api.PivotCell newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.OWC10Api.PivotCell;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary XWC1.0 
		/// </summary>
		/// <param name="Column">NetOffice.OWC10Api.PivotColumnMember Column</param>
		[SupportByLibrary("XWC1.0")]
		public Int32 get_DetailLeft(NetOffice.OWC10Api.PivotColumnMember column)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(column);
			object returnItem = Invoker.PropertyGet(this, "DetailLeft", paramsArray);
			return (Int32)returnItem;
		}

		/// <summary>
		/// SupportByLibrary XWC1.0 
		/// </summary>
		/// <param name="Column">NetOffice.OWC10Api.PivotColumnMember Column</param>
		[SupportByLibrary("XWC1.0")]
		public void set_DetailLeft(NetOffice.OWC10Api.PivotColumnMember column, Int32 value)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(column);
			Invoker.PropertySet(this, "DetailLeft", paramsArray, value);
		}

		/// <summary>
		/// SupportByLibrary XWC1.0 
		/// </summary>
		/// <param name="TopLeft">NetOffice.OWC10Api.PivotCell TopLeft</param>
		/// <param name="BottomRight">NetOffice.OWC10Api.PivotCell BottomRight</param>
		[SupportByLibrary("XWC1.0")]
		public NetOffice.OWC10Api.PivotRange get_Range(NetOffice.OWC10Api.PivotCell topLeft, NetOffice.OWC10Api.PivotCell bottomRight)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(topLeft, bottomRight);
			object returnItem = Invoker.PropertyGet(this, "Range", paramsArray);
			NetOffice.OWC10Api.PivotRange newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.OWC10Api.PivotRange;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary XWC1.0 
		/// </summary>
		[SupportByLibrary("XWC1.0")]
		public Int32 Left2
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Left2", paramsArray);
				return (Int32)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary XWC1.0 
		/// </summary>
		[SupportByLibrary("XWC1.0")]
		public Int32 Top2
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Top2", paramsArray);
				return (Int32)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary XWC1.0 
		/// </summary>
		[SupportByLibrary("XWC1.0")]
		public NetOffice.OWC10Api.PivotResultLabel Label
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Label", paramsArray);
				NetOffice.OWC10Api.PivotResultLabel newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.OWC10Api.PivotResultLabel;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary XWC1.0 
		/// </summary>
		[SupportByLibrary("XWC1.0")]
		public NetOffice.OWC10Api.IPivotControl Control
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Control", paramsArray);
				NetOffice.OWC10Api.IPivotControl newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.OWC10Api.IPivotControl;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary XWC1.0 
		/// </summary>
		[SupportByLibrary("XWC1.0")]
		public NetOffice.OWC10Api.PivotRowMembers RowMembers
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "RowMembers", paramsArray);
				NetOffice.OWC10Api.PivotRowMembers newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.OWC10Api.PivotRowMembers;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary XWC1.0 
		/// </summary>
		[SupportByLibrary("XWC1.0")]
		public NetOffice.OWC10Api.PivotColumnMembers ColumnMembers
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ColumnMembers", paramsArray);
				NetOffice.OWC10Api.PivotColumnMembers newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.OWC10Api.PivotColumnMembers;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary XWC1.0 
		/// </summary>
		[SupportByLibrary("XWC1.0")]
		public NetOffice.OWC10Api.PivotCell CurrentCell
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "CurrentCell", paramsArray);
				NetOffice.OWC10Api.PivotCell newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.OWC10Api.PivotCell;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary XWC1.0 
		/// </summary>
		[SupportByLibrary("XWC1.0")]
		public Int32 LeftOffset
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "LeftOffset", paramsArray);
				return (Int32)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "LeftOffset", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary XWC1.0 
		/// </summary>
		[SupportByLibrary("XWC1.0")]
		public Int32 TopOffset
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "TopOffset", paramsArray);
				return (Int32)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "TopOffset", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary XWC1.0 
		/// </summary>
		[SupportByLibrary("XWC1.0")]
		public Int32 ViewportTop
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ViewportTop", paramsArray);
				return (Int32)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "ViewportTop", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary XWC1.0 
		/// </summary>
		[SupportByLibrary("XWC1.0")]
		public Int32 ViewportLeft
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ViewportLeft", paramsArray);
				return (Int32)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "ViewportLeft", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary XWC1.0 
		/// </summary>
		/// <param name="Row">NetOffice.OWC10Api.PivotRowMember Row</param>
		/// <param name="Column">NetOffice.OWC10Api.PivotColumnMember Column</param>
		/// <param name="Page">NetOffice.OWC10Api.PivotPageMember Page</param>
		[SupportByLibrary("XWC1.0")]
		public NetOffice.OWC10Api.PivotCell get_CellsEx(NetOffice.OWC10Api.PivotRowMember row, NetOffice.OWC10Api.PivotColumnMember column, NetOffice.OWC10Api.PivotPageMember page)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(row, column, page);
			object returnItem = Invoker.PropertyGet(this, "CellsEx", paramsArray);
			NetOffice.OWC10Api.PivotCell newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.OWC10Api.PivotCell;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary XWC1.0 
		/// </summary>
		[SupportByLibrary("XWC1.0")]
		public NetOffice.OWC10Api.PivotResultPageAxis PageAxis
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "PageAxis", paramsArray);
				NetOffice.OWC10Api.PivotResultPageAxis newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.OWC10Api.PivotResultPageAxis;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary XWC1.0 
		/// </summary>
		[SupportByLibrary("XWC1.0")]
		public NetOffice.ADODBApi.Recordset Recordset
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Recordset", paramsArray);
				NetOffice.ADODBApi.Recordset newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.ADODBApi.Recordset;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary XWC1.0 
		/// </summary>
		[SupportByLibrary("XWC1.0")]
		public bool IsConsistent
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "IsConsistent", paramsArray);
				return (bool)returnItem;
			}
		}

		#endregion

		#region Methods

		/// <summary>
		/// SupportByLibrary XWC1.0 
		/// </summary>
		/// <param name="Top">NetOffice.OWC10Api.PivotRowMember Top</param>
		/// <param name="TopOffset">Int32 TopOffset</param>
		/// <param name="Update">bool Update</param>
		[SupportByLibrary("XWC1.0")]
		public void MoveTop(NetOffice.OWC10Api.PivotRowMember top, Int32 topOffset, bool update)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(top, topOffset, update);
			Invoker.Method(this, "MoveTop", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary XWC1.0 
		/// </summary>
		/// <param name="Left">NetOffice.OWC10Api.PivotColumnMember Left</param>
		/// <param name="LeftOffset">Int32 LeftOffset</param>
		/// <param name="Update">bool Update</param>
		[SupportByLibrary("XWC1.0")]
		public void MoveLeft(NetOffice.OWC10Api.PivotColumnMember left, Int32 leftOffset, bool update)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(left, leftOffset, update);
			Invoker.Method(this, "MoveLeft", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary XWC1.0 
		/// </summary>
		[SupportByLibrary("XWC1.0")]
		public void ShowDetails()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "ShowDetails", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary XWC1.0 
		/// </summary>
		[SupportByLibrary("XWC1.0")]
		public void HideDetails()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "HideDetails", paramsArray);
		}

		#endregion
		#pragma warning restore
	}
}