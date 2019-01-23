using ReactNative.Bridge;
using System;
using System.Collections.Generic;
using Windows.ApplicationModel.Core;
using Windows.UI.Core;

namespace Rn.Key.Events.RNRnKeyEvents
{
    /// <summary>
    /// A module that allows JS to share data.
    /// </summary>
    class RNRnKeyEventsModule : NativeModuleBase
    {
        /// <summary>
        /// Instantiates the <see cref="RNRnKeyEventsModule"/>.
        /// </summary>
        internal RNRnKeyEventsModule()
        {

        }

        /// <summary>
        /// The name of the native module.
        /// </summary>
        public override string Name
        {
            get
            {
                return "RNRnKeyEvents";
            }
        }
    [ReactMethod]
        public void open()
        {
            return "TEST STRING"
        }
    }
}
