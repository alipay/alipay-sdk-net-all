using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// FinanceFileInfo Data Structure.
    /// </summary>
    [Serializable]
    public class FinanceFileInfo : AopObject
    {
        /// <summary>
        /// 上传文件生成的唯一id
        /// </summary>
        [XmlElement("file_id")]
        public string FileId { get; set; }

        /// <summary>
        /// 用于路由文件路径的key
        /// </summary>
        [XmlElement("file_key")]
        public string FileKey { get; set; }
    }
}
