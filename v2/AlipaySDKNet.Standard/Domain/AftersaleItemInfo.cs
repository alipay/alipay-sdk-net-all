using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AftersaleItemInfo Data Structure.
    /// </summary>
    [Serializable]
    public class AftersaleItemInfo : AopObject
    {
        /// <summary>
        /// 售后凭证信息
        /// </summary>
        [XmlArray("certificate_vo_list")]
        [XmlArrayItem("aftersale_certificate_info")]
        public List<AftersaleCertificateInfo> CertificateVoList { get; set; }

        /// <summary>
        /// 商品数量,单位:"个"
        /// </summary>
        [XmlElement("item_cnt")]
        public string ItemCnt { get; set; }

        /// <summary>
        /// 外部商品id
        /// </summary>
        [XmlElement("out_item_id")]
        public string OutItemId { get; set; }

        /// <summary>
        /// 外部skuid
        /// </summary>
        [XmlElement("out_sku_id")]
        public string OutSkuId { get; set; }
    }
}
