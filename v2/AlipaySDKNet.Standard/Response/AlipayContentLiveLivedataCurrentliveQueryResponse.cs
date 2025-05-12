using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayContentLiveLivedataCurrentliveQueryResponse.
    /// </summary>
    public class AlipayContentLiveLivedataCurrentliveQueryResponse : AopResponse
    {
        /// <summary>
        /// 支付宝直播id
        /// </summary>
        [XmlElement("alipay_live_id")]
        public string AlipayLiveId { get; set; }

        /// <summary>
        /// 应用日志traceId
        /// </summary>
        [XmlElement("biz_trace_id")]
        public string BizTraceId { get; set; }

        /// <summary>
        /// 评论UV
        /// </summary>
        [XmlElement("comment_uv")]
        public string CommentUv { get; set; }

        /// <summary>
        /// 礼物人数
        /// </summary>
        [XmlElement("num_gift_recipients")]
        public string NumGiftRecipients { get; set; }

        /// <summary>
        /// 房主流水,单位元
        /// </summary>
        [XmlElement("owner_cash_flow")]
        public string OwnerCashFlow { get; set; }

        /// <summary>
        /// 观看UV
        /// </summary>
        [XmlElement("play_uv")]
        public string PlayUv { get; set; }

        /// <summary>
        /// 点赞UV
        /// </summary>
        [XmlElement("praise_uv")]
        public string PraiseUv { get; set; }
    }
}
