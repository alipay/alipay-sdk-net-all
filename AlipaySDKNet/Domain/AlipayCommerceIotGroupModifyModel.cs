using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceIotGroupModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceIotGroupModifyModel : AopObject
    {
        /// <summary>
        /// 分组描述
        /// </summary>
        [XmlElement("description")]
        public string Description { get; set; }

        /// <summary>
        /// 分组的id
        /// </summary>
        [XmlElement("group_id")]
        public long GroupId { get; set; }

        /// <summary>
        /// 修改的分组名 不填表示不修改
        /// </summary>
        [XmlElement("group_name")]
        public string GroupName { get; set; }
    }
}
