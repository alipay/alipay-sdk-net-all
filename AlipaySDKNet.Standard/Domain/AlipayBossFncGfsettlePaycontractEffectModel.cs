using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayBossFncGfsettlePaycontractEffectModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayBossFncGfsettlePaycontractEffectModel : AopObject
    {
        /// <summary>
        /// 付款条款
        /// </summary>
        [XmlElement("paycontract")]
        public PayContractDTO Paycontract { get; set; }
    }
}
