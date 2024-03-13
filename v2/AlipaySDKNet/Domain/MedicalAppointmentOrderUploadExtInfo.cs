using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MedicalAppointmentOrderUploadExtInfo Data Structure.
    /// </summary>
    [Serializable]
    public class MedicalAppointmentOrderUploadExtInfo : AopObject
    {
        /// <summary>
        /// 叫号进度入口链接
        /// </summary>
        [XmlElement("call_num_url")]
        public string CallNumUrl { get; set; }

        /// <summary>
        /// 就诊科室
        /// </summary>
        [XmlElement("department")]
        public string Department { get; set; }

        /// <summary>
        /// 科室位置
        /// </summary>
        [XmlElement("dept_loc")]
        public string DeptLoc { get; set; }

        /// <summary>
        /// 诊室编号
        /// </summary>
        [XmlElement("dept_num")]
        public string DeptNum { get; set; }

        /// <summary>
        /// 医生名称
        /// </summary>
        [XmlElement("doctor")]
        public string Doctor { get; set; }

        /// <summary>
        /// 医生id
        /// </summary>
        [XmlElement("doctor_id")]
        public string DoctorId { get; set; }

        /// <summary>
        /// 医生职级
        /// </summary>
        [XmlElement("doctor_rank")]
        public string DoctorRank { get; set; }

        /// <summary>
        /// 医院名称
        /// </summary>
        [XmlElement("hospital")]
        public string Hospital { get; set; }

        /// <summary>
        /// 医院登记号类型
        /// </summary>
        [XmlElement("hospital_id_type")]
        public string HospitalIdType { get; set; }

        /// <summary>
        /// 医院登记号
        /// </summary>
        [XmlElement("hospital_register_id")]
        public string HospitalRegisterId { get; set; }

        /// <summary>
        /// 就诊序号
        /// </summary>
        [XmlElement("medical_num")]
        public string MedicalNum { get; set; }

        /// <summary>
        /// 订单链接
        /// </summary>
        [XmlElement("merchant_order_link_page")]
        public string MerchantOrderLinkPage { get; set; }

        /// <summary>
        /// 导航地址
        /// </summary>
        [XmlElement("navigation")]
        public string Navigation { get; set; }

        /// <summary>
        /// 就诊人姓名
        /// </summary>
        [XmlElement("patient")]
        public string Patient { get; set; }

        /// <summary>
        /// 预约日期
        /// </summary>
        [XmlElement("scheduled_time")]
        public string ScheduledTime { get; set; }

        /// <summary>
        /// 预约的就诊时间段
        /// </summary>
        [XmlElement("scheduled_time_period")]
        public string ScheduledTimePeriod { get; set; }

        /// <summary>
        /// 取号入口链接
        /// </summary>
        [XmlElement("take_num_url")]
        public string TakeNumUrl { get; set; }
    }
}
