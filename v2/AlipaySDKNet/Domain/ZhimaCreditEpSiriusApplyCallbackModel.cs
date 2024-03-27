using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ZhimaCreditEpSiriusApplyCallbackModel Data Structure.
    /// </summary>
    [Serializable]
    public class ZhimaCreditEpSiriusApplyCallbackModel : AopObject
    {
        /// <summary>
        /// 申请单号
        /// </summary>
        [XmlElement("apply_no")]
        public string ApplyNo { get; set; }

        /// <summary>
        /// 申请单状态
        /// </summary>
        [XmlElement("apply_status")]
        public string ApplyStatus { get; set; }

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
        /// 加密信息标识
        /// </summary>
        [XmlElement("encrypted")]
        public string Encrypted { get; set; }

        /// <summary>
        /// 结果文件Id
        /// </summary>
        [XmlElement("file_id")]
        public string FileId { get; set; }

        /// <summary>
        /// 标识渠道任务如何处理
        /// </summary>
        [XmlElement("mode_code")]
        public string ModeCode { get; set; }

        /// <summary>
        /// 业务单号
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 任务结果对象，加密内容
        /// </summary>
        [XmlElement("payload")]
        public string Payload { get; set; }

        /// <summary>
        /// 请求id
        /// </summary>
        [XmlElement("request_id")]
        public string RequestId { get; set; }

        /// <summary>
        /// 重试次数，调用方网关统一使用字符串类型
        /// </summary>
        [XmlElement("retry_times")]
        public string RetryTimes { get; set; }

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
        /// 用户标志，该值可能随机生成，不一定是UID
        /// </summary>
        [XmlElement("site_user_id")]
        public string SiteUserId { get; set; }

        /// <summary>
        /// 源文件Id
        /// </summary>
        [XmlElement("source_file_id")]
        public string SourceFileId { get; set; }

        /// <summary>
        /// 任务入参，加密内容
        /// </summary>
        [XmlElement("task_payload")]
        public string TaskPayload { get; set; }
    }
}
