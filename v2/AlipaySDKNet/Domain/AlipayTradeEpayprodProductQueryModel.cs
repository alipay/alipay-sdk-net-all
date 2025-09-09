using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayTradeEpayprodProductQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayTradeEpayprodProductQueryModel : AopObject
    {
        /// <summary>
        /// 合作模式
        /// </summary>
        [XmlElement("cooperation_mode")]
        public string CooperationMode { get; set; }

        /// <summary>
        /// 合作商户信息
        /// </summary>
        [XmlElement("partner_info")]
        public PartnerDTO PartnerInfo { get; set; }

        /// <summary>
        /// 解决方案标识
        /// </summary>
        [XmlElement("pay_solution")]
        public string PaySolution { get; set; }
    }
}
