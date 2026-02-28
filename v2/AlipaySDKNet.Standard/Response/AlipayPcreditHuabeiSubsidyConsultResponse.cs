using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayPcreditHuabeiSubsidyConsultResponse.
    /// </summary>
    public class AlipayPcreditHuabeiSubsidyConsultResponse : AopResponse
    {
        /// <summary>
        /// 贴息咨询响应结果
        /// </summary>
        [XmlArray("subsidy_aggregated_resp_models")]
        [XmlArrayItem("subsidy_simple_response")]
        public List<SubsidySimpleResponse> SubsidyAggregatedRespModels { get; set; }
    }
}
