using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayTradeScenepayTokenExchangeResponse.
    /// </summary>
    public class AlipayTradeScenepayTokenExchangeResponse : AopResponse
    {
        /// <summary>
        /// 经过场景支付凭证交换出的预期码值
        /// </summary>
        [XmlElement("scene_pay_code")]
        public ScenePayCode ScenePayCode { get; set; }
    }
}
