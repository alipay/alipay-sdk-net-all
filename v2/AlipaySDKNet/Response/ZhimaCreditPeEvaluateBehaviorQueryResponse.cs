using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// ZhimaCreditPeEvaluateBehaviorQueryResponse.
    /// </summary>
    public class ZhimaCreditPeEvaluateBehaviorQueryResponse : AopResponse
    {
        /// <summary>
        /// 用户订单拉起受理台咨询时间
        /// </summary>
        [XmlElement("evaluate_time")]
        public string EvaluateTime { get; set; }

        /// <summary>
        /// 用于标记支付宝用户在应用下的唯一标识
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 商家订单号
        /// </summary>
        [XmlElement("out_trade_no")]
        public string OutTradeNo { get; set; }

        /// <summary>
        /// 信用服务service_id； 芝麻侧通过商户PID生成的一个信用服务的id
        /// </summary>
        [XmlElement("service_id")]
        public string ServiceId { get; set; }

        /// <summary>
        /// 支付宝用户的userId。
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
