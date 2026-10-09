using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ImgFile Data Structure.
    /// </summary>
    [Serializable]
    public class ImgFile : AopObject
    {
        /// <summary>
        /// 调用投诉文件上传接口返回的文件url
        /// </summary>
        [XmlElement("img_url")]
        public string ImgUrl { get; set; }

        /// <summary>
        /// 调用投诉文件上传接口返回的文件key
        /// </summary>
        [XmlElement("img_url_key")]
        public string ImgUrlKey { get; set; }
    }
}
