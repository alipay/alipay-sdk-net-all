using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ShortPlayFrameFile Data Structure.
    /// </summary>
    [Serializable]
    public class ShortPlayFrameFile : AopObject
    {
        /// <summary>
        /// 第几季的第几集，例如第一季第15集记作1S_15
        /// </summary>
        [XmlElement("episode_num")]
        public string EpisodeNum { get; set; }

        /// <summary>
        /// 每一集的截帧图片压缩后将压缩文件上传得到的文件Id，每一集一个文件，同一集多次上传会被覆盖更新
        /// </summary>
        [XmlElement("file_id")]
        public string FileId { get; set; }
    }
}
