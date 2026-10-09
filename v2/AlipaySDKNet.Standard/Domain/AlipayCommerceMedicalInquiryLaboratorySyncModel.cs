using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceMedicalInquiryLaboratorySyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMedicalInquiryLaboratorySyncModel : AopObject
    {
        /// <summary>
        /// 数据状态
        /// </summary>
        [XmlElement("data_status")]
        public string DataStatus { get; set; }

        /// <summary>
        /// 数据版本号
        /// </summary>
        [XmlElement("data_version")]
        public string DataVersion { get; set; }

        /// <summary>
        /// 原始医院ID
        /// </summary>
        [XmlElement("hospital_id")]
        public string HospitalId { get; set; }

        /// <summary>
        /// 原始医院名称
        /// </summary>
        [XmlElement("hospital_name")]
        public string HospitalName { get; set; }

        /// <summary>
        /// 服务商编码
        /// </summary>
        [XmlElement("isv_code")]
        public string IsvCode { get; set; }

        /// <summary>
        /// 检验项目分类
        /// </summary>
        [XmlElement("laboratory_category")]
        public string LaboratoryCategory { get; set; }

        /// <summary>
        /// 项目说明
        /// </summary>
        [XmlElement("laboratory_desc")]
        public string LaboratoryDesc { get; set; }

        /// <summary>
        /// 原始检验项目ID
        /// </summary>
        [XmlElement("laboratory_id")]
        public string LaboratoryId { get; set; }

        /// <summary>
        /// 原始检验项目名称
        /// </summary>
        [XmlElement("laboratory_name")]
        public string LaboratoryName { get; set; }

        /// <summary>
        /// 是否组套项目
        /// </summary>
        [XmlElement("package_flag")]
        public string PackageFlag { get; set; }

        /// <summary>
        /// 组套项目名称
        /// </summary>
        [XmlElement("package_name")]
        public string PackageName { get; set; }

        /// <summary>
        /// 来源平台编码
        /// </summary>
        [XmlElement("platform_code")]
        public string PlatformCode { get; set; }

        /// <summary>
        /// 注意事项
        /// </summary>
        [XmlElement("precautions")]
        public string Precautions { get; set; }

        /// <summary>
        /// 参考范围：4.0-10.0*10^9/L
        /// </summary>
        [XmlElement("reference_range")]
        public string ReferenceRange { get; set; }

        /// <summary>
        /// 标本类型
        /// </summary>
        [XmlElement("specimen_type")]
        public string SpecimenType { get; set; }
    }
}
