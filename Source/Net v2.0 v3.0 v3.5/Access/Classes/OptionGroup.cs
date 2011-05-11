//Generated by LateBindingApi.CodeGenerator
using System;
using NetRuntimeSystem = System;
using System.ComponentModel;
using LateBindingApi.Core;
namespace NetOffice.AccessApi
{

	#region Delegates

	#pragma warning disable
	public delegate void OptionGroup_BeforeUpdateEventHandler(ref Int16 Cancel);
	public delegate void OptionGroup_AfterUpdateEventHandler();
	public delegate void OptionGroup_EnterEventHandler();
	public delegate void OptionGroup_ExitEventHandler(ref Int16 Cancel);
	public delegate void OptionGroup_ClickEventHandler();
	public delegate void OptionGroup_DblClickEventHandler(ref Int16 Cancel);
	public delegate void OptionGroup_MouseDownEventHandler(ref Int16 Button, ref Int16 Shift, ref Single X, ref Single Y);
	public delegate void OptionGroup_MouseMoveEventHandler(ref Int16 Button, ref Int16 Shift, ref Single X, ref Single Y);
	public delegate void OptionGroup_MouseUpEventHandler(ref Int16 Button, ref Int16 Shift, ref Single X, ref Single Y);
	#pragma warning restore

	#endregion

	///<summary>
	/// CoClass OptionGroup SupportByLibrary AC09 AC10 AC11 AC12 AC14 
	///</summary>
	[SupportByLibrary("AC09","AC10","AC11","AC12","AC14")]
	[EntityTypeAttribute(EntityType.IsCoClass)]
	public class OptionGroup : _OptionGroup, IEventBinding 
	{
		#pragma warning disable
		#region Fields
		
		private NetRuntimeSystem.Runtime.InteropServices.ComTypes.IConnectionPoint _connectPoint;
		private string _activeSinkId;
		private NetRuntimeSystem.Type _thisType;
		_OptionGroupEvents_SinkHelper __OptionGroupEvents_SinkHelper;
		DispOptionGroupEvents_SinkHelper _dispOptionGroupEvents_SinkHelper;
	
