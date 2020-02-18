using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayPcreditLoanBeikeaccountInterestfreeModifyResponse.
    /// </summary>
    public class AlipayPcreditLoanBeikeaccountInterestfreeModifyResponse : AopResponse
    {
        /// <summary>
        /// 呗壳额度返回结果
        /// </summary>
        [XmlElement("beike_account_response")]
        public BeikeAccountResponse BeikeAccountResponse { get; set; }
    }
}
