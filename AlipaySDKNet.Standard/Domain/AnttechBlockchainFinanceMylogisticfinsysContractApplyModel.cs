using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AnttechBlockchainFinanceMylogisticfinsysContractApplyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AnttechBlockchainFinanceMylogisticfinsysContractApplyModel : AopObject
    {
        /// <summary>
        /// 姓名
        /// </summary>
        [XmlElement("contract_name")]
        public string ContractName { get; set; }
    }
}
