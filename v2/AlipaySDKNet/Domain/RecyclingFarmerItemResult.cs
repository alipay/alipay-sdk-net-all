using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RecyclingFarmerItemResult Data Structure.
    /// </summary>
    [Serializable]
    public class RecyclingFarmerItemResult : AopObject
    {
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
        /// 产粮售卖结束有效期
        /// </summary>
        [XmlElement("sale_end_date")]
        public string SaleEndDate { get; set; }

        /// <summary>
        /// 产粮售卖开始有效期
        /// </summary>
        [XmlElement("sale_start_date")]
        public string SaleStartDate { get; set; }

        /// <summary>
        /// 税收分类编码
        /// </summary>
        [XmlElement("tax_code")]
        public string TaxCode { get; set; }
    }
}
