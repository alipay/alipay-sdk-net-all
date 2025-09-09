using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MoneyCardUseRecordDetail Data Structure.
    /// </summary>
    [Serializable]
    public class MoneyCardUseRecordDetail : AopObject
    {
        /// <summary>
        /// 金额，对应金额卡实际核销金额，单位：分
        /// </summary>
        [XmlElement("amount")]
        public string Amount { get; set; }

        /// <summary>
        /// 费用信息集合
        /// </summary>
        [XmlArray("bill_fee_info_list")]
        [XmlArrayItem("bill_fee_info")]
        public List<BillFeeInfo> BillFeeInfoList { get; set; }

        /// <summary>
        /// 业务类型
        /// </summary>
        [XmlElement("biz_type")]
        public string BizType { get; set; }

        /// <summary>
        /// 售卖订单id
        /// </summary>
        [XmlElement("card_id")]
        public string CardId { get; set; }

        /// <summary>
        /// 现金价值，对应金额卡实际出资部分，单位：分
        /// </summary>
        [XmlElement("cash")]
        public string Cash { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [XmlElement("create_time")]
        public string CreateTime { get; set; }

        /// <summary>
        /// 用于标记支付宝用户在应用下的唯一标识
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 交易组件业务单号
        /// </summary>
        [XmlElement("order_id")]
        public string OrderId { get; set; }

        /// <summary>
        /// 用于标记支付宝用户在应用下的唯一标识
        /// </summary>
        [XmlElement("owner_open_id")]
        public string OwnerOpenId { get; set; }

        /// <summary>
        /// 金额卡归属人uid
        /// </summary>
        [XmlElement("owner_uid")]
        public string OwnerUid { get; set; }

        /// <summary>
        /// 核销退款金额（单位分）
        /// </summary>
        [XmlElement("refund_amount")]
        public long RefundAmount { get; set; }

        /// <summary>
        /// 核销退款时间
        /// </summary>
        [XmlElement("refund_time")]
        public string RefundTime { get; set; }

        /// <summary>
        /// 售卖门店对应的外部门店编号
        /// </summary>
        [XmlElement("sell_rel_shop_id")]
        public string SellRelShopId { get; set; }

        /// <summary>
        /// 售卖门店id
        /// </summary>
        [XmlElement("sell_shop_id")]
        public string SellShopId { get; set; }

        /// <summary>
        /// 交易号
        /// </summary>
        [XmlElement("trade_no")]
        public string TradeNo { get; set; }

        /// <summary>
        /// 收单pid
        /// </summary>
        [XmlElement("trade_pid")]
        public string TradePid { get; set; }

        /// <summary>
        /// 面额价，单位：分
        /// </summary>
        [XmlElement("use_amount")]
        public long UseAmount { get; set; }

        /// <summary>
        /// 核销门店对应的外部门店id
        /// </summary>
        [XmlElement("use_rel_shop_id")]
        public string UseRelShopId { get; set; }

        /// <summary>
        /// 核销门店id
        /// </summary>
        [XmlElement("use_shop_id")]
        public string UseShopId { get; set; }

        /// <summary>
        /// 核销门店名
        /// </summary>
        [XmlElement("use_shop_name")]
        public string UseShopName { get; set; }

        /// <summary>
        /// 核销门店备注
        /// </summary>
        [XmlElement("use_shop_note")]
        public string UseShopNote { get; set; }

        /// <summary>
        /// 核销支付宝用户的userId。
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
