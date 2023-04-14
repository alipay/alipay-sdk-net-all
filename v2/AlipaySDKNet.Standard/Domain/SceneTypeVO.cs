using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// SceneTypeVO Data Structure.
    /// </summary>
    [Serializable]
    public class SceneTypeVO : AopObject
    {
        /// <summary>
        /// 创建人域名
        /// </summary>
        [XmlElement("creator")]
        public string Creator { get; set; }

        /// <summary>
        /// 创建人花名
        /// </summary>
        [XmlElement("creator_name")]
        public string CreatorName { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [XmlElement("gmt_create")]
        public string GmtCreate { get; set; }

        /// <summary>
        /// 更新时间
        /// </summary>
        [XmlElement("gmt_modified")]
        public string GmtModified { get; set; }

        /// <summary>
        /// 主键
        /// </summary>
        [XmlElement("id")]
        public long Id { get; set; }

        /// <summary>
        /// 最后修改人
        /// </summary>
        [XmlElement("last_moder")]
        public string LastModer { get; set; }

        /// <summary>
        /// 修改人域名
        /// </summary>
        [XmlElement("modifier")]
        public string Modifier { get; set; }

        /// <summary>
        /// 修改人花名
        /// </summary>
        [XmlElement("modifier_name")]
        public string ModifierName { get; set; }

        /// <summary>
        /// 场景code
        /// </summary>
        [XmlElement("scene_type_code")]
        public string SceneTypeCode { get; set; }

        /// <summary>
        /// 场景名称
        /// </summary>
        [XmlElement("scene_type_name")]
        public string SceneTypeName { get; set; }

        /// <summary>
        /// 场景状态，默认生效状态为pass
        /// </summary>
        [XmlElement("state")]
        public string State { get; set; }

        /// <summary>
        /// 租户ID
        /// </summary>
        [XmlElement("tnt_inst_id")]
        public string TntInstId { get; set; }
    }
}
