using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ToppingsGroupInfo Data Structure.
    /// </summary>
    [Serializable]
    public class ToppingsGroupInfo : AopObject
    {
        /// <summary>
        /// 商品加料分组id
        /// </summary>
        [XmlElement("id")]
        public string Id { get; set; }

        /// <summary>
        /// 商品加料分组名称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 可选加料
        /// </summary>
        [XmlArray("optional_toppings")]
        [XmlArrayItem("toppings_info")]
        public List<ToppingsInfo> OptionalToppings { get; set; }

        /// <summary>
        /// 做法分组选择限制
        /// </summary>
        [XmlElement("restriction_info")]
        public GroupRestrictionInfo RestrictionInfo { get; set; }
    }
}
