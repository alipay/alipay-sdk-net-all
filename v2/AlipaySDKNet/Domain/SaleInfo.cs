using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// SaleInfo Data Structure.
    /// </summary>
    [Serializable]
    public class SaleInfo : AopObject
    {
        /// <summary>
        /// 商品数量（件）
        /// </summary>
        [XmlElement("item_num")]
        public string ItemNum { get; set; }

        /// <summary>
        /// 销售月份
        /// </summary>
        [XmlElement("month")]
        public string Month { get; set; }

        /// <summary>
        /// 月销售金额（万元）
        /// </summary>
        [XmlElement("sales_amount")]
        public string SalesAmount { get; set; }

        /// <summary>
        /// 月销售金额环比（单位：%）
        /// </summary>
        [XmlElement("sales_amount_mom")]
        public string SalesAmountMom { get; set; }

        /// <summary>
        /// 月销售金额同比（单位：%）
        /// </summary>
        [XmlElement("sales_amount_yoy")]
        public string SalesAmountYoy { get; set; }

        /// <summary>
        /// 月销量（件）
        /// </summary>
        [XmlElement("sales_volume")]
        public string SalesVolume { get; set; }
    }
}
