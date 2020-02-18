using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ContractConsultResultVO Data Structure.
    /// </summary>
    [Serializable]
    public class ContractConsultResultVO : AopObject
    {
        /// <summary>
        /// 合同号
        /// </summary>
        [XmlElement("contract_no")]
        public string ContractNo { get; set; }

        /// <summary>
        /// 是否需要审批
        /// </summary>
        [XmlElement("need_approval")]
        public bool NeedApproval { get; set; }
    }
}
