using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayFundScenepayAuthorizeQueryResponse.
    /// </summary>
    public class AlipayFundScenepayAuthorizeQueryResponse : AopResponse
    {
        /// <summary>
        /// 授权ID
        /// </summary>
        [XmlElement("authorization_id")]
        public string AuthorizationId { get; set; }

        /// <summary>
        /// 已签约则展示签约管理链接
        /// </summary>
        [XmlElement("authorize_manage_url")]
        public string AuthorizeManageUrl { get; set; }

        /// <summary>
        /// 签约平台
        /// </summary>
        [XmlElement("authorize_platform")]
        public string AuthorizePlatform { get; set; }

        /// <summary>
        /// 外部签约号
        /// </summary>
        [XmlElement("out_agreement_no")]
        public string OutAgreementNo { get; set; }

        /// <summary>
        /// NORMAL 正常状态 UNSIGN 未签约或已解约
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
