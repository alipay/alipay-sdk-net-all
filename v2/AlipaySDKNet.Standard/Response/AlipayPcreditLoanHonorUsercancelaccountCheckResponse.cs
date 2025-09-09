using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayPcreditLoanHonorUsercancelaccountCheckResponse.
    /// </summary>
    public class AlipayPcreditLoanHonorUsercancelaccountCheckResponse : AopResponse
    {
        /// <summary>
        /// 是否可注销
        /// </summary>
        [XmlElement("logoff_allowed")]
        public bool LogoffAllowed { get; set; }

        /// <summary>
        /// 不可注销原因
        /// </summary>
        [XmlElement("reason")]
        public string Reason { get; set; }
    }
}
