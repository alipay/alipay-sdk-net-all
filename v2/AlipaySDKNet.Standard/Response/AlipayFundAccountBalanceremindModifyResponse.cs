using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayFundAccountBalanceremindModifyResponse.
    /// </summary>
    public class AlipayFundAccountBalanceremindModifyResponse : AopResponse
    {
        /// <summary>
        /// 计划版本
        /// </summary>
        [XmlElement("plan_version")]
        public string PlanVersion { get; set; }
    }
}
