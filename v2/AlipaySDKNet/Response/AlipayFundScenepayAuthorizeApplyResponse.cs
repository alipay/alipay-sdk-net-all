using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayFundScenepayAuthorizeApplyResponse.
    /// </summary>
    public class AlipayFundScenepayAuthorizeApplyResponse : AopResponse
    {
        /// <summary>
        /// 授权申请凭证
        /// </summary>
        [XmlElement("apply_token")]
        public string ApplyToken { get; set; }
    }
}
