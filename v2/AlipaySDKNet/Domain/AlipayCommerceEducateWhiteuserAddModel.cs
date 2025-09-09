using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceEducateWhiteuserAddModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceEducateWhiteuserAddModel : AopObject
    {
        /// <summary>
        /// 机构内标
        /// </summary>
        [XmlElement("inst_id")]
        public string InstId { get; set; }

        /// <summary>
        /// 需要添加白名单的花名册id
        /// </summary>
        [XmlElement("roster_id")]
        public string RosterId { get; set; }

        /// <summary>
        /// 白名单类型id列表
        /// </summary>
        [XmlArray("white_type_id")]
        [XmlArrayItem("string")]
        public List<string> WhiteTypeId { get; set; }
    }
}
