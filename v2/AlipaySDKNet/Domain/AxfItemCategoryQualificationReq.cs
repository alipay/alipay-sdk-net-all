using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AxfItemCategoryQualificationReq Data Structure.
    /// </summary>
    [Serializable]
    public class AxfItemCategoryQualificationReq : AopObject
    {
        /// <summary>
        /// null
        /// </summary>
        [XmlArray("attachment_ids")]
        [XmlArrayItem("string")]
        public List<string> AttachmentIds { get; set; }

        /// <summary>
        /// 法人身份证号
        /// </summary>
        [XmlElement("legal_cert_no")]
        public string LegalCertNo { get; set; }

        /// <summary>
        /// 法人身份证
        /// </summary>
        [XmlElement("legal_name")]
        public string LegalName { get; set; }

        /// <summary>
        /// 营业执照号
        /// </summary>
        [XmlElement("org_cert_no")]
        public string OrgCertNo { get; set; }

        /// <summary>
        /// 资质内容。参考类目模版响应接口所需资质参数描述。如果需要图片先走图片上传接口获取图片id 当前字段已废弃(当前字段已废弃，请勿传入)
        /// </summary>
        [XmlElement("qualification_content")]
        public string QualificationContent { get; set; }

        /// <summary>
        /// 资质类型
        /// </summary>
        [XmlElement("qualification_type")]
        public string QualificationType { get; set; }
    }
}
