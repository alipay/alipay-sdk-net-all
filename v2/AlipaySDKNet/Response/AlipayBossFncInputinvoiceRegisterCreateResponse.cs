using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayBossFncInputinvoiceRegisterCreateResponse.
    /// </summary>
    public class AlipayBossFncInputinvoiceRegisterCreateResponse : AopResponse
    {
        /// <summary>
        /// 返回结果
        /// </summary>
        [XmlElement("result_set")]
        public InputInvoiceRegisterResponse ResultSet { get; set; }
    }
}
