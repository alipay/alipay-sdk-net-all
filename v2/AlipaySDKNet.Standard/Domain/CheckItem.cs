using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// CheckItem Data Structure.
    /// </summary>
    [Serializable]
    public class CheckItem : AopObject
    {
        /// <summary>
        /// 执行科室
        /// </summary>
        [XmlElement("department")]
        public string Department { get; set; }

        /// <summary>
        /// 医生备注
        /// </summary>
        [XmlElement("doctor_remark")]
        public string DoctorRemark { get; set; }

        /// <summary>
        /// 院内目录返回商品ID，平台目录返回spuId
        /// </summary>
        [XmlElement("id")]
        public string Id { get; set; }

        /// <summary>
        /// 检查项目名称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 仅院内目录时返回
        /// </summary>
        [XmlElement("notice")]
        public string Notice { get; set; }

        /// <summary>
        /// 仅院内目录时返回
        /// </summary>
        [XmlElement("purposes")]
        public string Purposes { get; set; }

        /// <summary>
        /// HOSPITAL_LABORATORY：检验； HOSPITAL_EXAMINATION：检查
        /// </summary>
        [XmlElement("type")]
        public string Type { get; set; }
    }
}
