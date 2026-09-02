using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceEcRecyclinginvoiceFarmerproductionCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceEcRecyclinginvoiceFarmerproductionCreateModel : AopObject
    {
        /// <summary>
        /// 农户ID
        /// </summary>
        [XmlElement("farmer_id")]
        public string FarmerId { get; set; }

        /// <summary>
        /// 数量
        /// </summary>
        [XmlElement("item_num")]
        public string ItemNum { get; set; }

        /// <summary>
        /// 单位
        /// </summary>
        [XmlElement("item_unit")]
        public string ItemUnit { get; set; }

        /// <summary>
        /// 有效期止
        /// </summary>
        [XmlElement("sale_end_date")]
        public string SaleEndDate { get; set; }

        /// <summary>
        /// 有效期起
        /// </summary>
        [XmlElement("sale_start_date")]
        public string SaleStartDate { get; set; }

        /// <summary>
        /// 产品税收编码
        /// </summary>
        [XmlElement("tax_code")]
        public string TaxCode { get; set; }
    }
}
