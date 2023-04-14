using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayEbppInvoiceCompanyQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEbppInvoiceCompanyQueryModel : AopObject
    {
        /// <summary>
        /// 纳税人识别号。register_id与payee_register_no不能同时为空
        /// </summary>
        [XmlElement("payee_register_no")]
        public string PayeeRegisterNo { get; set; }

        /// <summary>
        /// 入驻工单ID. register_id与payee_register_no不能同时为空
        /// </summary>
        [XmlElement("register_id")]
        public string RegisterId { get; set; }
    }
}
