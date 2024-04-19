using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// MybankCreditLoanapplyBkamcAntauthsignConsultResponse.
    /// </summary>
    public class MybankCreditLoanapplyBkamcAntauthsignConsultResponse : AopResponse
    {
        /// <summary>
        /// 是否有授权
        /// </summary>
        [XmlElement("authed")]
        public bool Authed { get; set; }
    }
}
