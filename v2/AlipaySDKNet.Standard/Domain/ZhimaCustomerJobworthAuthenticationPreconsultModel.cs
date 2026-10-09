using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ZhimaCustomerJobworthAuthenticationPreconsultModel Data Structure.
    /// </summary>
    [Serializable]
    public class ZhimaCustomerJobworthAuthenticationPreconsultModel : AopObject
    {
        /// <summary>
        /// 身份类型
        /// </summary>
        [XmlElement("identity_type")]
        public string IdentityType { get; set; }

        /// <summary>
        /// 验真订单id
        /// </summary>
        [XmlElement("once_token")]
        public string OnceToken { get; set; }

        /// <summary>
        /// 用户的授权单号，与一次用户授权结果绑定
        /// </summary>
        [XmlElement("out_agreement_no")]
        public string OutAgreementNo { get; set; }

        /// <summary>
        /// 验真精度
        /// </summary>
        [XmlElement("query_type")]
        public string QueryType { get; set; }

        /// <summary>
        /// 商户入驻芝麻的标识
        /// </summary>
        [XmlElement("zm_service_id")]
        public string ZmServiceId { get; set; }
    }
}
