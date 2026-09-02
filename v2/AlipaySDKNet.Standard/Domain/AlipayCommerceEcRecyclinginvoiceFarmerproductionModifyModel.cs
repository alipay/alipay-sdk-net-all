using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceEcRecyclinginvoiceFarmerproductionModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceEcRecyclinginvoiceFarmerproductionModifyModel : AopObject
    {
        /// <summary>
        /// 产量记录ID
        /// </summary>
        [XmlElement("farmer_item_id")]
        public string FarmerItemId { get; set; }

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
        /// 有效期截止日期
        /// </summary>
        [XmlElement("sale_end_date")]
        public string SaleEndDate { get; set; }

        /// <summary>
        /// 有效期起始日期
        /// </summary>
        [XmlElement("sale_start_date")]
        public string SaleStartDate { get; set; }
    }
}
