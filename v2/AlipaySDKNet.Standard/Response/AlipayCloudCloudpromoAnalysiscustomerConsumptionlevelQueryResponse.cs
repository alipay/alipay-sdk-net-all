using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCloudCloudpromoAnalysiscustomerConsumptionlevelQueryResponse.
    /// </summary>
    public class AlipayCloudCloudpromoAnalysiscustomerConsumptionlevelQueryResponse : AopResponse
    {
        /// <summary>
        /// 数据结果
        /// </summary>
        [XmlElement("results")]
        public OpenApiCustomerAnalysisTradeLevelResult Results { get; set; }
    }
}
