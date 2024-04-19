using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayAccountCashpoolBasicQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayAccountCashpoolBasicQueryModel : AopObject
    {
        /// <summary>
        /// 查询条件，资金池名称，不支持模糊查询
        /// </summary>
        [XmlElement("cash_pool_name")]
        public string CashPoolName { get; set; }

        /// <summary>
        /// 页码
        /// </summary>
        [XmlElement("page_num")]
        public long PageNum { get; set; }

        /// <summary>
        /// 页面大小
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }
    }
}
