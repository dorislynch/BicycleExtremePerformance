using ReactNative.Bridge;
using System;
using System.Collections.Generic;
using Windows.ApplicationModel.Core;
using Windows.UI.Core;

namespace Bicycle.Extreme.Performance.RNBicycleExtremePerformance
{
    /// <summary>
    /// A module that allows JS to share data.
    /// </summary>
    class RNBicycleExtremePerformanceModule : NativeModuleBase
    {
        /// <summary>
        /// Instantiates the <see cref="RNBicycleExtremePerformanceModule"/>.
        /// </summary>
        internal RNBicycleExtremePerformanceModule()
        {

        }

        /// <summary>
        /// The name of the native module.
        /// </summary>
        public override string Name
        {
            get
            {
                return "RNBicycleExtremePerformance";
            }
        }
    }
}
