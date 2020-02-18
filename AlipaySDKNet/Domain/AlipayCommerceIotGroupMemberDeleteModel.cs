using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceIotGroupMemberDeleteModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceIotGroupMemberDeleteModel : AopObject
    {
        /// <summary>
        /// 分组id
        /// </summary>
        [XmlElement("group_id")]
        public string GroupId { get; set; }

        /// <summary>
        /// sn列表
        /// </summary>
        [XmlArray("sn_list")]
        [XmlArrayItem("string")]
        public List<string> SnList { get; set; }
    }
}
