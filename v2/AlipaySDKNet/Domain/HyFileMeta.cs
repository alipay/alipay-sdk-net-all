using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// HyFileMeta Data Structure.
    /// </summary>
    [Serializable]
    public class HyFileMeta : AopObject
    {
        /// <summary>
        /// 文件url
        /// </summary>
        [XmlElement("afts_file_url")]
        public string AftsFileUrl { get; set; }

        /// <summary>
        /// 视频码率，单位 kb/s
        /// </summary>
        [XmlElement("bitrate")]
        public long Bitrate { get; set; }

        /// <summary>
        /// 编码器名称
        /// </summary>
        [XmlElement("codec_long_name")]
        public string CodecLongName { get; set; }

        /// <summary>
        /// 视频编码格式
        /// </summary>
        [XmlElement("codec_name")]
        public string CodecName { get; set; }

        /// <summary>
        /// 创建时间时间戳
        /// </summary>
        [XmlElement("create_time")]
        public long CreateTime { get; set; }

        /// <summary>
        /// 视频/音频时常，秒
        /// </summary>
        [XmlElement("duration")]
        public string Duration { get; set; }

        /// <summary>
        /// 文件是否被加密存储
        /// </summary>
        [XmlElement("encrypt")]
        public bool Encrypt { get; set; }

        /// <summary>
        /// 文件id
        /// </summary>
        [XmlElement("file_id")]
        public string FileId { get; set; }

        /// <summary>
        /// 文件名称
        /// </summary>
        [XmlElement("file_name")]
        public string FileName { get; set; }

        /// <summary>
        /// 文件数据类型
        /// </summary>
        [XmlElement("file_type")]
        public long FileType { get; set; }

        /// <summary>
        /// 文件后缀名
        /// </summary>
        [XmlElement("format_name")]
        public string FormatName { get; set; }

        /// <summary>
        /// 单位：pt
        /// </summary>
        [XmlElement("height")]
        public long Height { get; set; }

        /// <summary>
        /// 文件md5
        /// </summary>
        [XmlElement("md5")]
        public string Md5 { get; set; }

        /// <summary>
        /// 单位：byte
        /// </summary>
        [XmlElement("size")]
        public long Size { get; set; }

        /// <summary>
        /// 视频总帧数
        /// </summary>
        [XmlElement("total_frames")]
        public long TotalFrames { get; set; }

        /// <summary>
        /// git总帧数
        /// </summary>
        [XmlElement("total_gif_frames")]
        public long TotalGifFrames { get; set; }

        /// <summary>
        /// 单位：pt
        /// </summary>
        [XmlElement("width")]
        public long Width { get; set; }
    }
}
