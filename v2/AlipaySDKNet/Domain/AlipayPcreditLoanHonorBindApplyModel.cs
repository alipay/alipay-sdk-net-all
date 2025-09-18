using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayPcreditLoanHonorBindApplyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayPcreditLoanHonorBindApplyModel : AopObject
    {
        /// <summary>
        /// 协议咨询id
        /// </summary>
        [XmlElement("agreement_consult_serial_no")]
        public string AgreementConsultSerialNo { get; set; }

        /// <summary>
        /// 支付宝用户id
        /// </summary>
        [XmlElement("alipay_user_id")]
        public string AlipayUserId { get; set; }

        /// <summary>
        /// 联合建模模型分 (Map< key, value>的 json字符串)
        /// </summary>
        [XmlElement("api_model_score_map")]
        public string ApiModelScoreMap { get; set; }

        /// <summary>
        /// 用户标签 (Map< key, value>的 json字符串)
        /// </summary>
        [XmlElement("api_user_tag_map")]
        public string ApiUserTagMap { get; set; }

        /// <summary>
        /// 渠道用户id
        /// </summary>
        [XmlElement("channel_customer_id")]
        public string ChannelCustomerId { get; set; }

        /// <summary>
        /// 用于标记支付宝用户在应用下的唯一标识
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 外部traceId
        /// </summary>
        [XmlElement("out_trace_id")]
        public string OutTraceId { get; set; }

        /// <summary>
        /// SL_PD_SALE_CODE-HONOR
        /// </summary>
        [XmlElement("product_code")]
        public string ProductCode { get; set; }

        /// <summary>
        /// 请求源
        /// </summary>
        [XmlElement("request_source")]
        public string RequestSource { get; set; }

        /// <summary>
        /// 大安全风控信息
        /// </summary>
        [XmlElement("risk_info")]
        public string RiskInfo { get; set; }

        /// <summary>
        /// 核身回调url
        /// </summary>
        [XmlElement("verify_callback_url")]
        public string VerifyCallbackUrl { get; set; }
    }
}
