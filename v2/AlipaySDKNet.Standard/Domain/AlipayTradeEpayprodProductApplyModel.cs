using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayTradeEpayprodProductApplyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayTradeEpayprodProductApplyModel : AopObject
    {
        /// <summary>
        /// 合作模式：PLATFORM_BUSINESS_MODE（直付通）
        /// </summary>
        [XmlElement("cooperation_mode")]
        public string CooperationMode { get; set; }

        /// <summary>
        /// 合作商户信息
        /// </summary>
        [XmlElement("partner_info")]
        public PartnerDTO PartnerInfo { get; set; }

        /// <summary>
        /// 解决方案码，不固定，联系业务分配
        /// </summary>
        [XmlElement("pay_solution")]
        public string PaySolution { get; set; }
    }
}
