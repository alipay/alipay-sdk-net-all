using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCloudCloudpromoAnalysistrafficSourcechannelsQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCloudCloudpromoAnalysistrafficSourcechannelsQueryModel : AopObject
    {
        /// <summary>
        /// 经营分析、经营概况模块公用入参 此接口只需要通用入参里的： bizDate、startDate、p_f、timeWindow
        /// </summary>
        [XmlElement("common_request")]
        public OpenApiAnalysisCommonRequest CommonRequest { get; set; }
    }
}
