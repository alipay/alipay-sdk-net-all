using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MarketTargetConfiguration Data Structure.
    /// </summary>
    [Serializable]
    public class MarketTargetConfiguration : AopObject
    {
        /// <summary>
        /// 营销 目标配置
        /// </summary>
        [XmlArray("action_property_list")]
        [XmlArrayItem("market_target_configuration_action_property")]
        public List<MarketTargetConfigurationActionProperty> ActionPropertyList { get; set; }
    }
}
