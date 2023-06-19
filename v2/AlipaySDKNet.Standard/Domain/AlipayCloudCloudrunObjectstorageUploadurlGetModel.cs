using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCloudCloudrunObjectstorageUploadurlGetModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCloudCloudrunObjectstorageUploadurlGetModel : AopObject
    {
        /// <summary>
        /// 环境ID
        /// </summary>
        [XmlElement("env")]
        public string Env { get; set; }

        /// <summary>
        /// 文件上传路径
        /// </summary>
        [XmlElement("path")]
        public string Path { get; set; }
    }
}
