using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// SmartphoneVendorsEventInfo Data Structure.
    /// </summary>
    [Serializable]
    public class SmartphoneVendorsEventInfo : AopObject
    {
        /// <summary>
        /// 事件码
        /// </summary>
        [XmlElement("event_code")]
        public string EventCode { get; set; }

        /// <summary>
        /// 触发事件相关信息
        /// </summary>
        [XmlElement("trigger_condition")]
        public string TriggerCondition { get; set; }
    }
}
