using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// IoTBPaaSMerchantOrderRequireInfo Data Structure.
    /// </summary>
    [Serializable]
    public class IoTBPaaSMerchantOrderRequireInfo : AopObject
    {
        /// <summary>
        /// 内容
        /// </summary>
        [XmlElement("content")]
        public string Content { get; set; }

        /// <summary>
        /// 名称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 是否必填
        /// </summary>
        [XmlElement("valid")]
        public bool Valid { get; set; }
    }
}
