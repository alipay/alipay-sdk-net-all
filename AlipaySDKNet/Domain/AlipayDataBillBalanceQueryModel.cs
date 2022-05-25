using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayDataBillBalanceQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayDataBillBalanceQueryModel : AopObject
    {
        /// <summary>
        /// 目标查询账户（仅支持部分场景，查询自身时候不需要传递当前字段）。
        /// </summary>
        [XmlElement("bill_user_id")]
        public string BillUserId { get; set; }
    }
}
