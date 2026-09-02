using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// PhysicalExaminationFulfillmentDetailData Data Structure.
    /// </summary>
    [Serializable]
    public class PhysicalExaminationFulfillmentDetailData : AopObject
    {
        /// <summary>
        /// 格式:yyyy-MM-dd HH:mm:ss
        /// </summary>
        [XmlElement("appointment_end_time")]
        public string AppointmentEndTime { get; set; }

        /// <summary>
        /// 格式:yyyy-MM-dd HH:mm:ss
        /// </summary>
        [XmlElement("appointment_start_time")]
        public string AppointmentStartTime { get; set; }

        /// <summary>
        /// 格式:yyyy-MM-dd
        /// </summary>
        [XmlElement("birth_date")]
        public string BirthDate { get; set; }

        /// <summary>
        /// 格式:yyyy-MM-dd HH:mm:ss
        /// </summary>
        [XmlElement("cancel_time")]
        public string CancelTime { get; set; }

        /// <summary>
        /// 证件号码
        /// </summary>
        [XmlElement("cert_no")]
        public string CertNo { get; set; }

        /// <summary>
        /// IDENTITY_CARD - 身份证 HOUSEHOLD_REGISTER - 户口本 OTHER - 其他
        /// </summary>
        [XmlElement("cert_type")]
        public string CertType { get; set; }

        /// <summary>
        /// 格式:yyyy-MM-dd HH:mm:ss
        /// </summary>
        [XmlElement("create_time")]
        public string CreateTime { get; set; }

        /// <summary>
        /// 体检人
        /// </summary>
        [XmlElement("examinee_name")]
        public string ExamineeName { get; set; }

        /// <summary>
        /// 格式:yyyy-MM-dd HH:mm:ss
        /// </summary>
        [XmlElement("finish_time")]
        public string FinishTime { get; set; }

        /// <summary>
        /// 0-女1-男
        /// </summary>
        [XmlElement("gender")]
        public string Gender { get; set; }

        /// <summary>
        /// MARRIED - 已婚UNMARRIED - 未婚
        /// </summary>
        [XmlElement("marital_status")]
        public string MaritalStatus { get; set; }

        /// <summary>
        /// 套餐名称，如:体检350元老年套餐
        /// </summary>
        [XmlElement("package_name")]
        public string PackageName { get; set; }

        /// <summary>
        /// 联系电话
        /// </summary>
        [XmlElement("phone")]
        public string Phone { get; set; }

        /// <summary>
        /// 如:浙江省杭州市
        /// </summary>
        [XmlElement("service_city")]
        public string ServiceCity { get; set; }

        /// <summary>
        /// 如:上海交通大学附属瑞金医院体检中心
        /// </summary>
        [XmlElement("service_institution")]
        public string ServiceInstitution { get; set; }

        /// <summary>
        /// 格式:yyyy-MM-dd HH:mm:ss
        /// </summary>
        [XmlElement("update_time")]
        public string UpdateTime { get; set; }
    }
}
