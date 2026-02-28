using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceMedicalInsuranceTpaappointmentstatusNotifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMedicalInsuranceTpaappointmentstatusNotifyModel : AopObject
    {
        /// <summary>
        /// 预约单号
        /// </summary>
        [XmlElement("appointment_no")]
        public string AppointmentNo { get; set; }

        /// <summary>
        /// 预约结果状态
        /// </summary>
        [XmlElement("appointment_status")]
        public string AppointmentStatus { get; set; }

        /// <summary>
        /// 预约状态描述
        /// </summary>
        [XmlElement("appointment_status_msg")]
        public string AppointmentStatusMsg { get; set; }

        /// <summary>
        /// 失败原因
        /// </summary>
        [XmlElement("fail_reason")]
        public string FailReason { get; set; }

        /// <summary>
        /// 支付宝用户的唯一ID
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 支付宝用户的唯一ID
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }

        /// <summary>
        /// 就诊科室
        /// </summary>
        [XmlElement("visit_department")]
        public string VisitDepartment { get; set; }

        /// <summary>
        /// 就诊机构
        /// </summary>
        [XmlElement("visit_hospital")]
        public string VisitHospital { get; set; }

        /// <summary>
        /// 就诊机构地址
        /// </summary>
        [XmlElement("visit_hospital_address")]
        public string VisitHospitalAddress { get; set; }

        /// <summary>
        /// 就诊机构码
        /// </summary>
        [XmlElement("visit_hospital_code")]
        public string VisitHospitalCode { get; set; }

        /// <summary>
        /// 就诊门店编码
        /// </summary>
        [XmlElement("visit_store_code")]
        public string VisitStoreCode { get; set; }

        /// <summary>
        /// 就诊时间
        /// </summary>
        [XmlElement("visit_time")]
        public string VisitTime { get; set; }
    }
}
