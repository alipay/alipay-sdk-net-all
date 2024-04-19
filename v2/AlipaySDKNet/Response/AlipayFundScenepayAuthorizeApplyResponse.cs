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

        /// <summary>
        /// 签约跳转URL，使用此URL跳转至支付宝端内完成签约
        /// </summary>
        [XmlElement("apply_url")]
        public string ApplyUrl { get; set; }
    }
}
