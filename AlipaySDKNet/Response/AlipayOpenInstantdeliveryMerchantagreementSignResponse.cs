using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenInstantdeliveryMerchantagreementSignResponse.
    /// </summary>
    public class AlipayOpenInstantdeliveryMerchantagreementSignResponse : AopResponse
    {
        /// <summary>
        /// 授权二维码的url, 必须用传入的uid进行扫码
        /// </summary>
        [XmlElement("sign_url")]
        public string SignUrl { get; set; }
    }
}
