using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// NursingVO Data Structure.
    /// </summary>
    [Serializable]
    public class NursingVO : AopObject
    {
        /// <summary>
        /// 履约单号
        /// </summary>
        [XmlElement("fulfillment_no")]
        public string FulfillmentNo { get; set; }

        /// <summary>
        /// 履约状态
        /// </summary>
        [XmlElement("fulfillment_status")]
        public string FulfillmentStatus { get; set; }

        /// <summary>
        /// 履约状态描述
        /// </summary>
        [XmlElement("fulfillment_status_desc")]
        public string FulfillmentStatusDesc { get; set; }

        /// <summary>
        /// 履约类型
        /// </summary>
        [XmlElement("fulfillment_type")]
        public string FulfillmentType { get; set; }

        /// <summary>
        /// 商品编码
        /// </summary>
        [XmlElement("item_code")]
        public string ItemCode { get; set; }

        /// <summary>
        /// 患者年龄
        /// </summary>
        [XmlElement("patient_age")]
        public string PatientAge { get; set; }

        /// <summary>
        /// 患者性别
        /// </summary>
        [XmlElement("patient_gender")]
        public string PatientGender { get; set; }

        /// <summary>
        /// 患者ID
        /// </summary>
        [XmlElement("patient_id")]
        public string PatientId { get; set; }

        /// <summary>
        /// 患者姓名
        /// </summary>
        [XmlElement("patient_name")]
        public string PatientName { get; set; }

        /// <summary>
        /// 患者电话
        /// </summary>
        [XmlElement("patient_phone")]
        public string PatientPhone { get; set; }

        /// <summary>
        /// 服务包ID
        /// </summary>
        [XmlElement("service_package_id")]
        public string ServicePackageId { get; set; }

        /// <summary>
        /// 服务包名称
        /// </summary>
        [XmlElement("service_package_name")]
        public string ServicePackageName { get; set; }
    }
}
