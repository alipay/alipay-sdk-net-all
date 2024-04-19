using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AppGroupRelationshipExt Data Structure.
    /// </summary>
    [Serializable]
    public class AppGroupRelationshipExt : AopObject
    {
        /// <summary>
        /// APPID值
        /// </summary>
        [XmlElement("app_number")]
        public string AppNumber { get; set; }

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
        /// ID值
        /// </summary>
        [XmlElement("id")]
        public string Id { get; set; }
    }
}
