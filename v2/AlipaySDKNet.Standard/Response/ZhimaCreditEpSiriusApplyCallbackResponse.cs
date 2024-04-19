using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// ZhimaCreditEpSiriusApplyCallbackResponse.
    /// </summary>
    public class ZhimaCreditEpSiriusApplyCallbackResponse : AopResponse
    {
        /// <summary>
        /// 天狼星业务id
        /// </summary>
        [XmlElement("biz_id")]
        public string BizId { get; set; }

        /// <summary>
        /// 响应消息
        /// </summary>
        [XmlElement("message")]
        public string Message { get; set; }

        /// <summary>
        /// 请求id
        /// </summary>
        [XmlElement("request_id")]
        public string RequestId { get; set; }

        /// <summary>
        /// 响应码
        /// </summary>
        [XmlElement("resp_code")]
        public long RespCode { get; set; }

        /// <summary>
        /// 用户标志，该值可能随机生成，不一定是UID
        /// </summary>
        [XmlElement("site_user_id")]
        public string SiteUserId { get; set; }
    }
}
