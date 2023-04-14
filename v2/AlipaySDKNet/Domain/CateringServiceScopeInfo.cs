using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// CateringServiceScopeInfo Data Structure.
    /// </summary>
    [Serializable]
    public class CateringServiceScopeInfo : AopObject
    {
        /// <summary>
        /// 自提范围
        /// </summary>
        [XmlElement("pick_up_scope_info")]
        public ScopeInfo PickUpScopeInfo { get; set; }

        /// <summary>
        /// 排队范围
        /// </summary>
        [XmlElement("queue_scope_info")]
        public ScopeInfo QueueScopeInfo { get; set; }

        /// <summary>
        /// 外卖配送范围
        /// </summary>
        [XmlArray("take_away_scope_info")]
        [XmlArrayItem("take_away_scope_info")]
        public List<TakeAwayScopeInfo> TakeAwayScopeInfo { get; set; }
    }
}
