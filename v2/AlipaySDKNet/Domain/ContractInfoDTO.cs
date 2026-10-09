using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ContractInfoDTO Data Structure.
    /// </summary>
    [Serializable]
    public class ContractInfoDTO : AopObject
    {
        /// <summary>
        /// 合约ID
        /// </summary>
        [XmlElement("ar_id")]
        public string ArId { get; set; }

        /// <summary>
        /// 合同号
        /// </summary>
        [XmlArray("contract_info_no")]
        [XmlArrayItem("string")]
        public List<string> ContractInfoNo { get; set; }

        /// <summary>
        /// 合同附件信息
        /// </summary>
        [XmlArray("files")]
        [XmlArrayItem("collection_file_d_t_o")]
        public List<CollectionFileDTO> Files { get; set; }

        /// <summary>
        /// 发票和开票日期
        /// </summary>
        [XmlArray("invoicing_no_and_date")]
        [XmlArrayItem("invoicing_no_and_date")]
        public List<InvoicingNoAndDate> InvoicingNoAndDate { get; set; }

        /// <summary>
        /// ["sda.docx"]
        /// </summary>
        [XmlArray("other_files")]
        [XmlArrayItem("collection_file_d_t_o")]
        public List<CollectionFileDTO> OtherFiles { get; set; }
    }
}
