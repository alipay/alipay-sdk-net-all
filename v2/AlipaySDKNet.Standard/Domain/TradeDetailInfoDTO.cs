using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// TradeDetailInfoDTO Data Structure.
    /// </summary>
    [Serializable]
    public class TradeDetailInfoDTO : AopObject
    {
        /// <summary>
        /// 交易发生时间
        /// </summary>
        [XmlElement("gmt_occur")]
        public string GmtOccur { get; set; }

        /// <summary>
        /// 交易原始金额，单位元，保留两位小数
        /// </summary>
        [XmlElement("order_amount")]
        public string OrderAmount { get; set; }

        /// <summary>
        /// 业务收单交易号
        /// </summary>
        [XmlElement("partner_trade_no")]
        public string PartnerTradeNo { get; set; }

        /// <summary>
        /// 收单模式，TRADE-收单类，NONE_TRADE-非收单类
        /// </summary>
        [XmlElement("trade_mode")]
        public string TradeMode { get; set; }

        /// <summary>
        /// 收单平台,收单类交易必传
        /// </summary>
        [XmlElement("trade_platform")]
        public string TradePlatform { get; set; }

        /// <summary>
        /// 交易备注
        /// </summary>
        [XmlElement("trade_title")]
        public string TradeTitle { get; set; }

        /// <summary>
        /// 总入账金额，收单类交易必传。单位元，人民币，保留两位小数
        /// </summary>
        [XmlElement("trans_in_amount")]
        public string TransInAmount { get; set; }

        /// <summary>
        /// 入账流水唯一id，收单类交易必传
        /// </summary>
        [XmlElement("trans_in_unique_id")]
        public string TransInUniqueId { get; set; }

        /// <summary>
        /// 支付人信息，可为支付宝uid，email，用户名等形式。新业务接入需协商。
        /// </summary>
        [XmlElement("user_identity")]
        public string UserIdentity { get; set; }
    }
}
