using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceEcRecyclinginvoiceItemModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceEcRecyclinginvoiceItemModifyModel : AopObject
    {
        /// <summary>
        /// 该企业（商户）成功新增的商品ID
        /// </summary>
        [XmlElement("company_item_id")]
        public string CompanyItemId { get; set; }

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
        /// 根据企业（商户）所开通的产品查询该产品ID
        /// </summary>
        [XmlElement("product_id")]
        public string ProductId { get; set; }

        /// <summary>
        /// 企业（商户）的税号
        /// </summary>
        [XmlElement("tax_no")]
        public string TaxNo { get; set; }
    }
}
