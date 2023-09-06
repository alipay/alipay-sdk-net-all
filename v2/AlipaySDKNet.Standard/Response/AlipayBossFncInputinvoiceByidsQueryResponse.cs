using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayBossFncInputinvoiceByidsQueryResponse.
    /// </summary>
    public class AlipayBossFncInputinvoiceByidsQueryResponse : AopResponse
    {
        /// <summary>
        /// 发票查询结果
        /// </summary>
        [XmlElement("result_set")]
        public InputInvoiceQueryResponse ResultSet { get; set; }
    }
}
