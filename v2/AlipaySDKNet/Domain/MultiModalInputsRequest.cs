using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MultiModalInputsRequest Data Structure.
    /// </summary>
    [Serializable]
    public class MultiModalInputsRequest : AopObject
    {
        /// <summary>
        /// 当前对话音频信息
        /// </summary>
        [XmlElement("current_chat_audio")]
        public CurrentChatAudio CurrentChatAudio { get; set; }

        /// <summary>
        /// 当前对话多个音频
        /// </summary>
        [XmlElement("current_chat_audios")]
        public CurrentChatAudios CurrentChatAudios { get; set; }

        /// <summary>
        /// 当前对话单个文件信息
        /// </summary>
        [XmlElement("current_chat_file")]
        public CurrentChatFile CurrentChatFile { get; set; }

        /// <summary>
        /// 当前对话多个文件信息
        /// </summary>
        [XmlElement("current_chat_files")]
        public CurrentChatFiles CurrentChatFiles { get; set; }

        /// <summary>
        /// 当前对话单个视频信息
        /// </summary>
        [XmlElement("current_chat_video")]
        public CurrentChatVideo CurrentChatVideo { get; set; }

        /// <summary>
        /// 当前对话多个视频信息
        /// </summary>
        [XmlElement("current_chat_videos")]
        public CurrentChatVideos CurrentChatVideos { get; set; }

        /// <summary>
        /// 上传到atfs后的图片文件 ID 列表
        /// </summary>
        [XmlArray("images")]
        [XmlArrayItem("string")]
        public List<string> Images { get; set; }
    }
}
