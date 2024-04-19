using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayUserAccountLoginTokenVerifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayUserAccountLoginTokenVerifyModel : AopObject
    {
        /// <summary>
        /// 扩展参数
        /// </summary>
        [XmlElement("extra_params")]
        public VerifyExtraParams ExtraParams { get; set; }

        /// <summary>
        /// 二方登录token
        /// </summary>
        [XmlElement("login_token")]
        public string LoginToken { get; set; }

        /// <summary>
        /// 渠道来源
        /// </summary>
        [XmlElement("source")]
        public string Source { get; set; }
    }
}
