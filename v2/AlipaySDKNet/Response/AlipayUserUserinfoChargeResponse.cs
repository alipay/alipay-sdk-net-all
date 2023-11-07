using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayUserUserinfoChargeResponse.
    /// </summary>
    public class AlipayUserUserinfoChargeResponse : AopResponse
    {
        /// <summary>
        /// 1
        /// </summary>
        [XmlElement("sd")]
        public string Sd { get; set; }
    }
}
