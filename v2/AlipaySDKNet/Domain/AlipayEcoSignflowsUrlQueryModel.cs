using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayEcoSignflowsUrlQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEcoSignflowsUrlQueryModel : AopObject
    {
        /// <summary>
        /// 流程id，通过 <a href ="https://opendocs.alipay.com/apis/api_50/alipay.eco.contract.signflows.create">创建电子合同签署流程</a>(alipay.eco.contract.signflows.create)接口获取。
        /// </summary>
        [XmlElement("flow_id")]
        public string FlowId { get; set; }

        /// <summary>
        /// 创建流程时指定企业唯一标识
        /// </summary>
        [XmlElement("org_third_party_user_id")]
        public string OrgThirdPartyUserId { get; set; }

        /// <summary>
        /// 创建流程时指定个人唯一标识
        /// </summary>
        [XmlElement("third_party_user_id")]
        public string ThirdPartyUserId { get; set; }
    }
}
