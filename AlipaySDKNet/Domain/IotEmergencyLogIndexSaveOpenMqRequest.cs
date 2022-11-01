using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// IotEmergencyLogIndexSaveOpenMqRequest Data Structure.
    /// </summary>
    [Serializable]
    public class IotEmergencyLogIndexSaveOpenMqRequest : AopObject
    {
        /// <summary>
        /// 指标id
        /// </summary>
        [XmlElement("index_id")]
        public string IndexId { get; set; }

        /// <summary>
        /// 指标值
        /// </summary>
        [XmlElement("value")]
        public string Value { get; set; }
    }
}
