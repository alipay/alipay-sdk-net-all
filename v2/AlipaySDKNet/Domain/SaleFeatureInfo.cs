using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// SaleFeatureInfo Data Structure.
    /// </summary>
    [Serializable]
    public class SaleFeatureInfo : AopObject
    {
        /// <summary>
        /// 月销售金额是否大于0 （1：是，0：否）
        /// </summary>
        [XmlElement("is_sales_amount_a")]
        public string IsSalesAmountA { get; set; }

        /// <summary>
        /// 月销售金额是否大于1万
        /// </summary>
        [XmlElement("is_sales_amount_b")]
        public string IsSalesAmountB { get; set; }

        /// <summary>
        /// 月销售金额是否大于10万
        /// </summary>
        [XmlElement("is_sales_amount_c")]
        public string IsSalesAmountC { get; set; }

        /// <summary>
        /// 月销售金额是否大于100万
        /// </summary>
        [XmlElement("is_sales_amount_d")]
        public string IsSalesAmountD { get; set; }

        /// <summary>
        /// 月销量是否大于0（1：是，0：否）
        /// </summary>
        [XmlElement("is_sales_volume_a")]
        public string IsSalesVolumeA { get; set; }

        /// <summary>
        /// 月销量是否大于10件（1：是，0：否）
        /// </summary>
        [XmlElement("is_sales_volume_b")]
        public string IsSalesVolumeB { get; set; }

        /// <summary>
        /// 月销量是否大于100件（1：是，0：否）
        /// </summary>
        [XmlElement("is_sales_volume_c")]
        public string IsSalesVolumeC { get; set; }

        /// <summary>
        /// 月销量是否大于1000件（1：是，0：否）
        /// </summary>
        [XmlElement("is_sales_volume_d")]
        public string IsSalesVolumeD { get; set; }

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
        /// 月销售金额环比（单位：%）
        /// </summary>
        [XmlElement("sales_amount_mom")]
        public string SalesAmountMom { get; set; }

        /// <summary>
        /// 销售金额同比（单位：%）
        /// </summary>
        [XmlElement("sales_amount_yoy")]
        public string SalesAmountYoy { get; set; }
    }
}
