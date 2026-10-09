using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// UserTradeInfoDTO Data Structure.
    /// </summary>
    [Serializable]
    public class UserTradeInfoDTO : AopObject
    {
        /// <summary>
        /// 商品信息列表
        /// </summary>
        [XmlArray("goods_info_list")]
        [XmlArrayItem("goods_info_d_t_o")]
        public List<GoodsInfoDTO> GoodsInfoList { get; set; }

        /// <summary>
        /// 门店ISV的PID
        /// </summary>
        [XmlElement("partner_id")]
        public string PartnerId { get; set; }

        /// <summary>
        /// 是否是风险交易：NO_RISK-无风险；POTENTIAL_RISK-潜在风险（中等风险）；HIGH_RISK-高风险
        /// </summary>
        [XmlElement("risk_level")]
        public string RiskLevel { get; set; }

        /// <summary>
        /// 交易总金额，单位元，精确两位小数点
        /// </summary>
        [XmlElement("trade_amount")]
        public string TradeAmount { get; set; }

        /// <summary>
        /// 交易单号
        /// </summary>
        [XmlElement("trade_no")]
        public string TradeNo { get; set; }

        /// <summary>
        /// 交易时间
        /// </summary>
        [XmlElement("trade_time")]
        public string TradeTime { get; set; }

        /// <summary>
        /// 商品数据会根据活动商品列表进行过滤，该字段代表未过滤的商品列表大小
        /// </summary>
        [XmlElement("unfiltered_total_goods_count")]
        public long UnfilteredTotalGoodsCount { get; set; }

        /// <summary>
        /// 消费者支付宝ID
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
