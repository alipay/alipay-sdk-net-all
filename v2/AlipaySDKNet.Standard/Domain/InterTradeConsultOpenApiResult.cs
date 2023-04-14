using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// InterTradeConsultOpenApiResult Data Structure.
    /// </summary>
    [Serializable]
    public class InterTradeConsultOpenApiResult : AopObject
    {
        /// <summary>
        /// 合约识别结果
        /// </summary>
        [XmlArray("contracts")]
        [XmlArrayItem("contract_consult_result_v_o")]
        public List<ContractConsultResultVO> Contracts { get; set; }

        /// <summary>
        /// 是否需要发起审批
        /// </summary>
        [XmlElement("need_approval")]
        public bool NeedApproval { get; set; }
    }
}
