using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceRentEnterpriseSealQuerystatusModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceRentEnterpriseSealQuerystatusModel : AopObject
    {
        /// <summary>
        /// 业务流水号
        /// </summary>
        [XmlElement("biz_no")]
        public string BizNo { get; set; }

        /// <summary>
        /// 签署合同id
        /// </summary>
        [XmlElement("sign_flow_id")]
        public string SignFlowId { get; set; }
    }
}
