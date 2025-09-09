using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayMarketingBenefitVerifyCreateResponse.
    /// </summary>
    public class AlipayMarketingBenefitVerifyCreateResponse : AopResponse
    {
        /// <summary>
        /// 是否需要核身
        /// </summary>
        [XmlElement("need_verify")]
        public bool NeedVerify { get; set; }

        /// <summary>
        /// 核身口令，只有当需要核身的时候返回
        /// </summary>
        [XmlElement("verify_id")]
        public string VerifyId { get; set; }

        /// <summary>
        /// 核身场景
        /// </summary>
        [XmlElement("verify_scene")]
        public string VerifyScene { get; set; }

        /// <summary>
        /// 核身url,当需要核身的时候返回
        /// </summary>
        [XmlElement("verify_url")]
        public string VerifyUrl { get; set; }
    }
}
