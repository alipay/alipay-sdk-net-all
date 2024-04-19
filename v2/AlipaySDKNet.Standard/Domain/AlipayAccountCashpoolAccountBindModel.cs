using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayAccountCashpoolAccountBindModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayAccountCashpoolAccountBindModel : AopObject
    {
        /// <summary>
        /// 资金池账户关联关系
        /// </summary>
        [XmlArray("cash_pool_account_mapping_vo_list")]
        [XmlArrayItem("inst_cash_pool_account_mapping_v_o")]
        public List<InstCashPoolAccountMappingVO> CashPoolAccountMappingVoList { get; set; }

        /// <summary>
        /// 资金池唯一标识
        /// </summary>
        [XmlElement("cash_pool_id")]
        public string CashPoolId { get; set; }

        /// <summary>
        /// 操作员
        /// </summary>
        [XmlElement("operator")]
        public string Operator { get; set; }
    }
}
