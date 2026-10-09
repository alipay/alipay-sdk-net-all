using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceMedicalInquiryExaminationSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMedicalInquiryExaminationSyncModel : AopObject
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
        /// 设备名称/分类
        /// </summary>
        [XmlElement("equipment_type")]
        public string EquipmentType { get; set; }

        /// <summary>
        /// 检查项目分类
        /// </summary>
        [XmlElement("examination_category")]
        public string ExaminationCategory { get; set; }

        /// <summary>
        /// 项目说明
        /// </summary>
        [XmlElement("examination_desc")]
        public string ExaminationDesc { get; set; }

        /// <summary>
        /// 原始检查项目ID
        /// </summary>
        [XmlElement("examination_id")]
        public string ExaminationId { get; set; }

        /// <summary>
        /// 原始检查项目名称
        /// </summary>
        [XmlElement("examination_name")]
        public string ExaminationName { get; set; }

        /// <summary>
        /// 检查部位
        /// </summary>
        [XmlElement("examination_site")]
        public string ExaminationSite { get; set; }

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
        /// 检查项目名称
        /// </summary>
        [XmlElement("standard_examination_name")]
        public string StandardExaminationName { get; set; }
    }
}
