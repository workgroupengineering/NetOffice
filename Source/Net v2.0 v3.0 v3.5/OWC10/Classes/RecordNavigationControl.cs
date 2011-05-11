//Generated by LateBindingApi.CodeGenerator
using System;
using NetRuntimeSystem = System;
using System.ComponentModel;
using LateBindingApi.Core;
namespace NetOffice.OWC10Api
{

	#region Delegates

	#pragma warning disable
	public delegate void RecordNavigationControl_ButtonClickEventHandler(NetOffice.OWC10Api.Enums.NavButtonEnum NavButton);
	#pragma warning restore

	#endregion

	///<summary>
	/// CoClass RecordNavigationControl SupportByLibrary XWC1.0 
	///</summary>
	[SupportByLibrary("XWC1.0")]
	[EntityTypeAttribute(EntityType.IsCoClass)]
	public class RecordNavigationControl : INavigationControl, IEventBinding 
	{
		#pragma warning disable
		#region Fields
		
		private NetRuntimeSystem.Runtime.InteropServices.ComTypes.IConnectionPoint _connectPoint;
		private string _activeSinkId;
		private NetRuntimeSystem.Type _thisType;
		_NavigationEvent_SinkHelper __NavigationEvent_SinkHelper;
	
		#endregion
		
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public RecordNavigationControl(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public RecordNavigationControl(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public RecordNavigationControl(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		public RecordNavigationControl()
		{
			CreateFromProgId("OWC10.RecordNavigationControl");
		}
		
		/// <param name="progId">progId</param>
		public RecordNavigationControl(string progId)
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
				_activeSinkId = SinkHelper.GetConnectionPoint(this, ref _connectPoint, _NavigationEvent_SinkHelper.Id);


			if(_NavigationEvent_SinkHelper.Id.Equals(_activeSinkId, StringComparison.InvariantCultureIgnoreCase))
			{
				__NavigationEvent_SinkHelper = new _NavigationEvent_SinkHelper(this, _connectPoint);
				return;
			} 
        }
		
		#endregion

		#region Events

		/// <summary>
		/// SupportByLibrary XWC1.0
		/// </summary>
		private event RecordNavigationControl_ButtonClickEventHandler _ButtonClickEvent;

		/// <summary>
		/// SupportByLibrary XWC1.0
		/// </summary>
		[SupportByLibrary("XWC1.0")]
		public event RecordNavigationControl_ButtonClickEventHandler ButtonClickEvent
		{
			add
			{
				CreateEventBridge();
				_ButtonClickEvent += value;
			}
			remove
			{
				_ButtonClickEvent -= value;
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
			if( null != __NavigationEvent_SinkHelper)
			{
				__NavigationEvent_SinkHelper.Dispose();
				__NavigationEvent_SinkHelper = null;
			}

			_connectPoint = null;
		}
        
        #endregion
		#pragma warning restore
	}
}