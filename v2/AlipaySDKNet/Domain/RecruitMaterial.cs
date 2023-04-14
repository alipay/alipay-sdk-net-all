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
        /// 提报的素材内容，json字符串，使用时需要把此字符串解析成json对象。 字段来源于“招商方案查询接口（https://opendocs.alipay.com/pre-open/02bhl7）”中返回的素材字段field。如：activityImage、contentId等。 字段类型mediaType包含：   IMAGE，图片类型   TEXT，文本类型   DATASOURCE，数据源类型， 如：内容ID（contentId）字段类型为DATASOURCE 字段取值：   图片（IMAGE）：     aftsFileId：“营销图片资源上传接口（https://opendocs.alipay.com/pre-open/02bhlj）”返回的图片唯一资源ID   文本（TEXT）：     text：文本内容   数据源（DATASOURCE）：     text：当前仅支持内容ID值，可通过“内容批量查询接口（https://opendocs.alipay.com/pre-apis/02lu12，仅供受邀用户使用）”查询内容ID。
        /// </summary>
        [XmlElement("data")]
        public string Data { get; set; }

        /// <summary>
        /// 对这个素材的描述，用于后续管理该素材
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
        /// 关联的报名主体ID。 enroll_scene_type是VOUCHER时，报名主体ID是activity_id； enroll_scene_type是MINI_APP时，报名主体ID是mini_app_id；
        /// </summary>
        [XmlElement("subject_id")]
        public string SubjectId { get; set; }
    }
}
