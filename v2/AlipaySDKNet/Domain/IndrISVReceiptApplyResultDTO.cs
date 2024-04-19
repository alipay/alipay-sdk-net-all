using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// IndrISVReceiptApplyResultDTO Data Structure.
    /// </summary>
    [Serializable]
    public class IndrISVReceiptApplyResultDTO : AopObject
    {
        /// <summary>
        /// SUCCESS: 申请成功 PROCESS_FAIL: 申请失败 ORDER_NOT_EXIST: 订单不存在 ORDER_STATE_INVALID: 当前订单状态不支持申请该类型凭证 UNKNOWN_EXCEPTION: 系统异常
        /// </summary>
        [XmlElement("apply_result_code")]
        public string ApplyResultCode { get; set; }

        /// <summary>
        /// 申请结果描述
        /// </summary>
        [XmlElement("apply_result_message")]
        public string ApplyResultMessage { get; set; }

        /// <summary>
        /// 发送凭证的邮箱地址
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
