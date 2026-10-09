using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayFincoreFunddsFundWitnessPayModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayFincoreFunddsFundWitnessPayModel : AopObject
    {
        /// <summary>
        /// 必填，外部流水号，幂等字段
        /// </summary>
        [XmlElement("out_request_no")]
        public string OutRequestNo { get; set; }

        /// <summary>
        /// 支付条款(必填,暂时只支持一条) notice:若为多条明细,需保证出账方相同,每条明细分别执行分账,不保证一致性 notice:若为多条明细,幂等重试时,需保证顺序不变
        /// </summary>
        [XmlArray("payment_clause_detail_list")]
        [XmlArrayItem("payment_clause_detail_d_t_o")]
        public List<PaymentClauseDetailDTO> PaymentClauseDetailList { get; set; }

        /// <summary>
        /// 签约产品码,唯一,区分资金存管服务产品类型
        /// </summary>
        [XmlElement("product_code")]
        public string ProductCode { get; set; }

        /// <summary>
        /// 分库分表标
        /// </summary>
        [XmlElement("sharding_id")]
        public string ShardingId { get; set; }

        /// <summary>
        /// 关联交易详细信息（转入或转出是监管内部户资产时必填）
        /// </summary>
        [XmlArray("trade_detail_info_list")]
        [XmlArrayItem("trade_detail_info_d_t_o")]
        public List<TradeDetailInfoDTO> TradeDetailInfoList { get; set; }
    }
}
