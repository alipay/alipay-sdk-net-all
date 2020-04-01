using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ContractManagerAttachmentsSyncrequest Data Structure.
    /// </summary>
    [Serializable]
    public class ContractManagerAttachmentsSyncrequest : AopObject
    {
        /// <summary>
        /// 附件fileId
        /// </summary>
        [XmlElement("file_id")]
        public string FileId { get; set; }

        /// <summary>
        /// 附件名称
        /// </summary>
        [XmlElement("file_name")]
        public string FileName { get; set; }
    }
}
