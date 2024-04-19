using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayMarketingActivityDeductConsultModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMarketingActivityDeductConsultModel : AopObject
    {
        /// <summary>
        /// 券指定的核销appid（如果配券时指定了核销范围为线上小程序及相应的appid则此处必传）
        /// </summary>
        [XmlElement("available_app_id")]
        public string AvailableAppId { get; set; }

        /// <summary>
        /// 支付宝平台渠道承接信息。用户从公域会场、直播等场景跳转时会携带这部分信息，商户需要获取并传入。
        /// </summary>
        [XmlElement("mini_trace_info")]
        public string MiniTraceInfo { get; set; }

        /// <summary>
        /// 订单金额（如同时享受商户自有优惠请先扣除后传入），单位为元，最多2位小数
        /// </summary>
        [XmlElement("order_amount")]
        public string OrderAmount { get; set; }
    }
}
