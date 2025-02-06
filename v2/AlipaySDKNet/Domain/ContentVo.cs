using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ContentVo Data Structure.
    /// </summary>
    [Serializable]
    public class ContentVo : AopObject
    {
        /// <summary>
        /// 消息类型为卡片时必传，卡片内容
        /// </summary>
        [XmlElement("card_content")]
        public string CardContent { get; set; }

        /// <summary>
        /// 消息类型为卡片时必传，卡片标题
        /// </summary>
        [XmlElement("card_title")]
        public string CardTitle { get; set; }

        /// <summary>
        /// 消息类型为卡片时必传
        /// </summary>
        [XmlElement("card_type")]
        public string CardType { get; set; }

        /// <summary>
        /// 消息类型为视频时必传-视频封面图片afts文件id （和cover_image_url二选一）
        /// </summary>
        [XmlElement("cover_image_file_id")]
        public string CoverImageFileId { get; set; }

        /// <summary>
        /// 消息类型为视频时必传
        /// </summary>
        [XmlElement("cover_image_url")]
        public string CoverImageUrl { get; set; }

        /// <summary>
        /// 自定义消息内容
        /// </summary>
        [XmlElement("custom_data_content")]
        public string CustomDataContent { get; set; }

        /// <summary>
        /// 自定义消息类型
        /// </summary>
        [XmlElement("custom_data_type")]
        public string CustomDataType { get; set; }

        /// <summary>
        /// 音视频播放时长，单位:秒（消息类型为音频、视频时必传）可以保留一位小数
        /// </summary>
        [XmlElement("duration")]
        public string Duration { get; set; }

        /// <summary>
        /// 消息类型为图片、音频、视频时必传
        /// </summary>
        [XmlElement("file_id")]
        public string FileId { get; set; }

        /// <summary>
        /// 消息类型为文本时必传
        /// </summary>
        [XmlElement("text")]
        public string Text { get; set; }

        /// <summary>
        /// 消息类型为图片、音频、视频时必传
        /// </summary>
        [XmlElement("url")]
        public string Url { get; set; }

        /// <summary>
        /// 消息类型为图片、音频、视频时必传
        /// </summary>
        [XmlElement("url_title")]
        public string UrlTitle { get; set; }
    }
}
