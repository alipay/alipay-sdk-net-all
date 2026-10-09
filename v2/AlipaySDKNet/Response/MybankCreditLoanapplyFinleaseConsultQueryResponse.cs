using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// MybankCreditLoanapplyFinleaseConsultQueryResponse.
    /// </summary>
    public class MybankCreditLoanapplyFinleaseConsultQueryResponse : AopResponse
    {
        /// <summary>
        /// 是否准入，true表示准则，false表示不准入
        /// </summary>
        [XmlElement("admit")]
        public bool Admit { get; set; }
    }
}
