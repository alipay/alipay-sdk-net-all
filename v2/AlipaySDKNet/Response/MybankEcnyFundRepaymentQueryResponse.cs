using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// MybankEcnyFundRepaymentQueryResponse.
    /// </summary>
    public class MybankEcnyFundRepaymentQueryResponse : AopResponse
    {
        /// <summary>
        /// null
        /// </summary>
        [XmlArray("repayment_info")]
        [XmlArrayItem("repayment_info")]
        public List<RepaymentInfo> RepaymentInfo { get; set; }
    }
}
