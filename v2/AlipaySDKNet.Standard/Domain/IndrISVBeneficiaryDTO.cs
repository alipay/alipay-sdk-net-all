using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// IndrISVBeneficiaryDTO Data Structure.
    /// </summary>
    [Serializable]
    public class IndrISVBeneficiaryDTO : AopObject
    {
        /// <summary>
        /// 收款方id
        /// </summary>
        [XmlElement("beneficiary_id")]
        public string BeneficiaryId { get; set; }

        /// <summary>
        /// 收款方名称(结果为success才会返回...
        /// </summary>
        [XmlElement("beneficiary_name")]
        public string BeneficiaryName { get; set; }

        /// <summary>
        /// 国家码，ISO-3166 2位国家码 https://www.iso.org/iso-3166-country-codes.html
        /// </summary>
        [XmlElement("country")]
        public string Country { get; set; }
    }
}
