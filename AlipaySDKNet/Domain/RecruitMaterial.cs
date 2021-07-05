using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RecruitMaterial Data Structure.
    /// </summary>
    [Serializable]
    public class RecruitMaterial : AopObject
    {
        /// <summary>
        /// 提报的素材内容，json字符串，使用时需要把此字符串解析成json对象
        /// </summary>
        [XmlElement("data")]
        public string Data { get; set; }

        /// <summary>
        /// 素材描述
        /// </summary>
        [XmlElement("description")]
        public string Description { get; set; }

        /// <summary>
        /// 素材名名称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 关联的报名主体ID，目前都是activity_id
        /// </summary>
        [XmlElement("subject_id")]
        public string SubjectId { get; set; }
    }
}
