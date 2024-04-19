using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// OpenApiContractFileMsgDTO Data Structure.
    /// </summary>
    [Serializable]
    public class OpenApiContractFileMsgDTO : AopObject
    {
        /// <summary>
        /// 文件类型，附件或合同
        /// </summary>
        [XmlElement("contract_type")]
        public string ContractType { get; set; }

        /// <summary>
        /// 文件名称
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
