using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ZhimaCreditEpSiriusTaskCallbackModel Data Structure.
    /// </summary>
    [Serializable]
    public class ZhimaCreditEpSiriusTaskCallbackModel : AopObject
    {
        /// <summary>
        /// 天狼星业务id，通常是天狼星任务主键id
        /// </summary>
        [XmlElement("biz_id")]
        public string BizId { get; set; }

        /// <summary>
        /// 来源
        /// </summary>
        [XmlElement("ch_info")]
        public string ChInfo { get; set; }

        /// <summary>
        /// 渠道码
        /// </summary>
        [XmlElement("channel_code")]
        public string ChannelCode { get; set; }

        /// <summary>
        /// 请求码
        /// </summary>
        [XmlElement("code")]
        public string Code { get; set; }

        /// <summary>
        /// 扩展信息，包含邮箱类型字段，不同模式，字段可能不一样
        /// </summary>
        [XmlElement("ext")]
        public string Ext { get; set; }

        /// <summary>
        /// 文件Id
        /// </summary>
        [XmlElement("file_id")]
        public string FileId { get; set; }

        /// <summary>
        /// 压测标识
        /// </summary>
        [XmlElement("load_test")]
        public string LoadTest { get; set; }

        /// <summary>
        /// 日志文件id
        /// </summary>
        [XmlElement("log_file_id")]
        public string LogFileId { get; set; }

        /// <summary>
        /// 操作消息
        /// </summary>
        [XmlElement("message")]
        public string Message { get; set; }

        /// <summary>
        /// 标识渠道任务如何处理
        /// </summary>
        [XmlElement("mode_code")]
        public string ModeCode { get; set; }

        /// <summary>
        /// 操作消息
        /// </summary>
        [XmlElement("msg")]
        public string Msg { get; set; }

        /// <summary>
        /// 操作token
        /// </summary>
        [XmlElement("op_token")]
        public string OpToken { get; set; }

        /// <summary>
        /// 任务结果内容，包含失败原因、发送时间、来源地址、应用标识、开始结束时间、任务id等
        /// </summary>
        [XmlElement("payload")]
        public string Payload { get; set; }

        /// <summary>
        /// 模板内容，包含文件行数、场景码、渠道码等
        /// </summary>
        [XmlElement("payload_template_std_content")]
        public string PayloadTemplateStdContent { get; set; }

        /// <summary>
        /// 重试次数
        /// </summary>
        [XmlElement("retry_times")]
        public string RetryTimes { get; set; }

        /// <summary>
        /// 场景码，区分不同业务场景
        /// </summary>
        [XmlElement("scene_code")]
        public string SceneCode { get; set; }

        /// <summary>
        /// 天狼星应用Id标识
        /// </summary>
        [XmlElement("sirius_app_id")]
        public string SiriusAppId { get; set; }

        /// <summary>
        /// 请求码
        /// </summary>
        [XmlElement("sirius_code")]
        public string SiriusCode { get; set; }

        /// <summary>
        /// 天狼星环境
        /// </summary>
        [XmlElement("sirius_env")]
        public string SiriusEnv { get; set; }

        /// <summary>
        /// 天狼星来源，1=行业云天狼星
        /// </summary>
        [XmlElement("sirius_source")]
        public string SiriusSource { get; set; }

        /// <summary>
        /// 用户标志，该值随机生成，不是UID
        /// </summary>
        [XmlElement("site_user_id")]
        public string SiteUserId { get; set; }

        /// <summary>
        /// 源文件Id
        /// </summary>
        [XmlElement("source_file_id")]
        public string SourceFileId { get; set; }

        /// <summary>
        /// 天狼星任务输入内容，包含来源邮箱地址、发送时间等
        /// </summary>
        [XmlElement("task_payload")]
        public string TaskPayload { get; set; }
    }
}
