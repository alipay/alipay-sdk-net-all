using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AxfItemCategoryQualification Data Structure.
    /// </summary>
    [Serializable]
    public class AxfItemCategoryQualification : AopObject
    {
        /// <summary>
        /// 通过支付宝文件上传接口上传获取文件id
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
        /// 资质参数描述
        /// </summary>
        [XmlElement("param_description")]
        public string ParamDescription { get; set; }

        /// <summary>
        /// 资质内容。参考类目模版响应接口所需资质参数描述。如果需要图片先走图片上传接口获取图片id 当前字段已废弃(当前字段已废弃，请勿传入)
        /// </summary>
        [XmlElement("qualification_content")]
        public string QualificationContent { get; set; }

        /// <summary>
        /// 资质名称
        /// </summary>
        [XmlElement("qualification_name")]
        public string QualificationName { get; set; }

        /// <summary>
        /// 资质类型
        /// </summary>
        [XmlElement("qualification_type")]
        public string QualificationType { get; set; }
    }
}
