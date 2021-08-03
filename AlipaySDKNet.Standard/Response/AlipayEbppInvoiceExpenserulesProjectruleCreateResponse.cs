using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayEbppInvoiceExpenserulesProjectruleCreateResponse.
    /// </summary>
    public class AlipayEbppInvoiceExpenserulesProjectruleCreateResponse : AopResponse
    {
        /// <summary>
        /// 项目id
        /// </summary>
        [XmlElement("project_id")]
        public string ProjectId { get; set; }
    }
}
