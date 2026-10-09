using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MethodGroupInfo Data Structure.
    /// </summary>
    [Serializable]
    public class MethodGroupInfo : AopObject
    {
        /// <summary>
        /// 商品做法分组id
        /// </summary>
        [XmlElement("id")]
        public string Id { get; set; }

        /// <summary>
        /// 商品做法名称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 商品做法信息
        /// </summary>
        [XmlArray("optional_methods")]
        [XmlArrayItem("method_info")]
        public List<MethodInfo> OptionalMethods { get; set; }

        /// <summary>
        /// 商品分组选择限制
        /// </summary>
        [XmlElement("restriction_info")]
        public GroupRestrictionInfo RestrictionInfo { get; set; }
    }
}
