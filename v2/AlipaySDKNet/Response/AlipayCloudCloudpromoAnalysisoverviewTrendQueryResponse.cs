using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCloudCloudpromoAnalysisoverviewTrendQueryResponse.
    /// </summary>
    public class AlipayCloudCloudpromoAnalysisoverviewTrendQueryResponse : AopResponse
    {
        /// <summary>
        /// 经营概况总览接口返回数据
        /// </summary>
        [XmlElement("result")]
        public OpenApiOperationalAnalysisResult Result { get; set; }
    }
}
