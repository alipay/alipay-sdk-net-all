using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceInsuranceTpabilldataSyncResponse.
    /// </summary>
    public class AlipayCommerceInsuranceTpabilldataSyncResponse : AopResponse
    {
        /// <summary>
        /// 100
        /// </summary>
        [XmlElement("num")]
        public long Num { get; set; }
    }
}
