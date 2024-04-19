using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// BsEnrollablePlan Data Structure.
    /// </summary>
    [Serializable]
    public class BsEnrollablePlan : AopObject
    {
        /// <summary>
        /// 联营计划信息
        /// </summary>
        [XmlElement("plan_detail")]
        public BsBrandPlanDetail PlanDetail { get; set; }

        /// <summary>
        /// 计划下的权益信息
        /// </summary>
        [XmlArray("supply_info_list")]
        [XmlArrayItem("bs_supply_info")]
        public List<BsSupplyInfo> SupplyInfoList { get; set; }
    }
}
