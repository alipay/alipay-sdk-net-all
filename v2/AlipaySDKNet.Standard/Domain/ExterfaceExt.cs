using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ExterfaceExt Data Structure.
    /// </summary>
    [Serializable]
    public class ExterfaceExt : AopObject
    {
        /// <summary>
        /// 通知字段
        /// </summary>
        [XmlArray("notify_field_ext")]
        [XmlArrayItem("notify_field_ext")]
        public List<NotifyFieldExt> NotifyFieldExt { get; set; }

        /// <summary>
        /// 通知场景
        /// </summary>
        [XmlArray("notify_trigger_ext")]
        [XmlArrayItem("notify_trigger_ext")]
        public List<NotifyTriggerExt> NotifyTriggerExt { get; set; }

        /// <summary>
        /// 输出字段
        /// </summary>
        [XmlArray("output_ext")]
        [XmlArrayItem("output_ext")]
        public List<OutputExt> OutputExt { get; set; }
    }
}
