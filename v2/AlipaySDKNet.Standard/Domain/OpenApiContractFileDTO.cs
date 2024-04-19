using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// OpenApiContractFileDTO Data Structure.
    /// </summary>
    [Serializable]
    public class OpenApiContractFileDTO : AopObject
    {
        /// <summary>
        /// 合同名称
        /// </summary>
        [XmlElement("contract_name")]
        public string ContractName { get; set; }

        /// <summary>
        /// 合同定稿状态
        /// </summary>
        [XmlElement("contract_status")]
        public string ContractStatus { get; set; }

        /// <summary>
        /// 文件类型
        /// </summary>
        [XmlElement("contract_type")]
        public string ContractType { get; set; }

        /// <summary>
        /// 磋商合同卡片code
        /// </summary>
        [XmlElement("matter_contract_code")]
        public string MatterContractCode { get; set; }

        /// <summary>
        /// 合同分组号
        /// </summary>
        [XmlElement("num")]
        public string Num { get; set; }

        /// <summary>
        /// 合同文件子合同
        /// </summary>
        [XmlArray("sub_contract_file_results")]
        [XmlArrayItem("open_api_sub_contract_file_d_t_o")]
        public List<OpenApiSubContractFileDTO> SubContractFileResults { get; set; }
    }
}
