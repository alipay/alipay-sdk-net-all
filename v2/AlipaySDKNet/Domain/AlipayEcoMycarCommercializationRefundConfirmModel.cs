using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayEcoMycarCommercializationRefundConfirmModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEcoMycarCommercializationRefundConfirmModel : AopObject
    {
        /// <summary>
        /// 异步请求编号，异步返回退款确认结果时必传
        /// </summary>
        [XmlElement("async_request_no")]
        public string AsyncRequestNo { get; set; }

        /// <summary>
        /// 原因，审批不通过时需要填写
        /// </summary>
        [XmlElement("audit_reason")]
        public string AuditReason { get; set; }

        /// <summary>
        /// 审批状态
        /// </summary>
        [XmlElement("audit_status")]
        public string AuditStatus { get; set; }

        /// <summary>
        /// 支付宝侧订单id
        /// </summary>
        [XmlElement("order_id")]
        public string OrderId { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }

        /// <summary>
        /// 用户开放平台id
        /// </summary>
        [XmlElement("user_open_id")]
        public string UserOpenId { get; set; }
    }
}
