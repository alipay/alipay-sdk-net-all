using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayPcreditLoanHonorUserbindCheckModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayPcreditLoanHonorUserbindCheckModel : AopObject
    {
        /// <summary>
        /// 渠道用户id
        /// </summary>
        [XmlElement("channel_customer_id")]
        public string ChannelCustomerId { get; set; }

        /// <summary>
        /// 证件号
        /// </summary>
        [XmlElement("ctf_code")]
        public string CtfCode { get; set; }

        /// <summary>
        /// 手机号
        /// </summary>
        [XmlElement("mobile_no")]
        public string MobileNo { get; set; }

        /// <summary>
        /// 外部traceId
        /// </summary>
        [XmlElement("out_trace_id")]
        public string OutTraceId { get; set; }

        /// <summary>
        /// 姓名
        /// </summary>
        [XmlElement("real_name")]
        public string RealName { get; set; }

        /// <summary>
        /// 请求源
        /// </summary>
        [XmlElement("request_source")]
        public string RequestSource { get; set; }
    }
}
