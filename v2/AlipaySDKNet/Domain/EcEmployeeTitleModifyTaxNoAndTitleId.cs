using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// EcEmployeeTitleModifyTaxNoAndTitleId Data Structure.
    /// </summary>
    [Serializable]
    public class EcEmployeeTitleModifyTaxNoAndTitleId : AopObject
    {
        /// <summary>
        /// 税号
        /// </summary>
        [XmlElement("tax_register_no")]
        public string TaxRegisterNo { get; set; }

        /// <summary>
        /// 抬头ID
        /// </summary>
        [XmlElement("title_id")]
        public string TitleId { get; set; }
    }
}
