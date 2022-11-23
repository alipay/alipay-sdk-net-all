using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipaySecurityProdRisktaskFinishinfoQueryResponse.
    /// </summary>
    public class AlipaySecurityProdRisktaskFinishinfoQueryResponse : AopResponse
    {
        /// <summary>
        /// finish_type 结案类型 finishLabel 结案标签
        /// </summary>
        [XmlArray("finish_info_list")]
        [XmlArrayItem("risk_finish_info")]
        public List<RiskFinishInfo> FinishInfoList { get; set; }
    }
}
