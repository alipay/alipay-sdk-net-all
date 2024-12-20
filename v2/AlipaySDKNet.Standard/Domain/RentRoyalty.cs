using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RentRoyalty Data Structure.
    /// </summary>
    [Serializable]
    public class RentRoyalty : AopObject
    {
        /// <summary>
        /// 订单id
        /// </summary>
        [XmlElement("biz_order_id")]
        public string BizOrderId { get; set; }

        /// <summary>
        /// 买家支付宝用户唯一标识
        /// </summary>
        [XmlElement("buyer_id")]
        public string BuyerId { get; set; }

        /// <summary>
        /// 买家支付宝用户唯一标识
        /// </summary>
        [XmlElement("buyer_open_id")]
        public string BuyerOpenId { get; set; }

        /// <summary>
        /// 当前期数改账中的买断分账金，单位：元
        /// </summary>
        [XmlElement("current_buyout_after_price")]
        public string CurrentBuyoutAfterPrice { get; set; }

        /// <summary>
        /// 本期对应的买断分账金，单位：元
        /// </summary>
        [XmlElement("current_buyout_price")]
        public string CurrentBuyoutPrice { get; set; }

        /// <summary>
        /// 商户订单号
        /// </summary>
        [XmlElement("out_order_id")]
        public string OutOrderId { get; set; }

        /// <summary>
        /// 代表某一个阶段的第几期的还款计划，要结合stage进行锁定某一期计划
        /// </summary>
        [XmlElement("period")]
        public string Period { get; set; }

        /// <summary>
        /// 改账中的分账金额，单位：元，精确到小数点后两位
        /// </summary>
        [XmlElement("royalty_after_price")]
        public string RoyaltyAfterPrice { get; set; }

        /// <summary>
        /// 分账履约方式。历史代偿分账，统一输出COMPENSATORY_ALLOC
        /// </summary>
        [XmlElement("royalty_deliver_type")]
        public string RoyaltyDeliverType { get; set; }

        /// <summary>
        /// 分账履约单号
        /// </summary>
        [XmlElement("royalty_installment_no")]
        public string RoyaltyInstallmentNo { get; set; }

        /// <summary>
        /// 分账金额，单位：元，精确到小数点后两位
        /// </summary>
        [XmlElement("royalty_price")]
        public string RoyaltyPrice { get; set; }

        /// <summary>
        /// 分账计划的状态
        /// </summary>
        [XmlElement("royalty_status")]
        public string RoyaltyStatus { get; set; }

        /// <summary>
        /// 分账完成时间点
        /// </summary>
        [XmlElement("royalty_time")]
        public string RoyaltyTime { get; set; }

        /// <summary>
        /// 仅在代偿给资方时，资方的收款方式为到银行卡的场景下才有值，资方的入金流水号
        /// </summary>
        [XmlElement("settle_serial_no")]
        public string SettleSerialNo { get; set; }

        /// <summary>
        /// 代表第几阶段的还款计划，要配合period锁定第几期还款计划
        /// </summary>
        [XmlElement("stage")]
        public string Stage { get; set; }

        /// <summary>
        /// 分账成功之后对应的交易号
        /// </summary>
        [XmlElement("trade_no")]
        public string TradeNo { get; set; }

        /// <summary>
        /// 租金类型
        /// </summary>
        [XmlElement("type")]
        public string Type { get; set; }
    }
}
