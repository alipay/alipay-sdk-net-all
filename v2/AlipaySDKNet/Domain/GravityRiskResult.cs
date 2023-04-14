using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// GravityRiskResult Data Structure.
    /// </summary>
    [Serializable]
    public class GravityRiskResult : AopObject
    {
        /// <summary>
        /// 参数名：risk_rank+是否唯一：无需唯一+应用场景：多方安全风控风险咨询风险类型的风险等级标签+枚举：无枚举+如何获取：多方安全风控通过对应数据产品介绍文档获取+特殊说明：无
        /// </summary>
        [XmlElement("risk_rank")]
        public string RiskRank { get; set; }

        /// <summary>
        /// 参数名：risk_tag+是否唯一：无需唯一+应用场景：多方安全风控风险咨询结果中用于表示返回的风险标签名称+枚举：无枚举+如何获取：多方安全风控通过对应数据产品介绍文档获取+特殊说明：无
        /// </summary>
        [XmlElement("risk_tag")]
        public string RiskTag { get; set; }
    }
}
