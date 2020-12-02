using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayBossFncSubaccountBalanceFreezeModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayBossFncSubaccountBalanceFreezeModel : AopObject
    {
        /// <summary>
        /// 子户余额冻结请求
        /// </summary>
        [XmlElement("sub_account_balance_freeze_order")]
        public SubAccountBalanceFreezeOrder SubAccountBalanceFreezeOrder { get; set; }
    }
}
