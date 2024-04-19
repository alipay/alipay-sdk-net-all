using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipaySecurityDataSssCreateResponse.
    /// </summary>
    public class AlipaySecurityDataSssCreateResponse : AopResponse
    {
        /// <summary>
        /// 区
        /// </summary>
        [XmlElement("c")]
        public string C { get; set; }

        /// <summary>
        /// 区
        /// </summary>
        [XmlElement("c_open_id")]
        public string COpenId { get; set; }
    }
}
