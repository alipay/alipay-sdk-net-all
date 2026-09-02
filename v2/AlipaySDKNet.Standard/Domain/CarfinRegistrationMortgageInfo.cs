using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// CarfinRegistrationMortgageInfo Data Structure.
    /// </summary>
    [Serializable]
    public class CarfinRegistrationMortgageInfo : AopObject
    {
        /// <summary>
        /// 抵押登记日期
        /// </summary>
        [XmlElement("mortgage_registration_date")]
        public string MortgageRegistrationDate { get; set; }

        /// <summary>
        /// 解除抵押日期
        /// </summary>
        [XmlElement("mortgage_release_date")]
        public string MortgageReleaseDate { get; set; }

        /// <summary>
        /// 抵押权人姓名
        /// </summary>
        [XmlElement("mortgagee_name")]
        public string MortgageeName { get; set; }
    }
}
