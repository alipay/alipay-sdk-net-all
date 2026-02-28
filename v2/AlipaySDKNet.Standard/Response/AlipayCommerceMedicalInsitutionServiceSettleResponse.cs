using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceMedicalInsitutionServiceSettleResponse.
    /// </summary>
    public class AlipayCommerceMedicalInsitutionServiceSettleResponse : AopResponse
    {
        /// <summary>
        /// null
        /// </summary>
        [XmlArray("org_operational_aggregate_list")]
        [XmlArrayItem("org_operational_aggregate")]
        public List<OrgOperationalAggregate> OrgOperationalAggregateList { get; set; }
    }
}
