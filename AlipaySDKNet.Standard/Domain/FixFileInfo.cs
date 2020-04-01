using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// FixFileInfo Data Structure.
    /// </summary>
    [Serializable]
    public class FixFileInfo : AopObject
    {
        /// <summary>
        /// 附件的下载地址
        /// </summary>
        [XmlElement("download_url")]
        public string DownloadUrl { get; set; }

        /// <summary>
        /// 文件的id
        /// </summary>
        [XmlElement("id")]
        public long Id { get; set; }

        /// <summary>
        /// 文件名称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 文件类型。枚举，image:图片;video:视频
        /// </summary>
        [XmlElement("type")]
        public string Type { get; set; }
    }
}
