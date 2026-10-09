using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// KoubeiSalesLeadsShopleadsCreateResponse.
    /// </summary>
    public class KoubeiSalesLeadsShopleadsCreateResponse : AopResponse
    {
        /// <summary>
        /// 导入成功的LeadsId
        /// </summary>
        [XmlElement("leads_id")]
        public string LeadsId { get; set; }
    }
}
