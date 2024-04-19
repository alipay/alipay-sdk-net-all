using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// SubAccountBalanceFreezeResultOpenApiDTO Data Structure.
    /// </summary>
    [Serializable]
    public class SubAccountBalanceFreezeResultOpenApiDTO : AopObject
    {
        /// <summary>
        /// 冻结号(实际通过outBizNo作为冻结号)
        /// </summary>
        [XmlElement("freeze_no")]
        public string FreezeNo { get; set; }

        /// <summary>
        /// 本次冻结金额
        /// </summary>
        [XmlElement("freeze_success_amount")]
        public MultiCurrencyMoneyOpenApi FreezeSuccessAmount { get; set; }

        /// <summary>
        /// 子户余额对象(冻结后)
        /// </summary>
        [XmlElement("sub_account_balance")]
        public SubAccountBalanceOpenApiDTO SubAccountBalance { get; set; }
    }
}
