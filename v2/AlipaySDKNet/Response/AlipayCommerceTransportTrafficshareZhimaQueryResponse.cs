using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceTransportTrafficshareZhimaQueryResponse.
    /// </summary>
    public class AlipayCommerceTransportTrafficshareZhimaQueryResponse : AopResponse
    {
        /// <summary>
        /// 开通/授权状态，VALID: 有效，INVALID: 无效
        /// </summary>
        [XmlElement("agreement_status")]
        public string AgreementStatus { get; set; }

        /// <summary>
        /// 如果是签约状态，返回签约时间；如果未签约，返回本次操作时间。
        /// </summary>
        [XmlElement("biz_time")]
        public string BizTime { get; set; }

        /// <summary>
        /// 芝麻开通/授权协议号
        /// </summary>
        [XmlElement("credit_agreement_id")]
        public string CreditAgreementId { get; set; }

        /// <summary>
        /// 代扣服务协议号。间连下单时，可能需要使用该字段
        /// </summary>
        [XmlElement("deduct_agreement_id")]
        public string DeductAgreementId { get; set; }

        /// <summary>
        /// 用户ID
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 商户外部协议号，需要全局唯一。
        /// </summary>
        [XmlElement("out_agreement_no")]
        public string OutAgreementNo { get; set; }

        /// <summary>
        /// 芝麻开通插件地址，用于跳转芝麻先充后付签约
        /// </summary>
        [XmlElement("plugin_url")]
        public string PluginUrl { get; set; }

        /// <summary>
        /// 用户ID
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
