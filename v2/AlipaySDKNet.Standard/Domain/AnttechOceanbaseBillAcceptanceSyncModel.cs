using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AnttechOceanbaseBillAcceptanceSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AnttechOceanbaseBillAcceptanceSyncModel : AopObject
    {
        /// <summary>
        /// 计财账单受理请求入参，支持批量list写入，strategyIdentity需要和OB计财系统约定，idempotentKey作为幂等键，保证不会重复，重复幂等会被拒绝，额外的扩展信息properties通过json的方式传入
        /// </summary>
        [XmlArray("obf_bill_acceptance_request")]
        [XmlArrayItem("obf_bill_acceptance_request")]
        public List<ObfBillAcceptanceRequest> ObfBillAcceptanceRequest { get; set; }
    }
}
