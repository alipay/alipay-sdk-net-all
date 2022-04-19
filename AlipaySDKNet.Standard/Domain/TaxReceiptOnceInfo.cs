using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// TaxReceiptOnceInfo Data Structure.
    /// </summary>
    [Serializable]
    public class TaxReceiptOnceInfo : AopObject
    {
        /// <summary>
        /// 已认证的法人手机号
        /// </summary>
        [XmlElement("cognizant_mobile")]
        public string CognizantMobile { get; set; }

        /// <summary>
        /// 纳税人识别号，也称税号
        /// </summary>
        [XmlElement("ep_tax_id")]
        public string EpTaxId { get; set; }
    }
}
