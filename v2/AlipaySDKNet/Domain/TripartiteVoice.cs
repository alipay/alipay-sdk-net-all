using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// TripartiteVoice Data Structure.
    /// </summary>
    [Serializable]
    public class TripartiteVoice : AopObject
    {
        /// <summary>
        /// anteye一级意图
        /// </summary>
        [XmlElement("anteye_intention_l_1")]
        public string AnteyeIntentionL1 { get; set; }

        /// <summary>
        /// anteye二级意图
        /// </summary>
        [XmlElement("anteye_intention_l_2")]
        public string AnteyeIntentionL2 { get; set; }

        /// <summary>
        /// anteye三级意图
        /// </summary>
        [XmlElement("anteye_intention_l_3")]
        public string AnteyeIntentionL3 { get; set; }

        /// <summary>
        /// 支付宝客户端版本
        /// </summary>
        [XmlElement("app_version")]
        public string AppVersion { get; set; }

        /// <summary>
        /// 业务日期，格式：yyyy-MM-dd
        /// </summary>
        [XmlElement("bus_date")]
        public string BusDate { get; set; }

        /// <summary>
        /// 城市
        /// </summary>
        [XmlElement("city")]
        public string City { get; set; }

        /// <summary>
        /// 客诉内容
        /// </summary>
        [XmlElement("content")]
        public string Content { get; set; }

        /// <summary>
        /// 内容摘要
        /// </summary>
        [XmlElement("content_abstract")]
        public string ContentAbstract { get; set; }

        /// <summary>
        /// 创建时间，格式：yyyy-MM-dd HH:mm:ss
        /// </summary>
        [XmlElement("gmt_create")]
        public string GmtCreate { get; set; }

        /// <summary>
        /// 机构处理完成时间，格式yyyy-MM-dd
        /// </summary>
        [XmlElement("handle_time")]
        public string HandleTime { get; set; }

        /// <summary>
        /// 线上模式(WiFi/5G/4G等)
        /// </summary>
        [XmlElement("online_mode")]
        public string OnlineMode { get; set; }

        /// <summary>
        /// 手机系统
        /// </summary>
        [XmlElement("phone_system")]
        public string PhoneSystem { get; set; }

        /// <summary>
        /// 问题类型
        /// </summary>
        [XmlElement("problem_type")]
        public string ProblemType { get; set; }

        /// <summary>
        /// 处理状态
        /// </summary>
        [XmlElement("process_status")]
        public string ProcessStatus { get; set; }

        /// <summary>
        /// 省份
        /// </summary>
        [XmlElement("province")]
        public string Province { get; set; }

        /// <summary>
        /// 处理说明（机构回推后填充）
        /// </summary>
        [XmlElement("reason")]
        public string Reason { get; set; }

        /// <summary>
        /// 客诉标题
        /// </summary>
        [XmlElement("title")]
        public string Title { get; set; }

        /// <summary>
        /// 支付宝用户的userId。
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }

        /// <summary>
        /// 原声渠道(如 EXP_VOICE_FEEDBACK)
        /// </summary>
        [XmlElement("voice_channel")]
        public string VoiceChannel { get; set; }

        /// <summary>
        /// 客权全局客诉ID
        /// </summary>
        [XmlElement("voice_id")]
        public string VoiceId { get; set; }
    }
}
