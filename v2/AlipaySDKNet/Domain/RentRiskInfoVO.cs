using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RentRiskInfoVO Data Structure.
    /// </summary>
    [Serializable]
    public class RentRiskInfoVO : AopObject
    {
        /// <summary>
        /// null
        /// </summary>
        [XmlArray("risk_item_list")]
        [XmlArrayItem("risk_item_v_o")]
        public List<RiskItemVO> RiskItemList { get; set; }

        /// <summary>
        /// 风险类型
        /// </summary>
        [XmlElement("risk_type")]
        public string RiskType { get; set; }
    }
}
