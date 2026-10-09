using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayUserAigcAipictureQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayUserAigcAipictureQueryModel : AopObject
    {
        /// <summary>
        /// 支付宝AIGC订单id
        /// </summary>
        [XmlElement("alipay_order_id")]
        public string AlipayOrderId { get; set; }

        /// <summary>
        /// afts图片ID
        /// </summary>
        [XmlElement("image_id")]
        public string ImageId { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 商家侧业务订单号
        /// </summary>
        [XmlElement("order_id")]
        public string OrderId { get; set; }

        /// <summary>
        /// 同一笔流水，请求高清图生成的重试次数，默认0
        /// </summary>
        [XmlElement("retry_count")]
        public long RetryCount { get; set; }

        /// <summary>
        /// 支付宝生成的traceId，由前端跳转携带，用于问题追溯
        /// </summary>
        [XmlElement("trace_id")]
        public string TraceId { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
