using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayMerchantSolcreditserviceprodProductQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMerchantSolcreditserviceprodProductQueryModel : AopObject
    {
        /// <summary>
        /// 商家编辑商品时自定义的编号
        /// </summary>
        [XmlElement("out_product_no")]
        public string OutProductNo { get; set; }

        /// <summary>
        /// 系统生成的商品编号
        /// </summary>
        [XmlElement("product_no")]
        public string ProductNo { get; set; }

        /// <summary>
        /// 直付通进件得到的ID
        /// </summary>
        [XmlElement("smid")]
        public string Smid { get; set; }
    }
}
