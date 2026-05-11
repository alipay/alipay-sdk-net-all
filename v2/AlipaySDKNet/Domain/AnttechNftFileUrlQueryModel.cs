using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AnttechNftFileUrlQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AnttechNftFileUrlQueryModel : AopObject
    {
        /// <summary>
        /// 文件id
        /// </summary>
        [XmlElement("file_id")]
        public string FileId { get; set; }

        /// <summary>
        /// 文件类型
        /// </summary>
        [XmlElement("file_type")]
        public string FileType { get; set; }

        /// <summary>
        /// true-私有url 其他为公开url默认false
        /// </summary>
        [XmlElement("is_private")]
        public string IsPrivate { get; set; }
    }
}
