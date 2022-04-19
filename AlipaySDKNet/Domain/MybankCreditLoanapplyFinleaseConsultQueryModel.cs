using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MybankCreditLoanapplyFinleaseConsultQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class MybankCreditLoanapplyFinleaseConsultQueryModel : AopObject
    {
        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [XmlElement("userid")]
        public string Userid { get; set; }
    }
}
