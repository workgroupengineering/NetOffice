﻿using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;
using NetOffice;
using NetOffice.Attributes;

namespace NetOffice.AccessApi.Events
{	
	#pragma warning disable
	
	#region SinkPoint Interface

	[SupportByVersion("Access", 12,14,15,16)]
    [InternalEntity(InternalEntityKind.ComEventInterface)]
    [ComImport, Guid("2E705270-92D1-43CC-A57B-ED48BCCC711D"), InterfaceType(ComInterfaceType.InterfaceIsIDispatch), TypeLibType((short)0x1010)]
	public interface DispChildLabelEvents
	{
	}

    #endregion

    #region SinkHelper

    [InternalEntity(InternalEntityKind.SinkHelper)]
    [ComVisible(true), ClassInterface(ClassInterfaceType.None), TypeLibType(TypeLibTypeFlags.FHidden)]
	public class DispChildLabelEvents_SinkHelper : SinkHelper, DispChildLabelEvents
	{
		#region Static
		
		public static readonly string Id = "2E705270-92D1-43CC-A57B-ED48BCCC711D";
		
		#endregion
	
		#region Fields

		private IEventBinding	_eventBinding;
        private ICOMObject _eventClass;
        
		#endregion
		
		#region Construction

		public DispChildLabelEvents_SinkHelper(ICOMObject eventClass, IConnectionPoint connectPoint): base(eventClass)
		{
			_eventClass = eventClass;
			_eventBinding = (IEventBinding)eventClass;
			SetupEventBinding(connectPoint);
		}
		
		#endregion
		
		#region Properties

        internal Core Factory
        {
            get
            {
                if (null != _eventClass)
                    return _eventClass.Factory;
                else
                    return Core.Default;
            }
        }

        #endregion

		#region DispChildLabelEvents Members
		
		#endregion
	}
	
	#endregion
	
	#pragma warning restore
}