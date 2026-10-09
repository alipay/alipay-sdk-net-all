using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// XingheLendassistSiriusTaskCallbackResponse.
    /// </summary>
    public class XingheLendassistSiriusTaskCallbackResponse : AopResponse
    {
        /// <summary>
        /// 天狼星业务id
        /// </summary>
        [XmlElement("biz_id")]
        public string BizId { get; set; }

        /// <summary>
        /// 渠道码
        /// </summary>
        [XmlElement("channel_code")]
        public string ChannelCode { get; set; }

        /// <summary>
        /// 响应消息
        /// </summary>
        [XmlElement("message")]
        public string Message { get; set; }

        /// <summary>
        /// 标识渠道任务如何处理
        /// </summary>
        [XmlElement("mode_code")]
        public string ModeCode { get; set; }

        /// <summary>
        /// 操作token
        /// </summary>
        [XmlElement("op_token")]
        public string OpToken { get; set; }

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
        /// 场景码，区分不同业务场景
        /// </summary>
        [XmlElement("scene_code")]
        public string SceneCode { get; set; }

        /// <summary>
        /// 天狼星应用id
        /// </summary>
        [XmlElement("sirius_app_id")]
        public string SiriusAppId { get; set; }

        /// <summary>
        /// 响应码
        /// </summary>
        [XmlElement("sirius_code")]
        public string SiriusCode { get; set; }

        /// <summary>
        /// 天狼星环境
        /// </summary>
        [XmlElement("sirius_env")]
        public string SiriusEnv { get; set; }

        /// <summary>
        /// 用户标志，该值可能随机生成，不一定是UID
        /// </summary>
        [XmlElement("site_user_id")]
        public string SiteUserId { get; set; }
    }
}
