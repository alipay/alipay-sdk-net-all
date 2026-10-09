using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// StandardBailDTO Data Structure.
    /// </summary>
    [Serializable]
    public class StandardBailDTO : AopObject
    {
        /// <summary>
        /// 保证金剩余可用余额
        /// </summary>
        [XmlElement("amount")]
        public string Amount { get; set; }

        /// <summary>
        /// 保证金状态。NORMAL——正常，MIGRATED——已迁移
        /// </summary>
        [XmlElement("bail_status")]
        public string BailStatus { get; set; }

        /// <summary>
        /// 保证金主单创建时间，格式YYYY-MM-DD HH:MM:SS
        /// </summary>
        [XmlElement("gmt_create")]
        public string GmtCreate { get; set; }

        /// <summary>
        /// 保证金主单最后修改时间，格式YYYY-MM-DD HH:MM:SS
        /// </summary>
        [XmlElement("gmt_modified")]
        public string GmtModified { get; set; }

        /// <summary>
        /// 迁移信息，仅已迁移的保证金携带。 格式：迁移后的保证金预授权号|流水号
        /// </summary>
        [XmlElement("migrate_to")]
        public string MigrateTo { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 平台uid
        /// </summary>
        [XmlElement("partner_open_id")]
        public string PartnerOpenId { get; set; }

        /// <summary>
        /// 平台uid
        /// </summary>
        [XmlElement("partner_user_id")]
        public string PartnerUserId { get; set; }

        /// <summary>
        /// 场景码描述（可能存在多个，用逗号分隔）
        /// </summary>
        [XmlElement("scene_desc")]
        public string SceneDesc { get; set; }

        /// <summary>
        /// 保证金typecode
        /// </summary>
        [XmlElement("type_code")]
        public string TypeCode { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
