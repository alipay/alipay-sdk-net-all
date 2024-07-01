using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceTransportChargerSiteselectionBatchqueryResponse.
    /// </summary>
    public class AlipayCommerceTransportChargerSiteselectionBatchqueryResponse : AopResponse
    {
        /// <summary>
        /// 任务列表
        /// </summary>
        [XmlArray("tasks")]
        [XmlArrayItem("site_selection_task")]
        public List<SiteSelectionTask> Tasks { get; set; }
    }
}
