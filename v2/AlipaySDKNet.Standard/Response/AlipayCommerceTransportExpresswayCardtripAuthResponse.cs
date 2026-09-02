using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceTransportExpresswayCardtripAuthResponse.
    /// </summary>
    public class AlipayCommerceTransportExpresswayCardtripAuthResponse : AopResponse
    {
        /// <summary>
        /// 支付宝授权号
        /// </summary>
        [XmlElement("auth_biz_no")]
        public string AuthBizNo { get; set; }

        /// <summary>
        /// 资格校验完成后返回认证token
        /// </summary>
        [XmlElement("biz_token")]
        public string BizToken { get; set; }
    }
}
