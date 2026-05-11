using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// Consultation Data Structure.
    /// </summary>
    [Serializable]
    public class Consultation : AopObject
    {
        /// <summary>
        /// 端类型字段，文本非枚举
        /// </summary>
        [XmlElement("app_type")]
        public string AppType { get; set; }

        /// <summary>
        /// 所属业务渠道，文本非枚举类型
        /// </summary>
        [XmlElement("channel")]
        public string Channel { get; set; }

        /// <summary>
        /// 医生ID
        /// </summary>
        [XmlElement("doctor_id")]
        public string DoctorId { get; set; }

        /// <summary>
        /// 供应商问诊履约场景是否可以进行履约字段
        /// </summary>
        [XmlElement("fulfillable")]
        public bool Fulfillable { get; set; }

        /// <summary>
        /// SAAS履约单ID
        /// </summary>
        [XmlElement("fulfillment_id")]
        public string FulfillmentId { get; set; }

        /// <summary>
        /// 履约状态
        /// </summary>
        [XmlElement("fulfillment_status")]
        public string FulfillmentStatus { get; set; }

        /// <summary>
        /// 外部商品Id
        /// </summary>
        [XmlElement("item_code")]
        public string ItemCode { get; set; }

        /// <summary>
        /// 患者id
        /// </summary>
        [XmlElement("patient_id")]
        public string PatientId { get; set; }

        /// <summary>
        /// 服务项Id
        /// </summary>
        [XmlElement("service_item_id")]
        public string ServiceItemId { get; set; }

        /// <summary>
        /// 服务包id
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
