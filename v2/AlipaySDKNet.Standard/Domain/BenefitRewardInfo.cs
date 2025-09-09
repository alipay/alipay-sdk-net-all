using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// BenefitRewardInfo Data Structure.
    /// </summary>
    [Serializable]
    public class BenefitRewardInfo : AopObject
    {
        /// <summary>
        /// 奖品编号
        /// </summary>
        [XmlElement("id")]
        public string Id { get; set; }

        /// <summary>
        /// 外部奖品编号，由业务运营定义
        /// </summary>
        [XmlElement("out_right_id")]
        public string OutRightId { get; set; }

        /// <summary>
        /// 奖品列表
        /// </summary>
        [XmlArray("right_list")]
        [XmlArrayItem("benefit_right")]
        public List<BenefitRight> RightList { get; set; }
    }
}
