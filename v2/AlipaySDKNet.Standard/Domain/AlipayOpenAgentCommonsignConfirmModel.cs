using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenAgentCommonsignConfirmModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenAgentCommonsignConfirmModel : AopObject
    {
        /// <summary>
        /// ISV 代商户操作事务编号，通过事务开启接口alipay.open.agent.create调用返回。
        /// </summary>
        [XmlElement("batch_no")]
        public string BatchNo { get; set; }
    }
}
