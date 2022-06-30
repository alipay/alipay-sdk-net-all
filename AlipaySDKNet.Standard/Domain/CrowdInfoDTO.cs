using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// CrowdInfoDTO Data Structure.
    /// </summary>
    [Serializable]
    public class CrowdInfoDTO : AopObject
    {
        /// <summary>
        /// 人群创建时间+不唯一
        /// </summary>
        [XmlElement("create_time")]
        public string CreateTime { get; set; }

        /// <summary>
        /// 创建人ID+唯一
        /// </summary>
        [XmlElement("creator_id")]
        public string CreatorId { get; set; }

        /// <summary>
        /// 创建人+不唯一
        /// </summary>
        [XmlElement("creator_name")]
        public string CreatorName { get; set; }

        /// <summary>
        /// 人群名称+不唯一
        /// </summary>
        [XmlElement("crowd_name")]
        public string CrowdName { get; set; }

        /// <summary>
        /// 人群大小+不唯一
        /// </summary>
        [XmlElement("crowd_num")]
        public long CrowdNum { get; set; }

        /// <summary>
        /// 人群有效时间+不唯一
        /// </summary>
        [XmlElement("effective_time")]
        public string EffectiveTime { get; set; }

        /// <summary>
        /// 人群外部key+唯一
        /// </summary>
        [XmlElement("ext_crowd_key")]
        public string ExtCrowdKey { get; set; }

        /// <summary>
        /// 人群ID+唯一
        /// </summary>
        [XmlElement("id")]
        public long Id { get; set; }

        /// <summary>
        /// 人群状态+不唯一
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 人群创建方式+不唯一
        /// </summary>
        [XmlElement("type")]
        public string Type { get; set; }

        /// <summary>
        /// 人群更新时间+不唯一
        /// </summary>
        [XmlElement("update_time")]
        public string UpdateTime { get; set; }
    }
}
