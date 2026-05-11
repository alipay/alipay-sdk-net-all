using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// DeviceLabelInfo Data Structure.
    /// </summary>
    [Serializable]
    public class DeviceLabelInfo : AopObject
    {
        /// <summary>
        /// 标签key
        /// </summary>
        [XmlElement("label_key")]
        public string LabelKey { get; set; }

        /// <summary>
        /// 标签值
        /// </summary>
        [XmlElement("label_value")]
        public string LabelValue { get; set; }
    }
}
