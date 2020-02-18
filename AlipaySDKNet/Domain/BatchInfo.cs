using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// BatchInfo Data Structure.
    /// </summary>
    [Serializable]
    public class BatchInfo : AopObject
    {
        /// <summary>
        /// 合同号
        /// </summary>
        [XmlElement("contract_no")]
        public string ContractNo { get; set; }

        /// <summary>
        /// 参与方列表（包括本方公司和对手方公司）
        /// </summary>
        [XmlArray("contract_partners")]
        [XmlArrayItem("inter_trade_contract_partner")]
        public List<InterTradeContractPartner> ContractPartners { get; set; }
    }
}
