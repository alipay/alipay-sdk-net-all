using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// BatchDepositOrderOpenResult Data Structure.
    /// </summary>
    [Serializable]
    public class BatchDepositOrderOpenResult : AopObject
    {
        /// <summary>
        /// 订单金额(单位：元)
        /// </summary>
        [XmlElement("order_amount")]
        public string OrderAmount { get; set; }

        /// <summary>
        /// 订单ID
        /// </summary>
        [XmlElement("order_id")]
        public string OrderId { get; set; }

        /// <summary>
        /// 自然人名称
        /// </summary>
        [XmlElement("seller_name")]
        public string SellerName { get; set; }
    }
}
