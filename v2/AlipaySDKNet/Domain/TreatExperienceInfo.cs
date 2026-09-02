using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// TreatExperienceInfo Data Structure.
    /// </summary>
    [Serializable]
    public class TreatExperienceInfo : AopObject
    {
        /// <summary>
        /// 疾病治疗数量
        /// </summary>
        [XmlElement("count")]
        public string Count { get; set; }

        /// <summary>
        /// 标签跳转链接
        /// </summary>
        [XmlElement("detail_url")]
        public string DetailUrl { get; set; }

        /// <summary>
        /// 好大夫疾病id
        /// </summary>
        [XmlElement("disease_id")]
        public string DiseaseId { get; set; }

        /// <summary>
        /// 好大夫疾病名称
        /// </summary>
        [XmlElement("disease_name")]
        public string DiseaseName { get; set; }
    }
}
