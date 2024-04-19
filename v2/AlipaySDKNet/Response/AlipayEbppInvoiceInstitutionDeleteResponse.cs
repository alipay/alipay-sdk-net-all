using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayEbppInvoiceInstitutionDeleteResponse.
    /// </summary>
    public class AlipayEbppInvoiceInstitutionDeleteResponse : AopResponse
    {
        /// <summary>
        /// 删除结果是否成功
        /// </summary>
        [XmlElement("result")]
        public bool Result { get; set; }
    }
}
