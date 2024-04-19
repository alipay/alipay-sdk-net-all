using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// MybankCreditLoanapplyElmCreditloanadmitQueryResponse.
    /// </summary>
    public class MybankCreditLoanapplyElmCreditloanadmitQueryResponse : AopResponse
    {
        /// <summary>
        /// 可贷额度标签
        /// </summary>
        [XmlElement("admit_label")]
        public string AdmitLabel { get; set; }
    }
}
