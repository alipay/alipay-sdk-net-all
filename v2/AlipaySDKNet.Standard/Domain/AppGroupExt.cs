using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AppGroupExt Data Structure.
    /// </summary>
    [Serializable]
    public class AppGroupExt : AopObject
    {
        /// <summary>
        /// 多个描述GroupId关系的对象
        /// </summary>
        [XmlArray("app_group_relationship_ext")]
        [XmlArrayItem("app_group_relationship_ext")]
        public List<AppGroupRelationshipExt> AppGroupRelationshipExt { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [XmlElement("gmt_create")]
        public string GmtCreate { get; set; }

        /// <summary>
        /// 修改时间
        /// </summary>
        [XmlElement("gmt_modified")]
        public string GmtModified { get; set; }

        /// <summary>
        /// GROUPID值
        /// </summary>
        [XmlElement("group_id")]
        public string GroupId { get; set; }

        /// <summary>
        /// 分组名称
        /// </summary>
        [XmlElement("group_name")]
        public string GroupName { get; set; }

        /// <summary>
        /// OID值
        /// </summary>
        [XmlElement("owner_id")]
        public string OwnerId { get; set; }

        /// <summary>
        /// 所属类型
        /// </summary>
        [XmlElement("owner_type")]
        public string OwnerType { get; set; }
    }
}
