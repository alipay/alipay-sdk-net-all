using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCloudCloudpromoAnalysisoverviewPidtrendQueryResponse.
    /// </summary>
    public class AlipayCloudCloudpromoAnalysisoverviewPidtrendQueryResponse : AopResponse
    {
        /// <summary>
        /// 经营概况小程序商家趋势接口返回数据
        /// </summary>
        [XmlElement("results")]
        public OpenApiOperationalAnalysisResult Results { get; set; }
    }
}
