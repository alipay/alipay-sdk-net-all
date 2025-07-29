using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceMedicalCardExchangeCheckResponse.
    /// </summary>
    public class AlipayCommerceMedicalCardExchangeCheckResponse : AopResponse
    {
        /// <summary>
        /// 该手机号已开通过支付宝健康会员
        /// </summary>
        [XmlElement("content")]
        public string Content { get; set; }

        /// <summary>
        /// 是否使用
        /// </summary>
        [XmlElement("used")]
        public bool Used { get; set; }
    }
}
