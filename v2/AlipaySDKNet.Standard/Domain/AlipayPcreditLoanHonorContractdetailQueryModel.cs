using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayPcreditLoanHonorContractdetailQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayPcreditLoanHonorContractdetailQueryModel : AopObject
    {
        /// <summary>
        /// 支付宝用户id
        /// </summary>
        [XmlElement("alipay_user_id")]
        public string AlipayUserId { get; set; }

        /// <summary>
        /// 渠道用户id
        /// </summary>
        [XmlElement("channel_customer_id")]
        public string ChannelCustomerId { get; set; }

        /// <summary>
        /// 合同 Id，传该字段返回单条协议信息
        /// </summary>
        [XmlElement("contract_id")]
        public string ContractId { get; set; }

        /// <summary>
        /// 渠道侧支用申请单号
        /// </summary>
        [XmlElement("loan_apply_no")]
        public string LoanApplyNo { get; set; }

        /// <summary>
        /// 用于标记支付宝用户在应用下的唯一标识
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 外部traceid
        /// </summary>
        [XmlElement("out_trace_id")]
        public string OutTraceId { get; set; }

        /// <summary>
        /// 待签约协议需要传入 1、签约阶段-协议列表咨询的id 2、支用阶段-试算结果id
        /// </summary>
        [XmlElement("pre_consult_id")]
        public string PreConsultId { get; set; }

        /// <summary>
        /// 请求来源
        /// </summary>
        [XmlElement("request_source")]
        public string RequestSource { get; set; }

        /// <summary>
        /// 协议类型, 1-URL (废弃) ,   2-html  , 3-URL(支持返回多份协议), 4-pdf
        /// </summary>
        [XmlElement("type")]
        public long Type { get; set; }
    }
}
