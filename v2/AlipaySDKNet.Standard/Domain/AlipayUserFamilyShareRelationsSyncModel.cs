using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayUserFamilyShareRelationsSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayUserFamilyShareRelationsSyncModel : AopObject
    {
        /// <summary>
        /// 共享关系过期时间
        /// </summary>
        [XmlElement("expired_date")]
        public string ExpiredDate { get; set; }

        /// <summary>
        /// 共享资源的内容，例如卡号、协议号
        /// </summary>
        [XmlElement("resource_content")]
        public string ResourceContent { get; set; }

        /// <summary>
        /// 共享关系接入资源
        /// </summary>
        [XmlElement("resource_id")]
        public string ResourceId { get; set; }

        /// <summary>
        /// 共享关系接入场景
        /// </summary>
        [XmlElement("scene_id")]
        public string SceneId { get; set; }

        /// <summary>
        /// 共享账号的列表
        /// </summary>
        [XmlArray("sharing_user_ids")]
        [XmlArrayItem("string")]
        public List<string> SharingUserIds { get; set; }

        /// <summary>
        /// 共享账号类型 ALIPAY 、HAVANA、ARCHIVE
        /// </summary>
        [XmlElement("sharing_user_type")]
        public string SharingUserType { get; set; }

        /// <summary>
        /// 目标状态
        /// </summary>
        [XmlElement("target_status")]
        public long TargetStatus { get; set; }

        /// <summary>
        /// 更新时间
        /// </summary>
        [XmlElement("update_date")]
        public string UpdateDate { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }

        /// <summary>
        /// 关系变更版本号
        /// </summary>
        [XmlElement("version_no")]
        public string VersionNo { get; set; }
    }
}
