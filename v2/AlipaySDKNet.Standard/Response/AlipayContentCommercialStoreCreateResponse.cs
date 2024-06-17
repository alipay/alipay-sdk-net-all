using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayContentCommercialStoreCreateResponse.
    /// </summary>
    public class AlipayContentCommercialStoreCreateResponse : AopResponse
    {
        /// <summary>
        /// 业务ID
        /// </summary>
        [XmlElement("id")]
        public string Id { get; set; }
    }
}
