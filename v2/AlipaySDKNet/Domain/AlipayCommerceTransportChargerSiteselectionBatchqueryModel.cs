using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceTransportChargerSiteselectionBatchqueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceTransportChargerSiteselectionBatchqueryModel : AopObject
    {
        /// <summary>
        /// 计算任务编号
        /// </summary>
        [XmlArray("task_ids")]
        [XmlArrayItem("string")]
        public List<string> TaskIds { get; set; }
    }
}
