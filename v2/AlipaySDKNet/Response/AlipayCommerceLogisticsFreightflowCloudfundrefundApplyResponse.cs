using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceLogisticsFreightflowCloudfundrefundApplyResponse.
    /// </summary>
    public class AlipayCommerceLogisticsFreightflowCloudfundrefundApplyResponse : AopResponse
    {
        /// <summary>
        /// 退款业务流水号
        /// </summary>
        [XmlElement("biz_no")]
        public string BizNo { get; set; }

        /// <summary>
        /// mode为网商银行时： 收银台创单完成后响应参数中的order_no参数值
        /// </summary>
        [XmlElement("cloud_fund_order_no")]
        public string CloudFundOrderNo { get; set; }

        /// <summary>
        /// 退款付方id，即原支付单收方  如果是商户，则填入merchantId； 如果是平台，则填入isvOrgId； 如果是子户，则填入子户外标(子户号)
        /// </summary>
        [XmlElement("participant_id")]
        public string ParticipantId { get; set; }

        /// <summary>
        /// 退款付方类型，即原支付单收方
        /// </summary>
        [XmlElement("participant_type")]
        public string ParticipantType { get; set; }

        /// <summary>
        /// 退款申请受理信息
        /// </summary>
        [XmlElement("refund_apply_msg")]
        public string RefundApplyMsg { get; set; }

        /// <summary>
        /// 退款申请受理状态
        /// </summary>
        [XmlElement("refund_apply_status")]
        public string RefundApplyStatus { get; set; }

        /// <summary>
        /// 退款订单号
        /// </summary>
        [XmlElement("refund_order_no")]
        public string RefundOrderNo { get; set; }
    }
}
