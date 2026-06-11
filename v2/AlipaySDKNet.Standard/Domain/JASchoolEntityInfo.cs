using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// JASchoolEntityInfo Data Structure.
    /// </summary>
    [Serializable]
    public class JASchoolEntityInfo : AopObject
    {
        /// <summary>
        /// 小荷包ID
        /// </summary>
        [XmlElement("entity_id")]
        public string EntityId { get; set; }

        /// <summary>
        /// 小荷包创建时间
        /// </summary>
        [XmlElement("gmt_create")]
        public string GmtCreate { get; set; }

        /// <summary>
        /// 是否有成员
        /// </summary>
        [XmlElement("has_member")]
        public bool HasMember { get; set; }

        /// <summary>
        /// 校内额度是否将要到达临界值
        /// </summary>
        [XmlElement("in_school_alert")]
        public bool InSchoolAlert { get; set; }

        /// <summary>
        /// 校外额度是否将要到达临界值
        /// </summary>
        [XmlElement("out_school_alert")]
        public bool OutSchoolAlert { get; set; }

        /// <summary>
        /// 是否签约代扣
        /// </summary>
        [XmlElement("sign_withhold")]
        public bool SignWithhold { get; set; }

        /// <summary>
        /// 多人群升级时间
        /// </summary>
        [XmlElement("upgrade_time")]
        public string UpgradeTime { get; set; }
    }
}
