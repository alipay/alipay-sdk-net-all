using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// MybankCreditLoantradeLoanrelationQueryResponse.
    /// </summary>
    public class MybankCreditLoantradeLoanrelationQueryResponse : AopResponse
    {
        /// <summary>
        /// 是否有融资关系的标志
        /// </summary>
        [XmlElement("loan_relation_flag")]
        public bool LoanRelationFlag { get; set; }
    }
}
