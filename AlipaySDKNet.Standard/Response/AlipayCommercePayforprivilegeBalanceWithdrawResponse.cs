using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommercePayforprivilegeBalanceWithdrawResponse.
    /// </summary>
    public class AlipayCommercePayforprivilegeBalanceWithdrawResponse : AopResponse
    {
        /// <summary>
        /// 提现流水号
        /// </summary>
        [XmlElement("withdraw_id")]
        public string WithdrawId { get; set; }
    }
}
