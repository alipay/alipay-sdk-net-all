using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RecycleSubOrderAfterSaleCreateVO Data Structure.
    /// </summary>
    [Serializable]
    public class RecycleSubOrderAfterSaleCreateVO : AopObject
    {
        /// <summary>
        /// 售后原因
        /// </summary>
        [XmlElement("after_sale_reason")]
        public string AfterSaleReason { get; set; }

        /// <summary>
        /// 售后类型
        /// </summary>
        [XmlElement("after_sale_type")]
        public string AfterSaleType { get; set; }

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
