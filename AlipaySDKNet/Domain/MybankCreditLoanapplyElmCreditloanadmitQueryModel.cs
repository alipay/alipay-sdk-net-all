using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MybankCreditLoanapplyElmCreditloanadmitQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class MybankCreditLoanapplyElmCreditloanadmitQueryModel : AopObject
    {
        /// <summary>
        /// 站点会员
        /// </summary>
        [XmlElement("site")]
        public string Site { get; set; }

        /// <summary>
        /// 站点的会员ID
        /// </summary>
        [XmlElement("site_user_id")]
        public string SiteUserId { get; set; }
    }
}
