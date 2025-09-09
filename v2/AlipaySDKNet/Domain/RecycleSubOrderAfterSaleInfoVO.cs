using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RecycleSubOrderAfterSaleInfoVO Data Structure.
    /// </summary>
    [Serializable]
    public class RecycleSubOrderAfterSaleInfoVO : AopObject
    {
        /// <summary>
        /// 子售后单号
        /// </summary>
        [XmlElement("sub_after_sales_id")]
        public string SubAfterSalesId { get; set; }

        /// <summary>
        /// 回收子单号
        /// </summary>
        [XmlElement("sub_order_id")]
        public string SubOrderId { get; set; }

        /// <summary>
        /// 商家子单号
        /// </summary>
        [XmlElement("sub_out_order_id")]
        public string SubOutOrderId { get; set; }
    }
}
