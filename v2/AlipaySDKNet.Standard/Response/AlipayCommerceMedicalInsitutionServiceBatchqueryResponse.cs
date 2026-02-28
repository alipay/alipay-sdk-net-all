using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceMedicalInsitutionServiceBatchqueryResponse.
    /// </summary>
    public class AlipayCommerceMedicalInsitutionServiceBatchqueryResponse : AopResponse
    {
        /// <summary>
        /// null
        /// </summary>
        [XmlArray("org_operational_metric_list")]
        [XmlArrayItem("org_operational_aggregate_item")]
        public List<OrgOperationalAggregateItem> OrgOperationalMetricList { get; set; }
    }
}
