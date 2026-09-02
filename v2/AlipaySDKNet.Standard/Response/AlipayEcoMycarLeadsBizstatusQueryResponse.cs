using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayEcoMycarLeadsBizstatusQueryResponse.
    /// </summary>
    public class AlipayEcoMycarLeadsBizstatusQueryResponse : AopResponse
    {
        /// <summary>
        /// 线索业务状态
        /// </summary>
        [XmlElement("leads_biz_status")]
        public string LeadsBizStatus { get; set; }
    }
}
