using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// CommunityPartnerRelaData Data Structure.
    /// </summary>
    [Serializable]
    public class CommunityPartnerRelaData : AopObject
    {
        /// <summary>
        /// 关系对象业务数据
        /// </summary>
        [XmlElement("biz_data")]
        public string BizData { get; set; }

        /// <summary>
        /// 关系类型
        /// </summary>
        [XmlElement("rela_type")]
        public string RelaType { get; set; }

        /// <summary>
        /// 来源对象id
        /// </summary>
        [XmlElement("source_id")]
        public string SourceId { get; set; }

        /// <summary>
        /// 目标对象id
        /// </summary>
        [XmlElement("target_id")]
        public string TargetId { get; set; }
    }
}
