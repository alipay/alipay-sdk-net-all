using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// OpenApiContractFileSaDTO Data Structure.
    /// </summary>
    [Serializable]
    public class OpenApiContractFileSaDTO : AopObject
    {
        /// <summary>
        /// 合同文件名
        /// </summary>
        [XmlElement("file_name")]
        public string FileName { get; set; }

        /// <summary>
        /// 文件下载的http链接
        /// </summary>
        [XmlElement("file_url")]
        public string FileUrl { get; set; }
    }
}
