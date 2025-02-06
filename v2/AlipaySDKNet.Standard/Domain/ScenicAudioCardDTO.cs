using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ScenicAudioCardDTO Data Structure.
    /// </summary>
    [Serializable]
    public class ScenicAudioCardDTO : AopObject
    {
        /// <summary>
        /// 语音讲解url
        /// </summary>
        [XmlElement("audio_url")]
        public string AudioUrl { get; set; }

        /// <summary>
        /// 景点图片url
        /// </summary>
        [XmlElement("img_url")]
        public string ImgUrl { get; set; }

        /// <summary>
        /// 卡片类型
        /// </summary>
        [XmlElement("row_type")]
        public string RowType { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("tags")]
        [XmlArrayItem("string")]
        public List<string> Tags { get; set; }

        /// <summary>
        /// 讲解卡片推荐文本
        /// </summary>
        [XmlElement("text")]
        public string Text { get; set; }

        /// <summary>
        /// 讲解卡片内容
        /// </summary>
        [XmlElement("title")]
        public string Title { get; set; }
    }
}
