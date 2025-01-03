using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayBossProdContractArchiveSaveModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayBossProdContractArchiveSaveModel : AopObject
    {
        /// <summary>
        /// 合同号
        /// </summary>
        [XmlElement("contract_code")]
        public string ContractCode { get; set; }

        /// <summary>
        /// 合同文件
        /// </summary>
        [XmlArray("contract_files")]
        [XmlArrayItem("open_api_contract_file_sa_d_t_o")]
        public List<OpenApiContractFileSaDTO> ContractFiles { get; set; }

        /// <summary>
        /// 租户
        /// </summary>
        [XmlElement("tenant")]
        public string Tenant { get; set; }

        /// <summary>
        /// 业务幂等键，由业务自行决定
        /// </summary>
        [XmlElement("voucher_id")]
        public string VoucherId { get; set; }
    }
}
