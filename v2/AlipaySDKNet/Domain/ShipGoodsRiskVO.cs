using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ShipGoodsRiskVO Data Structure.
    /// </summary>
    [Serializable]
    public class ShipGoodsRiskVO : AopObject
    {
        /// <summary>
        /// true-建议发货 false-建议根据用户其他风险情况进行综合评估
        /// </summary>
        [XmlElement("can_ship_flag")]
        public bool CanShipFlag { get; set; }

        /// <summary>
        /// 发货建议类型,枚举值
        /// </summary>
        [XmlElement("risk_code")]
        public string RiskCode { get; set; }
    }
}
