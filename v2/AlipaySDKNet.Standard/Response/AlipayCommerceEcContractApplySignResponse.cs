using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceEcContractApplySignResponse.
    /// </summary>
    public class AlipayCommerceEcContractApplySignResponse : AopResponse
    {
        /// <summary>
        /// 签约链接
        /// </summary>
        [XmlElement("url")]
        public string Url { get; set; }
    }
}