		#endregion
		
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public OptionGroup(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public OptionGroup(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public OptionGroup(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		public OptionGroup()
		{
			CreateFromProgId("Access.OptionGroup");
		}
		
		/// <param name="progId">progId</param>
		public OptionGroup(string progId)
		{
			CreateFromProgId(progId);
		}

		#endregion
		
		#region Private Methods
		
		/// <summary>
        /// creates active sink helper
        /// </summary>
		private void CreateEventBridge()
        {
			if(false == LateBindingApi.Core.Settings.EnableEvents)
				return;
	
			if (null != _connectPoint)
				return;
	
            if (null == _activeSinkId)
				_activeSinkId = SinkHelper.GetConnectionPoint(this, ref _connectPoint, _OptionGroupEvents_SinkHelper.Id,DispOptionGroupEvents_SinkHelper.Id);


			if(_OptionGroupEvents_SinkHelper.Id.Equals(_activeSinkId, StringComparison.InvariantCultureIgnoreCase))
			{
				__OptionGroupEvents_SinkHelper = new _OptionGroupEvents_SinkHelper(this, _connectPoint);
				return;
			}

			if(DispOptionGroupEvents_SinkHelper.Id.Equals(_activeSinkId, StringComparison.InvariantCultureIgnoreCase))
			{
				_dispOptionGroupEvents_SinkHelper = new DispOptionGroupEvents_SinkHelper(this, _connectPoint);
				return;
			} 
        }
		
		#endregion

		#region Events

		/// <summary>
		/// SupportByLibrary AC09 AC10 AC11 AC12 AC14
		/// </summary>
		private event OptionGroup_BeforeUpdateEventHandler _BeforeUpdateEvent;

		/// <summary>
		/// SupportByLibrary AC09 AC10 AC11 AC12 AC14
		/// </summary>
		[SupportByLibrary("AC09","AC10","AC11","AC12","AC14")]
		public event OptionGroup_BeforeUpdateEventHandler BeforeUpdateEvent
		{
			add
			{
				CreateEventBridge();
				_BeforeUpdateEvent += value;
			}
			remove
			{
				_BeforeUpdateEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary AC09 AC10 AC11 AC12 AC14
		/// </summary>
		private event OptionGroup_AfterUpdateEventHandler _AfterUpdateEvent;

		/// <summary>
		/// SupportByLibrary AC09 AC10 AC11 AC12 AC14
		/// </summary>
		[SupportByLibrary("AC09","AC10","AC11","AC12","AC14")]
		public event OptionGroup_AfterUpdateEventHandler AfterUpdateEvent
		{
			add
			{
				CreateEventBridge();
				_AfterUpdateEvent += value;
			}
			remove
			{
				_AfterUpdateEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary AC09 AC10 AC11 AC12 AC14
		/// </summary>
		private event OptionGroup_EnterEventHandler _EnterEvent;

		/// <summary>
		/// SupportByLibrary AC09 AC10 AC11 AC12 AC14
		/// </summary>
		[SupportByLibrary("AC09","AC10","AC11","AC12","AC14")]
		public event OptionGroup_EnterEventHandler EnterEvent
		{
			add
			{
				CreateEventBridge();
				_EnterEvent += value;
			}
			remove
			{
				_EnterEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary AC09 AC10 AC11 AC12 AC14
		/// </summary>
		private event OptionGroup_ExitEventHandler _ExitEvent;

		/// <summary>
		/// SupportByLibrary AC09 AC10 AC11 AC12 AC14
		/// </summary>
		[SupportByLibrary("AC09","AC10","AC11","AC12","AC14")]
		public event OptionGroup_ExitEventHandler ExitEvent
		{
			add
			{
				CreateEventBridge();
				_ExitEvent += value;
			}
			remove
			{
				_ExitEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary AC09 AC10 AC11 AC12 AC14
		/// </summary>
		private event OptionGroup_ClickEventHandler _ClickEvent;

		/// <summary>
		/// SupportByLibrary AC09 AC10 AC11 AC12 AC14
		/// </summary>
		[SupportByLibrary("AC09","AC10","AC11","AC12","AC14")]
		public event OptionGroup_ClickEventHandler ClickEvent
		{
			add
			{
				CreateEventBridge();
				_ClickEvent += value;
			}
			remove
			{
				_ClickEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary AC09 AC10 AC11 AC12 AC14
		/// </summary>
		private event OptionGroup_DblClickEventHandler _DblClickEvent;

		/// <summary>
		/// SupportByLibrary AC09 AC10 AC11 AC12 AC14
		/// </summary>
		[SupportByLibrary("AC09","AC10","AC11","AC12","AC14")]
		public event OptionGroup_DblClickEventHandler DblClickEvent
		{
			add
			{
				CreateEventBridge();
				_DblClickEvent += value;
			}
			remove
			{
				_DblClickEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary AC09 AC10 AC11 AC12 AC14
		/// </summary>
		private event OptionGroup_MouseDownEventHandler _MouseDownEvent;

		/// <summary>
		/// SupportByLibrary AC09 AC10 AC11 AC12 AC14
		/// </summary>
		[SupportByLibrary("AC09","AC10","AC11","AC12","AC14")]
		public event OptionGroup_MouseDownEventHandler MouseDownEvent
		{
			add
			{
				CreateEventBridge();
				_MouseDownEvent += value;
			}
			remove
			{
				_MouseDownEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary AC09 AC10 AC11 AC12 AC14
		/// </summary>
		private event OptionGroup_MouseMoveEventHandler _MouseMoveEvent;

		/// <summary>
		/// SupportByLibrary AC09 AC10 AC11 AC12 AC14
		/// </summary>
		[SupportByLibrary("AC09","AC10","AC11","AC12","AC14")]
		public event OptionGroup_MouseMoveEventHandler MouseMoveEvent
		{
			add
			{
				CreateEventBridge();
				_MouseMoveEvent += value;
			}
			remove
			{
				_MouseMoveEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary AC09 AC10 AC11 AC12 AC14
		/// </summary>
		private event OptionGroup_MouseUpEventHandler _MouseUpEvent;

		/// <summary>
		/// SupportByLibrary AC09 AC10 AC11 AC12 AC14
		/// </summary>
		[SupportByLibrary("AC09","AC10","AC11","AC12","AC14")]
		public event OptionGroup_MouseUpEventHandler MouseUpEvent
		{
			add
			{
				CreateEventBridge();
				_MouseUpEvent += value;
			}
			remove
			{
				_MouseUpEvent -= value;
			}
		}

		#endregion

        #region IEventBinding Member
        
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        public bool EventBridgeInitialized
        {
            get 
            {
                return (null != _connectPoint);
            }
        }
        
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        public bool HasEventRecipients       
        {
			get
			{
				if(null == _thisType)
					_thisType = this.GetType();
					
				foreach (NetRuntimeSystem.Reflection.EventInfo item in _thisType.GetEvents())
				{
					MulticastDelegate eventDelegate = (MulticastDelegate) _thisType.GetType().GetField(item.Name, 
																			NetRuntimeSystem.Reflection.BindingFlags.NonPublic |
																			NetRuntimeSystem.Reflection.BindingFlags.Instance).GetValue(this);
					
					if( (null != eventDelegate) && (eventDelegate.GetInvocationList().Length > 0) )
						return false;
				}
				
				return false;
			}
        }
        
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        public Delegate[] GetEventRecipients(string eventName)
        {
			if(null == _thisType)
				_thisType = this.GetType();
             
            MulticastDelegate eventDelegate = (MulticastDelegate)_thisType.GetField(
                                                "_" + eventName + "Event",
                                                NetRuntimeSystem.Reflection.BindingFlags.Instance |
                                                NetRuntimeSystem.Reflection.BindingFlags.NonPublic).GetValue(this);

            if (null != eventDelegate)
            {
                Delegate[] delegates = eventDelegate.GetInvocationList();
                return delegates;
            }
            else
                return new Delegate[0];
        }

        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        public void DisposeSinkHelper()
        {
			if( null != __OptionGroupEvents_SinkHelper)
			{
				__OptionGroupEvents_SinkHelper.Dispose();
				__OptionGroupEvents_SinkHelper = null;
			}
			if( null != _dispOptionGroupEvents_SinkHelper)
			{
				_dispOptionGroupEvents_SinkHelper.Dispose();
				_dispOptionGroupEvents_SinkHelper = null;
			}

			_connectPoint = null;
		}
        
        #endregion
		#pragma warning restore
	}
}