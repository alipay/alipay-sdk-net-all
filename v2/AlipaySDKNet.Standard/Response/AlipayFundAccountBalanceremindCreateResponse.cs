using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayFundAccountBalanceremindCreateResponse.
    /// </summary>
    public class AlipayFundAccountBalanceremindCreateResponse : AopResponse
    {
        /// <summary>
        /// 创建的计划在支付宝域内的id
        /// </summary>
        [XmlElement("plan_id")]
        public string PlanId { get; set; }

        /// <summary>
        /// 计划的版本号，每次修改会递增
        /// </summary>
        [XmlElement("plan_version")]
        public string PlanVersion { get; set; }
    }
}
