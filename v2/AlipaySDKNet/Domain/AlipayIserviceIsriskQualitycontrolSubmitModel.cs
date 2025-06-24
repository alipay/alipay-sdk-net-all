using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayIserviceIsriskQualitycontrolSubmitModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayIserviceIsriskQualitycontrolSubmitModel : AopObject
    {
        /// <summary>
        /// 业务唯一标识id
        /// </summary>
        [XmlElement("biz_id")]
        public string BizId { get; set; }

        /// <summary>
        /// 用于区分质检的类型
        /// </summary>
        [XmlElement("function_type")]
        public string FunctionType { get; set; }

        /// <summary>
        /// 调用实例code，由蚂蚁侧提供
        /// </summary>
        [XmlElement("instance_code")]
        public string InstanceCode { get; set; }

        /// <summary>
        /// 需要质检的小二1088id
        /// </summary>
        [XmlElement("nebula_id")]
        public string NebulaId { get; set; }

        /// <summary>
        /// 离线文本质检的请求参数
        /// </summary>
        [XmlElement("offline_text_qc")]
        public OfflineTextQc OfflineTextQc { get; set; }

        /// <summary>
        /// 实时文本质检的参数
        /// </summary>
        [XmlElement("realtime_text_qc")]
        public RealtimeTextQc RealtimeTextQc { get; set; }

        /// <summary>
        /// 录音url集合
        /// </summary>
        [XmlArray("recording_urls")]
        [XmlArrayItem("string")]
        public List<string> RecordingUrls { get; set; }

        /// <summary>
        /// 技能组id，可传入星云技能组或业务技能组
        /// </summary>
        [XmlElement("skill_group_id")]
        public string SkillGroupId { get; set; }

        /// <summary>
        /// 是星云的技能组还是外部的技能组
        /// </summary>
        [XmlElement("skill_group_type")]
        public string SkillGroupType { get; set; }

        /// <summary>
        /// 调用方租户id
        /// </summary>
        [XmlElement("tnt_inst_id")]
        public string TntInstId { get; set; }
    }
}
