using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// BillResult Data Structure.
    /// </summary>
    [Serializable]
    public class BillResult : AopObject
    {
        /// <summary>
        /// 活动批次
        /// </summary>
        [XmlElement("activity_batch_no")]
        public string ActivityBatchNo { get; set; }

        /// <summary>
        /// 活动类型
        /// </summary>
        [XmlElement("activity_type")]
        public string ActivityType { get; set; }

        /// <summary>
        /// 银行清算号16位/31位
        /// </summary>
        [XmlElement("bank_bill_no")]
        public string BankBillNo { get; set; }

        /// <summary>
        /// 银行补贴金额
        /// </summary>
        [XmlElement("bank_discount_amount")]
        public string BankDiscountAmount { get; set; }

        /// <summary>
        /// 交易卡种:[1：借记卡 ,2：信用卡]
        /// </summary>
        [XmlElement("card_type")]
        public long CardType { get; set; }

        /// <summary>
        /// 优惠名称
        /// </summary>
        [XmlElement("discount_name")]
        public string DiscountName { get; set; }

        /// <summary>
        /// 原始订单金额，提现金额
        /// </summary>
        [XmlElement("order_amount")]
        public string OrderAmount { get; set; }

        /// <summary>
        /// 交易时间，格式yyyyMMdd
        /// </summary>
        [XmlElement("pay_date")]
        public string PayDate { get; set; }

        /// <summary>
        /// 交易时间，格式：yyyy-MM-dd HH:mm:ss
        /// </summary>
        [XmlElement("pay_time")]
        public string PayTime { get; set; }

        /// <summary>
        /// 实际交易金额，提现金额
        /// </summary>
        [XmlElement("real_pay_amount")]
        public string RealPayAmount { get; set; }

        /// <summary>
        /// 场景码，摩斯分配
        /// </summary>
        [XmlElement("scene")]
        public string Scene { get; set; }

        /// <summary>
        /// 二级交易场景
        /// </summary>
        [XmlElement("sub_scene")]
        public string SubScene { get; set; }

        /// <summary>
        /// 交易通道标识
        /// </summary>
        [XmlElement("trade_channel")]
        public string TradeChannel { get; set; }
    }
}
