using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceEcRecyclinginvoiceItemCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceEcRecyclinginvoiceItemCreateModel : AopObject
    {
        /// <summary>
        /// 商品名称
        /// </summary>
        [XmlElement("item_name")]
        public string ItemName { get; set; }

        /// <summary>
        /// 规格型号
        /// </summary>
        [XmlElement("item_spec")]
        public string ItemSpec { get; set; }

        /// <summary>
        /// 商品单位
        /// </summary>
        [XmlElement("item_unit")]
        public string ItemUnit { get; set; }

        /// <summary>
        /// 外部商品ID，是由请求者传入的
        /// </summary>
        [XmlElement("out_item_id")]
        public string OutItemId { get; set; }

        /// <summary>
        /// 根据企业（商户）所开通的产品查询该产品ID
        /// </summary>
        [XmlElement("product_id")]
        public string ProductId { get; set; }

        /// <summary>
        /// 税收分类编码
        /// </summary>
        [XmlElement("tax_code")]
        public string TaxCode { get; set; }

        /// <summary>
        /// 分配给企业（商户）的税号
        /// </summary>
        [XmlElement("tax_no")]
        public string TaxNo { get; set; }
    }
}
