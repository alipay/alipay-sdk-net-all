using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenAgentOrderQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenAgentOrderQueryModel : AopObject
    {
        /// <summary>
        /// ISV 代商户操作事务编号，通过调用alipay.open.agent.create(开启代商户签约、创建应用事务)接口返回，详见 https://opendocs.alipay.com/apis/api_50/alipay.open.agent.create/ 。
        /// </summary>
        [XmlElement("batch_no")]
        public string BatchNo { get; set; }
    }
}
