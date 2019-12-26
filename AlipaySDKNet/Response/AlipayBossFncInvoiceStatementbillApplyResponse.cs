using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayBossFncInvoiceStatementbillApplyResponse.
    /// </summary>
    public class AlipayBossFncInvoiceStatementbillApplyResponse : AopResponse
    {
        /// <summary>
        /// 开票申请ID，唯一性ID
        /// </summary>
        [XmlElement("result_set")]
        public string ResultSet { get; set; }
    }
}
