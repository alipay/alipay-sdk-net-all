using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// KoubeiSalesLeadsSaleleadsCreateResponse.
    /// </summary>
    public class KoubeiSalesLeadsSaleleadsCreateResponse : AopResponse
    {
        /// <summary>
        /// 生成的销售LeadsId
        /// </summary>
        [XmlElement("leads_id")]
        public string LeadsId { get; set; }
    }
}
