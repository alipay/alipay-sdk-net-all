using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommercePayforprivilegeWithdrawamountQueryResponse.
    /// </summary>
    public class AlipayCommercePayforprivilegeWithdrawamountQueryResponse : AopResponse
    {
        /// <summary>
        /// 总金额
        /// </summary>
        [XmlElement("balance")]
        public string Balance { get; set; }

        /// <summary>
        /// 可提现金额，单位元
        /// </summary>
        [XmlElement("withdraw_balance")]
        public string WithdrawBalance { get; set; }
    }
}
