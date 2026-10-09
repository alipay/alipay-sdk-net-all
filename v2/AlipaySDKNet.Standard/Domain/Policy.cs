using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// Policy Data Structure.
    /// </summary>
    [Serializable]
    public class Policy : AopObject
    {
        /// <summary>
        /// 如果是多航段打包规则，传入一个：-1
        /// </summary>
        [XmlElement("airline_no")]
        public string AirlineNo { get; set; }

        /// <summary>
        /// 退订/改签政策列表
        /// </summary>
        [XmlArray("policies")]
        [XmlArrayItem("policy_detail")]
        public List<PolicyDetail> Policies { get; set; }

        /// <summary>
        /// 三个大类： ● 1：不可退票（无论何时都是100%手续费） ● 2：免费退票（无论何时都是0%手续费） ● 3：有条件退票（根据时间划分不同的收费阶梯）
        /// </summary>
        [XmlElement("type")]
        public string Type { get; set; }
    }
}
