using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// InfraTemplateRuleResp Data Structure.
    /// </summary>
    [Serializable]
    public class InfraTemplateRuleResp : AopObject
    {
        /// <summary>
        /// 素材必传校验规则,如果值为MUST则代表必填,如果值为OPTIONAL则代表非必填
        /// </summary>
        [XmlElement("check_rule")]
        public string CheckRule { get; set; }

        /// <summary>
        /// 元素限制规则描述
        /// </summary>
        [XmlElement("desc")]
        public string Desc { get; set; }

        /// <summary>
        /// 高,单位为px(图片与视频的尺寸高度限制)
        /// </summary>
        [XmlElement("height")]
        public long Height { get; set; }

        /// <summary>
        /// 图片大小最大限制，限制单位：KB；  视频大小最大限制，限制单位：KB；  文本最大长度限制
        /// </summary>
        [XmlElement("max_size")]
        public long MaxSize { get; set; }

        /// <summary>
        /// 最低码率，单位为vbs(仅针对与视频)
        /// </summary>
        [XmlElement("min_bitrate")]
        public long MinBitrate { get; set; }

        /// <summary>
        /// 视频播放时长下限，单位为毫秒(仅针对与视频)
        /// </summary>
        [XmlElement("min_play_time")]
        public long MinPlayTime { get; set; }

        /// <summary>
        /// 文本长度最小限制(仅针对文本)
        /// </summary>
        [XmlElement("min_size")]
        public long MinSize { get; set; }

        /// <summary>
        /// 宽,单位为px(图片与视频的尺寸宽度限制)
        /// </summary>
        [XmlElement("width")]
        public long Width { get; set; }
    }
}
