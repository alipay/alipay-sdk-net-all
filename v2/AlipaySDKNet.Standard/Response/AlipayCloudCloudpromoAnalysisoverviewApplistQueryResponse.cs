using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCloudCloudpromoAnalysisoverviewApplistQueryResponse.
    /// </summary>
    public class AlipayCloudCloudpromoAnalysisoverviewApplistQueryResponse : AopResponse
    {
        /// <summary>
        /// 经营概况小程序列表接口返回数据结果
        /// </summary>
        [XmlElement("results")]
        public OpenApiOperationalAnalysisResult Results { get; set; }
    }
}
