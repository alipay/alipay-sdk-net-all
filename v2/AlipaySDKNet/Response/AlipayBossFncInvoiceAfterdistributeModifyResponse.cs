using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayBossFncInvoiceAfterdistributeModifyResponse.
    /// </summary>
    public class AlipayBossFncInvoiceAfterdistributeModifyResponse : AopResponse
    {
        /// <summary>
        /// 修改返回结果
        /// </summary>
        [XmlElement("result_set")]
        public InputInvoiceResponse ResultSet { get; set; }
    }
}
