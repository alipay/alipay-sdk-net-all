using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// InstCashPoolAccountMappingVO Data Structure.
    /// </summary>
    [Serializable]
    public class InstCashPoolAccountMappingVO : AopObject
    {
        /// <summary>
        /// 资金池唯一标识
        /// </summary>
        [XmlElement("cash_pool_id")]
        public string CashPoolId { get; set; }

        /// <summary>
        /// 当前机构账户
        /// </summary>
        [XmlElement("inst_account")]
        public InstAccountDTO InstAccount { get; set; }

        /// <summary>
        /// 当前账号是否为资金池主账号，Y是，N不是
        /// </summary>
        [XmlElement("main_account")]
        public string MainAccount { get; set; }

        /// <summary>
        /// 操作员
        /// </summary>
        [XmlElement("operator")]
        public string Operator { get; set; }

        /// <summary>
        /// 父账号
        /// </summary>
        [XmlElement("parent_inst_account")]
        public InstAccountDTO ParentInstAccount { get; set; }
    }
}
