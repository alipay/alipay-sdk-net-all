using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayFundAccountBalanceremindstatusModifyResponse.
    /// </summary>
    public class AlipayFundAccountBalanceremindstatusModifyResponse : AopResponse
    {
        /// <summary>
        /// 计划版本号
        /// </summary>
        [XmlElement("plan_version")]
        public string PlanVersion { get; set; }
    }
}
