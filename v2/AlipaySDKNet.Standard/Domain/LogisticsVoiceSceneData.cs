using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// LogisticsVoiceSceneData Data Structure.
    /// </summary>
    [Serializable]
    public class LogisticsVoiceSceneData : AopObject
    {
        /// <summary>
        /// 业务日期
        /// </summary>
        [XmlElement("biz_date")]
        public string BizDate { get; set; }

        /// <summary>
        /// 维度值
        /// </summary>
        [XmlElement("dim_key")]
        public string DimKey { get; set; }

        /// <summary>
        /// 维度类型
        /// </summary>
        [XmlElement("dim_type")]
        public string DimType { get; set; }

        /// <summary>
        /// 下发数量
        /// </summary>
        [XmlElement("dispatch_count")]
        public long DispatchCount { get; set; }

        /// <summary>
        /// 播放成功数量
        /// </summary>
        [XmlElement("play_success_count")]
        public long PlaySuccessCount { get; set; }

        /// <summary>
        /// 场景类型
        /// </summary>
        [XmlElement("scene_type")]
        public string SceneType { get; set; }

        /// <summary>
        /// 语音模板ID
        /// </summary>
        [XmlElement("voice_template_id")]
        public string VoiceTemplateId { get; set; }
    }
}
