using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOverseasOpenAmountPreconsultModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOverseasOpenAmountPreconsultModel : AopObject
    {
        /// <summary>
        /// 机构信息
        /// </summary>
        [XmlElement("agent_info")]
        public TuitionISVAgentInfoDTO AgentInfo { get; set; }

        /// <summary>
        /// 原金额
        /// </summary>
        [XmlElement("original_amount")]
        public TuitionMoneyDTO OriginalAmount { get; set; }

        /// <summary>
        /// 外部参考号，由调用方生成
        /// </summary>
        [XmlElement("reference_id")]
        public string ReferenceId { get; set; }
    }
}
