using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayPcreditHuabeiSubsidyConsultModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayPcreditHuabeiSubsidyConsultModel : AopObject
    {
        /// <summary>
        /// 贴息咨询请求参数
        /// </summary>
        [XmlArray("subsidy_aggregated_req_models")]
        [XmlArrayItem("subsidy_simple_request")]
        public List<SubsidySimpleRequest> SubsidyAggregatedReqModels { get; set; }
    }
}
