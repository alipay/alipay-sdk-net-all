using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// OpenApiContractInfoDTO Data Structure.
    /// </summary>
    [Serializable]
    public class OpenApiContractInfoDTO : AopObject
    {
        /// <summary>
        /// 合同号
        /// </summary>
        [XmlElement("contract_code")]
        public string ContractCode { get; set; }

        /// <summary>
        /// 合同详情url
        /// </summary>
        [XmlElement("detail_url")]
        public string DetailUrl { get; set; }
    }
}
