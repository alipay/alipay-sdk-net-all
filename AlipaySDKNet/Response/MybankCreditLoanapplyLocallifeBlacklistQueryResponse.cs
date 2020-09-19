using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// MybankCreditLoanapplyLocallifeBlacklistQueryResponse.
    /// </summary>
    public class MybankCreditLoanapplyLocallifeBlacklistQueryResponse : AopResponse
    {
        /// <summary>
        /// 是否是黑名单 true：是 false：否
        /// </summary>
        [XmlElement("is_black")]
        public bool IsBlack { get; set; }
    }
}
