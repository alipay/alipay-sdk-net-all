using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// MybankCreditLoantradeLoanstatusAdmitQueryResponse.
    /// </summary>
    public class MybankCreditLoantradeLoanstatusAdmitQueryResponse : AopResponse
    {
        /// <summary>
        /// true：授权 false：未授权
        /// </summary>
        [XmlElement("authority")]
        public bool Authority { get; set; }

        /// <summary>
        /// true：授信准入； false：授信不准入
        /// </summary>
        [XmlElement("credit_admit")]
        public bool CreditAdmit { get; set; }

        /// <summary>
        /// true：有在途或者逾期 false：没有在途和逾期
        /// </summary>
        [XmlElement("has_balance")]
        public bool HasBalance { get; set; }
    }
}
