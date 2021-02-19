using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayBossFncGfsettlePaycontractCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayBossFncGfsettlePaycontractCreateModel : AopObject
    {
        /// <summary>
        /// 付款条款
        /// </summary>
        [XmlElement("paycontract")]
        public PayContractDTO Paycontract { get; set; }
    }
}
