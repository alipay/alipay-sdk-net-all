using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// ZhimaCreditPeZmgoAgreementQueryResponse.
    /// </summary>
    public class ZhimaCreditPeZmgoAgreementQueryResponse : AopResponse
    {
        /// <summary>
        /// 支付宝系统中用以唯一标识用户签约记录的编号，即花芝轻会员协议号。
        /// </summary>
        [XmlElement("agreement_id")]
        public string AgreementId { get; set; }

        /// <summary>
        /// 协议名称
        /// </summary>
        [XmlElement("agreement_name")]
        public string AgreementName { get; set; }

        /// <summary>
        /// 协议状态。Y表示状态有效，P表示状态失效中，N表示状态已失效
        /// </summary>
        [XmlElement("agreement_status")]
        public string AgreementStatus { get; set; }

        /// <summary>
        /// 支付宝用户userId
        /// </summary>
        [XmlElement("alipay_user_id")]
        public string AlipayUserId { get; set; }

        /// <summary>
        /// 代表签约芝麻GO所属业务类型
        /// </summary>
        [XmlElement("biz_type")]
        public string BizType { get; set; }

        /// <summary>
        /// 该条芝麻GO协议签约时间
        /// </summary>
        [XmlElement("sign_time")]
        public string SignTime { get; set; }

        /// <summary>
        /// 该芝麻GO协议开始时间
        /// </summary>
        [XmlElement("start_time")]
        public string StartTime { get; set; }
    }
}
