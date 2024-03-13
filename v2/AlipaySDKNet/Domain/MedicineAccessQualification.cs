using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MedicineAccessQualification Data Structure.
    /// </summary>
    [Serializable]
    public class MedicineAccessQualification : AopObject
    {
        /// <summary>
        /// 医疗器械产品审批名称
        /// </summary>
        [XmlElement("access_qualification_approval_name")]
        public string AccessQualificationApprovalName { get; set; }

        /// <summary>
        /// 医疗器械准入资质类型
        /// </summary>
        [XmlElement("access_qualification_approval_type")]
        public string AccessQualificationApprovalType { get; set; }

        /// <summary>
        /// 医疗器械注册证编号
        /// </summary>
        [XmlElement("access_qualification_cert_no")]
        public string AccessQualificationCertNo { get; set; }

        /// <summary>
        /// 注册或备案证明审批部门
        /// </summary>
        [XmlElement("access_qualification_department")]
        public string AccessQualificationDepartment { get; set; }

        /// <summary>
        /// 注册/备案生效日期
        /// </summary>
        [XmlElement("access_qualification_effective_date")]
        public string AccessQualificationEffectiveDate { get; set; }

        /// <summary>
        /// 注册/备案有效期至
        /// </summary>
        [XmlElement("access_qualification_expiration_date")]
        public string AccessQualificationExpirationDate { get; set; }

        /// <summary>
        /// 通过图片文件上传接口上传图片后获取文件Id
        /// </summary>
        [XmlElement("access_qualification_image")]
        public string AccessQualificationImage { get; set; }

        /// <summary>
        /// 注册人或备案人信息
        /// </summary>
        [XmlElement("access_qualification_person")]
        public string AccessQualificationPerson { get; set; }
    }
}
