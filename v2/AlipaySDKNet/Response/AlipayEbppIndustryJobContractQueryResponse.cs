using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayEbppIndustryJobContractQueryResponse.
    /// </summary>
    public class AlipayEbppIndustryJobContractQueryResponse : AopResponse
    {
        /// <summary>
        /// 合同状态：签署中，已签署，已失效
        /// </summary>
        [XmlElement("contract_status")]
        public string ContractStatus { get; set; }

        /// <summary>
        /// 合同下载地址，注：有1小时的时效性
        /// </summary>
        [XmlElement("download_url")]
        public string DownloadUrl { get; set; }

        /// <summary>
        /// 电子合同用户签署地址，企业已自动签署
        /// </summary>
        [XmlElement("sign_url")]
        public string SignUrl { get; set; }

        /// <summary>
        /// 电子合同上链后存证hash值
        /// </summary>
        [XmlElement("tx_hash")]
        public string TxHash { get; set; }
    }
}
