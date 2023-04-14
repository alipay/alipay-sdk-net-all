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
        /// 公司名称
        /// </summary>
        [XmlElement("corporationname")]
        public string Corporationname { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 工商注册号
        /// </summary>
        [XmlElement("registrationno")]
        public string Registrationno { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [XmlElement("userid")]
        public string Userid { get; set; }
    }
}
