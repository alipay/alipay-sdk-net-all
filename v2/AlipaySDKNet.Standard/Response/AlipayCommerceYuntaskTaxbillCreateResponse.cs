using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceYuntaskTaxbillCreateResponse.
    /// </summary>
    public class AlipayCommerceYuntaskTaxbillCreateResponse : AopResponse
    {
        /// <summary>
        /// 吱口令短链接
        /// </summary>
        [XmlElement("sign_url")]
        public string SignUrl { get; set; }
    }
}
