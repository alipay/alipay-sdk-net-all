using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceRentZatSellerSettleModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceRentZatSellerSettleModel : AopObject
    {
        /// <summary>
        /// 交易组件订单号
        /// </summary>
        [XmlElement("biz_order_id")]
        public string BizOrderId { get; set; }

        /// <summary>
        /// 分账结算业务扩展参数
        /// </summary>
        [XmlElement("extend_param")]
        public SettleExtParam ExtendParam { get; set; }

        /// <summary>
        /// 操作员 ID，商家自定义操作员编号。
        /// </summary>
        [XmlElement("operator_id")]
        public string OperatorId { get; set; }

        /// <summary>
        /// 结算请求流水号，由商家自定义。64个字符以内，仅可包含字母、数字、下划线。需保证在商户端不重复。
        /// </summary>
        [XmlElement("out_request_no")]
        public string OutRequestNo { get; set; }

        /// <summary>
        /// 分账模式，目前只支持同步执行sync，不传默认同步执行
        /// </summary>
        [XmlElement("royalty_mode")]
        public string RoyaltyMode { get; set; }

        /// <summary>
        /// 分账明细信息。单独调用分账完结时，可以不传此参数。其他场景必传。 注意：商家分账场景下分账收入方 trans_in 只支持支付宝账户，不支持使用 cardAliasNo 卡编号。
        /// </summary>
        [XmlElement("royalty_param")]
        public RoyaltyDetailInfoPojo RoyaltyParam { get; set; }

        /// <summary>
        /// 支付宝交易订单号
        /// </summary>
        [XmlElement("trade_no")]
        public string TradeNo { get; set; }
    }
}
