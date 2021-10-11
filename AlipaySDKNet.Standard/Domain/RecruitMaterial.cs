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
        /// 素材审核信息，展示给商家的素材审核不通过的意见。素材审核通过时该字段为空。 报名详情查询接口不用填写该字段。
        /// </summary>
        [XmlElement("material_audit_info")]
        public string MaterialAuditInfo { get; set; }

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
