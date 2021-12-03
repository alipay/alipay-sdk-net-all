using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// EnterprisePayInfo Data Structure.
    /// </summary>
    [Serializable]
    public class EnterprisePayInfo : AopObject
    {
        /// <summary>
        /// 开票金额
        /// </summary>
        [XmlElement("invoice_amount")]
        public string InvoiceAmount { get; set; }
    }
}
