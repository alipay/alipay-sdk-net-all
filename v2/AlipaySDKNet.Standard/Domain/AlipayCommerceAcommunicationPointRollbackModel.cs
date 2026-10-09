using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceAcommunicationPointRollbackModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceAcommunicationPointRollbackModel : AopObject
    {
        /// <summary>
        /// 用于标记支付宝用户在应用下的唯一标识
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 等待回滚订单的状态
        /// </summary>
        [XmlElement("order_type")]
        public string OrderType { get; set; }

        /// <summary>
        /// 本次调用的外部订单号
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 等待回滚的积分订单ID
        /// </summary>
        [XmlElement("to_roll_back_order_id")]
        public string ToRollBackOrderId { get; set; }

        /// <summary>
        /// 等待回滚的外部订单号，需要和to_roll_back_order_id是同一个订单
        /// </summary>
        [XmlElement("to_roll_back_out_biz_no")]
        public string ToRollBackOutBizNo { get; set; }

        /// <summary>
        /// 支付宝用户的userId。
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
