using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RecruitServingTargetCity Data Structure.
    /// </summary>
    [Serializable]
    public class RecruitServingTargetCity : AopObject
    {
        /// <summary>
        /// 是否全国。 与 city_codes 二选一。
        /// </summary>
        [XmlElement("all_city")]
        public bool AllCity { get; set; }

        /// <summary>
        /// 城市码列表。 与 all_city 二选一。 最大数量不超过999个。
        /// </summary>
        [XmlArray("city_codes")]
        [XmlArrayItem("string")]
        public List<string> CityCodes { get; set; }
    }
}
