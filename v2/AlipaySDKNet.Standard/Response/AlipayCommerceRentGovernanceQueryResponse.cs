using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceRentGovernanceQueryResponse.
    /// </summary>
    public class AlipayCommerceRentGovernanceQueryResponse : AopResponse
    {
        /// <summary>
        /// null
        /// </summary>
        [XmlArray("governance_infos")]
        [XmlArrayItem("rent_governance_info_v_o")]
        public List<RentGovernanceInfoVO> GovernanceInfos { get; set; }
    }
}
