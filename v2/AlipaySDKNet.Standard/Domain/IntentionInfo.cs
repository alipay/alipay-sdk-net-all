using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// IntentionInfo Data Structure.
    /// </summary>
    [Serializable]
    public class IntentionInfo : AopObject
    {
        /// <summary>
        /// 区域信息
        /// </summary>
        [XmlElement("area_info")]
        public IntentionAreaInfo AreaInfo { get; set; }

        /// <summary>
        /// 意图基础信息
        /// </summary>
        [XmlElement("base_info")]
        public IntentionBaseInfo BaseInfo { get; set; }
    }
}
