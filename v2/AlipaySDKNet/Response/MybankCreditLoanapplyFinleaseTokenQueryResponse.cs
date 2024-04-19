using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// MybankCreditLoanapplyFinleaseTokenQueryResponse.
    /// </summary>
    public class MybankCreditLoanapplyFinleaseTokenQueryResponse : AopResponse
    {
        /// <summary>
        /// 原因
        /// </summary>
        [XmlElement("reason")]
        public string Reason { get; set; }

        /// <summary>
        /// 生成安全的url
        /// </summary>
        [XmlElement("security_url")]
        public string SecurityUrl { get; set; }

        /// <summary>
        /// 是否有效,true 有效，false无效
        /// </summary>
        [XmlElement("valid")]
        public bool Valid { get; set; }
    }
}
