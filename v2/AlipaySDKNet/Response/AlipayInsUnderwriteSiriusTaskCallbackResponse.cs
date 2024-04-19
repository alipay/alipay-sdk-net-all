using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayInsUnderwriteSiriusTaskCallbackResponse.
    /// </summary>
    public class AlipayInsUnderwriteSiriusTaskCallbackResponse : AopResponse
    {
        /// <summary>
        /// 天狼星业务id，通常是天狼星任务主键id
        /// </summary>
        [XmlElement("biz_id")]
        public string BizId { get; set; }

        /// <summary>
        /// 渠道码
        /// </summary>
        [XmlElement("channel_code")]
        public string ChannelCode { get; set; }

        /// <summary>
        /// 扩展信息，包含邮箱类型字段
        /// </summary>
        [XmlElement("ext")]
        public string Ext { get; set; }

        /// <summary>
        /// 消息
        /// </summary>
        [XmlElement("message")]
        public string Message { get; set; }

        /// <summary>
        /// 标识渠道任务如何处理
        /// </summary>
        [XmlElement("mode_code")]
        public string ModeCode { get; set; }

        /// <summary>
        /// 单次操作token，用于鉴权
        /// </summary>
        [XmlElement("op_token")]
        public string OpToken { get; set; }

        /// <summary>
        /// 场景码
        /// </summary>
        [XmlElement("scene_code")]
        public string SceneCode { get; set; }

        /// <summary>
        /// 天狼星应用Id标识
        /// </summary>
        [XmlElement("sirius_app_id")]
        public string SiriusAppId { get; set; }

        /// <summary>
        /// 响应码，0=成功
        /// </summary>
        [XmlElement("sirius_code")]
        public string SiriusCode { get; set; }

        /// <summary>
        /// 天狼星环境
        /// </summary>
        [XmlElement("sirius_env")]
        public string SiriusEnv { get; set; }
    }
}
