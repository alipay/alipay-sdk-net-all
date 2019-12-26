using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayDataServiceOpenAnalyzeResponse.
    /// </summary>
    public class AlipayDataServiceOpenAnalyzeResponse : AopResponse
    {
        /// <summary>
        /// 调用返回
        /// </summary>
        [XmlElement("result")]
        public AlipayDataServiceResult Result { get; set; }
    }
}
