using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayBossProdSubaccountBalanceQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayBossProdSubaccountBalanceQueryModel : AopObject
    {
        /// <summary>
        /// 子户余额查询请求
        /// </summary>
        [XmlElement("sub_account_balance_query_order")]
        public SubAccountBalanceQueryOrder SubAccountBalanceQueryOrder { get; set; }
    }
}
