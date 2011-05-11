//Generated by LateBindingApi.CodeGenerator
using System;
using NetRuntimeSystem = System;
using System.ComponentModel;
using LateBindingApi.Core;
namespace NetOffice.OfficeApi
{

	#region Delegates

	#pragma warning disable
	public delegate void CustomTaskPane_VisibleStateChangeEventHandler(NetOffice.OfficeApi._CustomTaskPane CustomTaskPaneInst);
	public delegate void CustomTaskPane_DockPositionStateChangeEventHandler(NetOffice.OfficeApi._CustomTaskPane CustomTaskPaneInst);
	#pragma warning restore

	#endregion

	///<summary>
	/// CoClass CustomTaskPane SupportByLibrary OF12 OF14 
	///</summary>
	[SupportByLibrary("OF12","OF14")]
	[EntityTypeAttribute(EntityType.IsCoClass)]
	public class CustomTaskPane : _CustomTaskPane, IEventBinding 
	{
		#pragma warning disable
		#region Fields
		
		private NetRuntimeSystem.Runtime.InteropServices.ComTypes.IConnectionPoint _connectPoint;
		private string _activeSinkId;
		private NetRuntimeSystem.Type _thisType;
		_CustomTaskPaneEvents_SinkHelper __CustomTaskPaneEvents_SinkHelper;
	
		#endregion
		
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public CustomTaskPane(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public CustomTaskPane(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public CustomTaskPane(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		public CustomTaskPane()
		{
			CreateFromProgId("Office.CustomTaskPane");
		}
		
		/// <param name="progId">progId</param>
		public CustomTaskPane(string progId)
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
				_activeSinkId = SinkHelper.GetConnectionPoint(this, ref _connectPoint, _CustomTaskPaneEvents_SinkHelper.Id);


			if(_CustomTaskPaneEvents_SinkHelper.Id.Equals(_activeSinkId, StringComparison.InvariantCultureIgnoreCase))
			{
				__CustomTaskPaneEvents_SinkHelper = new _CustomTaskPaneEvents_SinkHelper(this, _connectPoint);
				return;
			} 
        }
		
		#endregion

		#region Events

		/// <summary>
		/// SupportByLibrary OF12 OF14
		/// </summary>
		private event CustomTaskPane_VisibleStateChangeEventHandler _VisibleStateChangeEvent;

		/// <summary>
		/// SupportByLibrary OF12 OF14
		/// </summary>
		[SupportByLibrary("OF12","OF14")]
		public event CustomTaskPane_VisibleStateChangeEventHandler VisibleStateChangeEvent
		{
			add
			{
				CreateEventBridge();
				_VisibleStateChangeEvent += value;
			}
			remove
			{
				_VisibleStateChangeEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary OF12 OF14
		/// </summary>
		private event CustomTaskPane_DockPositionStateChangeEventHandler _DockPositionStateChangeEvent;

		/// <summary>
		/// SupportByLibrary OF12 OF14
		/// </summary>
		[SupportByLibrary("OF12","OF14")]
		public event CustomTaskPane_DockPositionStateChangeEventHandler DockPositionStateChangeEvent
		{
			add
			{
				CreateEventBridge();
				_DockPositionStateChangeEvent += value;
			}
			remove
			{
				_DockPositionStateChangeEvent -= value;
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
			if( null != __CustomTaskPaneEvents_SinkHelper)
			{
				__CustomTaskPaneEvents_SinkHelper.Dispose();
				__CustomTaskPaneEvents_SinkHelper = null;
			}

			_connectPoint = null;
		}
        
        #endregion
		#pragma warning restore
	}
}