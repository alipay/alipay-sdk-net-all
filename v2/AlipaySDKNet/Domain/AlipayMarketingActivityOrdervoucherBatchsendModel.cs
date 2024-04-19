using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayMarketingActivityOrdervoucherBatchsendModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMarketingActivityOrdervoucherBatchsendModel : AopObject
    {
        /// <summary>
        /// 在用户购买完成商家兑换券之后，通过此接口发放 用户购买订单之后需要发放的商家兑换券
        /// </summary>
        [XmlArray("activity_send_voucher_info_list")]
        [XmlArrayItem("activity_send_voucher_info")]
        public List<ActivitySendVoucherInfo> ActivitySendVoucherInfoList { get; set; }

        /// <summary>
        /// 发放时间
        /// </summary>
        [XmlElement("biz_dt")]
        public string BizDt { get; set; }

        /// <summary>
        /// 支付宝用户openId
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 投放埋点信息。由支付宝公私域跳转到服务商小程序时带入。例如alipays://platformapi/startapp?appId=2021002140648450&query=promoTraceInfo%3DUFJPTU9fU0NFTkVfSUQ9OkNCMTExOTk3MDBAO0BQT1NJVElPTl9DT0RFPTptb3JwaG9fYzQxYWY2，其中promoTraceInfo由支付宝带入投放埋点信息，需要在调用批量发券接口时传入
        /// </summary>
        [XmlElement("promo_trace_info")]
        public string PromoTraceInfo { get; set; }

        /// <summary>
        /// 商家券售卖交易渠道，用于安全审核。 如 支付宝交易渠道:ZHIFUBAO_TRADE_CHANNEL
        /// </summary>
        [XmlElement("trade_channel")]
        public string TradeChannel { get; set; }

        /// <summary>
        /// 该交易在支付宝/其他交易系统中的交易流水号。
        /// </summary>
        [XmlElement("trade_no")]
        public string TradeNo { get; set; }

        /// <summary>
        /// 买家的支付宝uid
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
