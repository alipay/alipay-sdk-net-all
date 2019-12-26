using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayBossFncInvoiceApplyResponse.
    /// </summary>
    public class AlipayBossFncInvoiceApplyResponse : AopResponse
    {
        /// <summary>
        /// 开票申请ID，唯一性ID
        /// </summary>
        [XmlElement("result_set")]
        public string ResultSet { get; set; }
    }
}
