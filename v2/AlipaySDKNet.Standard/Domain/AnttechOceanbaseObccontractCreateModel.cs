using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AnttechOceanbaseObccontractCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AnttechOceanbaseObccontractCreateModel : AopObject
    {
        /// <summary>
        /// 合同编码
        /// </summary>
        [XmlElement("contract_no")]
        public string ContractNo { get; set; }

        /// <summary>
        /// 初始化
        /// </summary>
        [XmlElement("event_type")]
        public string EventType { get; set; }

        /// <summary>
        /// 文件id
        /// </summary>
        [XmlElement("file_id")]
        public long FileId { get; set; }
    }
}
