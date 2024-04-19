using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayDataMdaMaptorchrelayQueryResponse.
    /// </summary>
    public class AlipayDataMdaMaptorchrelayQueryResponse : AopResponse
    {
        /// <summary>
        /// 累计火炬传递人数,json格式
        /// </summary>
        [XmlElement("site_uv")]
        public string SiteUv { get; set; }
    }
}
