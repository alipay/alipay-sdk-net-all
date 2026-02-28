using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceLogisticsFreightflowParentaccountQueryResponse.
    /// </summary>
    public class AlipayCommerceLogisticsFreightflowParentaccountQueryResponse : AopResponse
    {
        /// <summary>
        /// 账户余额，单位分
        /// </summary>
        [XmlElement("account_balance")]
        public string AccountBalance { get; set; }

        /// <summary>
        /// 可用余额.单位为分
        /// </summary>
        [XmlElement("actual_balance")]
        public string ActualBalance { get; set; }

        /// <summary>
        /// 冻结金额,单位为分
        /// </summary>
        [XmlElement("freeze_amt")]
        public string FreezeAmt { get; set; }
    }
}
