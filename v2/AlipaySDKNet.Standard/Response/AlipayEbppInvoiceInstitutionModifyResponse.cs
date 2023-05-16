using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayEbppInvoiceInstitutionModifyResponse.
    /// </summary>
    public class AlipayEbppInvoiceInstitutionModifyResponse : AopResponse
    {
        /// <summary>
        /// 修改是否成功
        /// </summary>
        [XmlElement("result")]
        public bool Result { get; set; }
    }
}
