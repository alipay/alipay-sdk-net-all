using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceOperationPlanetsolutioncenterIsvBindResponse.
    /// </summary>
    public class AlipayCommerceOperationPlanetsolutioncenterIsvBindResponse : AopResponse
    {
        /// <summary>
        /// 是否成功
        /// </summary>
        [XmlElement("response")]
        public string Response { get; set; }
    }
}
