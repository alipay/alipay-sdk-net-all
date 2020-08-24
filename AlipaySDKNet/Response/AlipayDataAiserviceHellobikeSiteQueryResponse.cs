using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayDataAiserviceHellobikeSiteQueryResponse.
    /// </summary>
    public class AlipayDataAiserviceHellobikeSiteQueryResponse : AopResponse
    {
        /// <summary>
        /// 结果
        /// </summary>
        [XmlElement("result")]
        public SiteResult Result { get; set; }
    }
}
