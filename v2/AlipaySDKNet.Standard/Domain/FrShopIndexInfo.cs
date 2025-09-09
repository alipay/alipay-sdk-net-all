using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// FrShopIndexInfo Data Structure.
    /// </summary>
    [Serializable]
    public class FrShopIndexInfo : AopObject
    {
        /// <summary>
        /// 数据月份
        /// </summary>
        [XmlElement("month")]
        public string Month { get; set; }

        /// <summary>
        /// 含数据月份在内的商家过去12个月销售金额(万元)
        /// </summary>
        [XmlElement("sales_amount_12_m")]
        public string SalesAmount12M { get; set; }

        /// <summary>
        /// 商家当月销售金额(万元)
        /// </summary>
        [XmlElement("sales_amount_1_m")]
        public string SalesAmount1M { get; set; }

        /// <summary>
        /// 含数据月份在内的商家过去3个月销售金额(万元)
        /// </summary>
        [XmlElement("sales_amount_3_m")]
        public string SalesAmount3M { get; set; }

        /// <summary>
        /// 含数据月份在内的商家过去6个月销售金额(万元)
        /// </summary>
        [XmlElement("sales_amount_6_m")]
        public string SalesAmount6M { get; set; }

        /// <summary>
        /// 商家月销售金额环比(%)
        /// </summary>
        [XmlElement("sales_amount_mom")]
        public string SalesAmountMom { get; set; }

        /// <summary>
        /// 历史12个月月销售金额环比(%)
        /// </summary>
        [XmlElement("sales_amount_p_12_m_mom")]
        public string SalesAmountP12MMom { get; set; }

        /// <summary>
        /// 历史12个月月销售金额同比(%)
        /// </summary>
        [XmlElement("sales_amount_p_12_m_yoy")]
        public string SalesAmountP12MYoy { get; set; }

        /// <summary>
        /// 历史3个月月销售金额环比(%)
        /// </summary>
        [XmlElement("sales_amount_p_3_m_mom")]
        public string SalesAmountP3MMom { get; set; }

        /// <summary>
        /// 历史3个月月销售金额同比(%)
        /// </summary>
        [XmlElement("sales_amount_p_3_m_yoy")]
        public string SalesAmountP3MYoy { get; set; }

        /// <summary>
        /// 历史6个月月销售金额环比(%)
        /// </summary>
        [XmlElement("sales_amount_p_6_m_mom")]
        public string SalesAmountP6MMom { get; set; }

        /// <summary>
        /// 历史6个月月销售金额同比(%)
        /// </summary>
        [XmlElement("sales_amount_p_6_m_yoy")]
        public string SalesAmountP6MYoy { get; set; }

        /// <summary>
        /// 商家月销售金额同比(%)
        /// </summary>
        [XmlElement("sales_amount_yoy")]
        public string SalesAmountYoy { get; set; }
    }
}
