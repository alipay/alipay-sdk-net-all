using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// IndrISVReceiptApplyDTO Data Structure.
    /// </summary>
    [Serializable]
    public class IndrISVReceiptApplyDTO : AopObject
    {
        /// <summary>
        /// 需发送的邮箱地址
        /// </summary>
        [XmlElement("email")]
        public string Email { get; set; }

        /// <summary>
        /// 预订单号
        /// </summary>
        [XmlElement("pre_order_id")]
        public string PreOrderId { get; set; }

        /// <summary>
        /// 凭证类型：PAYMENT支付凭证，REMIT缴费凭证
        /// </summary>
        [XmlElement("receipt_type")]
        public string ReceiptType { get; set; }
    }
}
