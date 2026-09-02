using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// UserPhotoInfo Data Structure.
    /// </summary>
    [Serializable]
    public class UserPhotoInfo : AopObject
    {
        /// <summary>
        /// 照片文件地址
        /// </summary>
        [XmlElement("file_url")]
        public string FileUrl { get; set; }

        /// <summary>
        /// 照片关键词
        /// </summary>
        [XmlElement("keyword")]
        public string Keyword { get; set; }
    }
}
