using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceLifeserviceShopCopyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceLifeserviceShopCopyModel : AopObject
    {
        /// <summary>
        /// 复制类型
        /// </summary>
        [XmlElement("copy_type")]
        public string CopyType { get; set; }

        /// <summary>
        /// 复制源
        /// </summary>
        [XmlElement("source_shop_id")]
        public string SourceShopId { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("target_out_shop_ids")]
        [XmlArrayItem("string")]
        public List<string> TargetOutShopIds { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("target_shop_ids")]
        [XmlArrayItem("string")]
        public List<string> TargetShopIds { get; set; }
    }
}
