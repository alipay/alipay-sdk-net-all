using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ExtTemplateConf Data Structure.
    /// </summary>
    [Serializable]
    public class ExtTemplateConf : AopObject
    {
        /// <summary>
        /// 淘宝uid
        /// </summary>
        [XmlElement("buyer_id")]
        public string BuyerId { get; set; }

        /// <summary>
        /// 先享后买id
        /// </summary>
        [XmlElement("xxhm_info_id")]
        public string XxhmInfoId { get; set; }
    }
}
