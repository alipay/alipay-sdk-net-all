using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// VoucherResultInfo Data Structure.
    /// </summary>
    [Serializable]
    public class VoucherResultInfo : AopObject
    {
        /// <summary>
        /// 券关联发送订单唯一标识
        /// </summary>
        [XmlElement("order_id")]
        public string OrderId { get; set; }

        /// <summary>
        /// 券发送关联订单的信息，用于告知用户是否进行后续处理
        /// </summary>
        [XmlElement("order_result")]
        public string OrderResult { get; set; }

        /// <summary>
        /// 订单状态
        /// </summary>
        [XmlElement("order_status")]
        public string OrderStatus { get; set; }

        /// <summary>
        /// 订单发生时间
        /// </summary>
        [XmlElement("order_time")]
        public string OrderTime { get; set; }

        /// <summary>
        /// 券金额，单位分
        /// </summary>
        [XmlElement("voucher_amount")]
        public long VoucherAmount { get; set; }

        /// <summary>
        /// 券唯一标识
        /// </summary>
        [XmlElement("voucher_id")]
        public string VoucherId { get; set; }
    }
}
