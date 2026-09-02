using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceMedicalHmItemQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMedicalHmItemQueryModel : AopObject
    {
        /// <summary>
        /// 医生ID
        /// </summary>
        [XmlElement("doctor_id")]
        public string DoctorId { get; set; }

        /// <summary>
        /// 服务包订单ID。通过履约单号换取服务订单id
        /// </summary>
        [XmlElement("package_order_id")]
        public string PackageOrderId { get; set; }

        /// <summary>
        /// 页码,默认1
        /// </summary>
        [XmlElement("page")]
        public long Page { get; set; }

        /// <summary>
        /// 分页大小,默认10
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// EXPRESS_INQUIRY(极速问诊) EXPERT_INQUIRY(专家问诊)
        /// </summary>
        [XmlElement("type")]
        public string Type { get; set; }
    }
}
