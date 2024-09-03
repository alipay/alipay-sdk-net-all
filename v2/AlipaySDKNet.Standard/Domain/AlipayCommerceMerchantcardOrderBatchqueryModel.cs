using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceMerchantcardOrderBatchqueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMerchantcardOrderBatchqueryModel : AopObject
    {
        /// <summary>
        /// 卡名称
        /// </summary>
        [XmlElement("card_name")]
        public string CardName { get; set; }

        /// <summary>
        /// 售卖订单状态 ● 次卡/周期卡 ○ 订购中:init ○ 可使用:available ○ 已用完:used_up ○ 关闭中:closing ○ 已关闭:closed ○ 暂停:pause ● 金额卡 ○ 可使用:available ○ 已失效：invalid ○ 已支付：paid ○ 已退款：refund ○ 超时关闭：timeout_closed ○ 已用完:used_up
        /// </summary>
        [XmlElement("card_status")]
        public string CardStatus { get; set; }

        /// <summary>
        /// 卡ID
        /// </summary>
        [XmlElement("card_template_id")]
        public string CardTemplateId { get; set; }

        /// <summary>
        /// 卡类型
        /// </summary>
        [XmlElement("card_type")]
        public string CardType { get; set; }

        /// <summary>
        /// 用于标记支付宝用户在应用下的唯一标识
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 售卖订单结束时间
        /// </summary>
        [XmlElement("order_end_date")]
        public string OrderEndDate { get; set; }

        /// <summary>
        /// 售卖订单开始时间
        /// </summary>
        [XmlElement("order_start_date")]
        public string OrderStartDate { get; set; }

        /// <summary>
        /// 页码
        /// </summary>
        [XmlElement("page_num")]
        public long PageNum { get; set; }

        /// <summary>
        /// 页大小
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 门店ID
        /// </summary>
        [XmlElement("shop_id")]
        public string ShopId { get; set; }

        /// <summary>
        /// 支付宝交易号
        /// </summary>
        [XmlElement("trade_no")]
        public string TradeNo { get; set; }

        /// <summary>
        /// 支付宝用户的userId。
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
