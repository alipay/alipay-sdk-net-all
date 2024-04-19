using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayEcoSignflowsDetailQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEcoSignflowsDetailQueryModel : AopObject
    {
        /// <summary>
        /// 流程id，通过 <a href ="https://opendocs.alipay.com/apis/api_50/alipay.eco.contract.signflows.create">创建电子合同签署流程</a>(alipay.eco.contract.signflows.create)接口获取。
        /// </summary>
        [XmlElement("flow_id")]
        public string FlowId { get; set; }
    }
}
