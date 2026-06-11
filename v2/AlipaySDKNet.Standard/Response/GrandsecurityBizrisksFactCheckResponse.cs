using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// GrandsecurityBizrisksFactCheckResponse.
    /// </summary>
    public class GrandsecurityBizrisksFactCheckResponse : AopResponse
    {
        /// <summary>
        /// 流式数据返回
        /// </summary>
        [XmlElement("content")]
        public string Content { get; set; }
    }
}
