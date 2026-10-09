using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayBossFncGfsmartpaySyncinvoicebillinfoCreateResponse.
    /// </summary>
    public class AlipayBossFncGfsmartpaySyncinvoicebillinfoCreateResponse : AopResponse
    {
        /// <summary>
        /// 通用返回结果
        /// </summary>
        [XmlElement("result_set")]
        public ResultModelForInvoiceBill ResultSet { get; set; }
    }
}
