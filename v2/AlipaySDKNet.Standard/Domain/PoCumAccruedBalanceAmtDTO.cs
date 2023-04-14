using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// PoCumAccruedBalanceAmtDTO Data Structure.
    /// </summary>
    [Serializable]
    public class PoCumAccruedBalanceAmtDTO : AopObject
    {
        /// <summary>
        /// 会记期间
        /// </summary>
        [XmlElement("account_period")]
        public string AccountPeriod { get; set; }

        /// <summary>
        /// 预提余额详情列表
        /// </summary>
        [XmlArray("accrued_balance_detail_list")]
        [XmlArrayItem("po_cum_accrued_balance_amt_detail_d_t_o")]
        public List<PoCumAccruedBalanceAmtDetailDTO> AccruedBalanceDetailList { get; set; }

        /// <summary>
        /// 关账状态（对应会记期间是否已关账）
        /// </summary>
        [XmlElement("close_accounted_status")]
        public bool CloseAccountedStatus { get; set; }
    }
}
