using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// HighEndMedicalFulfillmentDetailData Data Structure.
    /// </summary>
    [Serializable]
    public class HighEndMedicalFulfillmentDetailData : AopObject
    {
        /// <summary>
        /// 预约备选时间
        /// </summary>
        [XmlElement("alternative_time")]
        public string AlternativeTime { get; set; }

        /// <summary>
        /// 预约时间（预约中时必填，格式yyyy-MM-dd HH:mm:ss）
        /// </summary>
        [XmlElement("appointment_time")]
        public string AppointmentTime { get; set; }

        /// <summary>
        /// 账单金额（已核销时必填）
        /// </summary>
        [XmlElement("bill_amount")]
        public string BillAmount { get; set; }

        /// <summary>
        /// 出生日期（格式: 1999-02-01）
        /// </summary>
        [XmlElement("birth_day")]
        public string BirthDay { get; set; }

        /// <summary>
        /// 确认时间（预约成功时必填）
        /// </summary>
        [XmlElement("confirm_time")]
        public string ConfirmTime { get; set; }

        /// <summary>
        /// 预约科室
        /// </summary>
        [XmlElement("department")]
        public string Department { get; set; }

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
        /// 医院门店名称（预约中时必填）
        /// </summary>
        [XmlElement("hospital_name")]
        public string HospitalName { get; set; }

        /// <summary>
        /// ISV侧订单号
        /// </summary>
        [XmlElement("out_order_no")]
        public string OutOrderNo { get; set; }

        /// <summary>
        /// 证件号码（预约中时必填）
        /// </summary>
        [XmlElement("patient_cert_no")]
        public string PatientCertNo { get; set; }

        /// <summary>
        /// 证件类型（预约中时必填）
        /// </summary>
        [XmlElement("patient_cert_type")]
        public string PatientCertType { get; set; }

        /// <summary>
        /// 就诊人性别(0 女 1 男)
        /// </summary>
        [XmlElement("patient_gender")]
        public string PatientGender { get; set; }

        /// <summary>
        /// 就诊人姓名（预约中时必填）
        /// </summary>
        [XmlElement("patient_name")]
        public string PatientName { get; set; }

        /// <summary>
        /// 就诊人手机号（预约中时必填）
        /// </summary>
        [XmlElement("patient_phone")]
        public string PatientPhone { get; set; }

        /// <summary>
        /// 产品类型：单次卡/多次卡（已核销时必填）
        /// </summary>
        [XmlElement("product_type")]
        public string ProductType { get; set; }

        /// <summary>
        /// 备注（预约失败/取消原因）
        /// </summary>
        [XmlElement("remark")]
        public string Remark { get; set; }

        /// <summary>
        /// 症状
        /// </summary>
        [XmlElement("symptom")]
        public string Symptom { get; set; }

        /// <summary>
        /// 总次数（已核销时必填）
        /// </summary>
        [XmlElement("total_times")]
        public long TotalTimes { get; set; }

        /// <summary>
        /// 履约类型
        /// </summary>
        [XmlElement("type")]
        public string Type { get; set; }

        /// <summary>
        /// 已使用次数（已核销时必填）
        /// </summary>
        [XmlElement("used_times")]
        public long UsedTimes { get; set; }
    }
}
