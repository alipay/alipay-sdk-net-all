using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayPcreditLoanHonorCreditApplyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayPcreditLoanHonorCreditApplyModel : AopObject
    {
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
        [XmlElement("api_usr_tag_map")]
        public string ApiUsrTagMap { get; set; }

        /// <summary>
        /// 申请单号
        /// </summary>
        [XmlElement("apply_no")]
        public string ApplyNo { get; set; }

        /// <summary>
        /// 申请时间
        /// </summary>
        [XmlElement("apply_time")]
        public string ApplyTime { get; set; }

        /// <summary>
        /// 渠道用户id
        /// </summary>
        [XmlElement("channel_customer_id")]
        public string ChannelCustomerId { get; set; }

        /// <summary>
        /// 授信方案咨询时返回的号，授信申请时依赖。
        /// </summary>
        [XmlElement("credit_consult_serial_no")]
        public string CreditConsultSerialNo { get; set; }

        /// <summary>
        /// 用于标记支付宝用户在应用下的唯一标识
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 渠道traceid
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
    }
}
