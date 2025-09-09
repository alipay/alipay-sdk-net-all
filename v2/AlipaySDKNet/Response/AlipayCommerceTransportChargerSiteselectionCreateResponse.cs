using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceTransportChargerSiteselectionCreateResponse.
    /// </summary>
    public class AlipayCommerceTransportChargerSiteselectionCreateResponse : AopResponse
    {
        /// <summary>
        /// 任务编号
        /// </summary>
        [XmlElement("task_id")]
        public string TaskId { get; set; }
    }
}
