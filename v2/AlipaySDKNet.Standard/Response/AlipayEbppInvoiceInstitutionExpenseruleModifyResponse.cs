using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayEbppInvoiceInstitutionExpenseruleModifyResponse.
    /// </summary>
    public class AlipayEbppInvoiceInstitutionExpenseruleModifyResponse : AopResponse
    {
        /// <summary>
        /// 编辑结果是否成功
        /// </summary>
        [XmlElement("result")]
        public bool Result { get; set; }
    }
}
