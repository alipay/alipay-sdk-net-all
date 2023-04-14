using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayFincoreFunddsFundWitnessWithdrawModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayFincoreFunddsFundWitnessWithdrawModel : AopObject
    {
        /// <summary>
        /// 必填，外部流水号，幂等字段
        /// </summary>
        [XmlElement("out_request_no")]
        public string OutRequestNo { get; set; }

        /// <summary>
        /// 产品码
        /// </summary>
        [XmlElement("product_code")]
        public string ProductCode { get; set; }

        /// <summary>
        /// 分库分表id
        /// </summary>
        [XmlElement("sharding_id")]
        public string ShardingId { get; set; }

        /// <summary>
        /// 关联交易明细
        /// </summary>
        [XmlArray("trade_detail_info_list")]
        [XmlArrayItem("trade_detail_info_d_t_o")]
        public List<TradeDetailInfoDTO> TradeDetailInfoList { get; set; }

        /// <summary>
        /// 提现条款
        /// </summary>
        [XmlElement("withdraw_clause_detail")]
        public WithdrawClauseDetailDTO WithdrawClauseDetail { get; set; }
    }
}
