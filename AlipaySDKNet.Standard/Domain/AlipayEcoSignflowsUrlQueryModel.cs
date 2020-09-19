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
        /// 流程id
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
