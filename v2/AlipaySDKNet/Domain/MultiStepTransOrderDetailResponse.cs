using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MultiStepTransOrderDetailResponse Data Structure.
    /// </summary>
    [Serializable]
    public class MultiStepTransOrderDetailResponse : AopObject
    {
        /// <summary>
        /// 转账额度 单位：元
        /// </summary>
        [XmlElement("amount")]
        public string Amount { get; set; }

        /// <summary>
        /// 支付时间 格式：yyyy-MM-dd HH:mm:ss
        /// </summary>
        [XmlElement("gmt_pay")]
        public string GmtPay { get; set; }

        /// <summary>
        /// 用于标记支付宝用户在应用下的唯一标识
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 订单ID
        /// </summary>
        [XmlElement("order_id")]
        public string OrderId { get; set; }

        /// <summary>
        /// 订单执行顺序 单位：个
        /// </summary>
        [XmlElement("order_seq")]
        public long OrderSeq { get; set; }

        /// <summary>
        /// 订单标题
        /// </summary>
        [XmlElement("order_title")]
        public string OrderTitle { get; set; }

        /// <summary>
        /// 外部幂等号
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 收款方信息
        /// </summary>
        [XmlElement("payee_info")]
        public MultiStepTransferParticipant PayeeInfo { get; set; }

        /// <summary>
        /// 付款方信息
        /// </summary>
        [XmlElement("payer_info")]
        public MultiStepTransferParticipant PayerInfo { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        [XmlElement("remark")]
        public string Remark { get; set; }

        /// <summary>
        /// 请求方ID
        /// </summary>
        [XmlElement("request_user_id")]
        public string RequestUserId { get; set; }

        /// <summary>
        /// 单据交易状态
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
