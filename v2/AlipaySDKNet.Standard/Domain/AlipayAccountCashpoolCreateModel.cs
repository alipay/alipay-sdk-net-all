using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayAccountCashpoolCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayAccountCashpoolCreateModel : AopObject
    {
        /// <summary>
        /// 设置资金池名称
        /// </summary>
        [XmlElement("cash_pool_name")]
        public string CashPoolName { get; set; }

        /// <summary>
        /// INITIAL/RUN/STOP，初始、运行、暂停状态
        /// </summary>
        [XmlElement("cash_pool_status")]
        public string CashPoolStatus { get; set; }

        /// <summary>
        /// 备注信息
        /// </summary>
        [XmlElement("memo")]
        public string Memo { get; set; }

        /// <summary>
        /// 提交人名称
        /// </summary>
        [XmlElement("operator")]
        public string Operator { get; set; }
    }
}
