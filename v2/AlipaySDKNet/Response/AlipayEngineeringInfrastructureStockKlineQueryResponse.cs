using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayEngineeringInfrastructureStockKlineQueryResponse.
    /// </summary>
    public class AlipayEngineeringInfrastructureStockKlineQueryResponse : AopResponse
    {
        /// <summary>
        /// 业务数据，类型为ObjKLineDTOWrapper
        /// </summary>
        [XmlElement("data")]
        public ObjKLineDTOWrapper Data { get; set; }
    }
}
