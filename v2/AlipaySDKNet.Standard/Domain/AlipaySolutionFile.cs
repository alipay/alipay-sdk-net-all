using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipaySolutionFile Data Structure.
    /// </summary>
    [Serializable]
    public class AlipaySolutionFile : AopObject
    {
        /// <summary>
        /// 标识解决方案的数据提报中所需的文件类型
        /// </summary>
        [XmlElement("file_code")]
        public string FileCode { get; set; }

        /// <summary>
        /// 使用文件上传接口（alipay.open.file.upload）上传文件后返回的文件id
        /// </summary>
        [XmlElement("file_id")]
        public string FileId { get; set; }
    }
}
