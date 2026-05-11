using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceRentOrderDispatchConfirmModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceRentOrderDispatchConfirmModel : AopObject
    {
        /// <summary>
        /// 买家支付宝用户id
        /// </summary>
        [XmlElement("buyer_id")]
        public string BuyerId { get; set; }

        /// <summary>
        /// 买家支付宝用户id
        /// </summary>
        [XmlElement("buyer_open_id")]
        public string BuyerOpenId { get; set; }

        /// <summary>
        /// 操作类型
        /// </summary>
        [XmlElement("operation_type")]
        public string OperationType { get; set; }

        /// <summary>
        /// 原因描述
        /// </summary>
        [XmlElement("reason_desc")]
        public string ReasonDesc { get; set; }

        /// <summary>
        /// 租赁派单ID，唯一标识一次派单请求
        /// </summary>
        [XmlElement("rent_dispatch_id")]
        public string RentDispatchId { get; set; }
    }
}
