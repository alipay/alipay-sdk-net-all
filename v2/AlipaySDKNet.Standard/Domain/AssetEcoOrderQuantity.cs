using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AssetEcoOrderQuantity Data Structure.
    /// </summary>
    [Serializable]
    public class AssetEcoOrderQuantity : AopObject
    {
        /// <summary>
        /// 生态供应商编号
        /// </summary>
        [XmlElement("eco_code")]
        public string EcoCode { get; set; }

        /// <summary>
        /// 生态供应商名称
        /// </summary>
        [XmlElement("eco_name")]
        public string EcoName { get; set; }

        /// <summary>
        /// 有效小蓝环订单数量
        /// </summary>
        [XmlElement("eco_nfc_order_count")]
        public string EcoNfcOrderCount { get; set; }

        /// <summary>
        /// 有效订单数量
        /// </summary>
        [XmlElement("eco_order_count")]
        public string EcoOrderCount { get; set; }

        /// <summary>
        /// 售卖模式
        /// </summary>
        [XmlElement("sales_model")]
        public string SalesModel { get; set; }

        /// <summary>
        /// 统计日期
        /// </summary>
        [XmlElement("statistical_date")]
        public string StatisticalDate { get; set; }
    }
}
