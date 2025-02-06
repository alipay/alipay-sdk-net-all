using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceRentRiskConsultResponse.
    /// </summary>
    public class AlipayCommerceRentRiskConsultResponse : AopResponse
    {
        /// <summary>
        /// null
        /// </summary>
        [XmlArray("risk_infos")]
        [XmlArrayItem("rent_risk_info_v_o")]
        public List<RentRiskInfoVO> RiskInfos { get; set; }
    }
}
