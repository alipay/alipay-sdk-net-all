using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// OfflineEscortFulfillmentDetailData Data Structure.
    /// </summary>
    [Serializable]
    public class OfflineEscortFulfillmentDetailData : AopObject
    {
        /// <summary>
        /// 取消原因
        /// </summary>
        [XmlElement("cancel_reason")]
        public string CancelReason { get; set; }

        /// <summary>
        /// 取消备注
        /// </summary>
        [XmlElement("cancel_remark")]
        public string CancelRemark { get; set; }

        /// <summary>
        /// 取消时间
        /// </summary>
        [XmlElement("cancel_time")]
        public string CancelTime { get; set; }

        /// <summary>
        /// 就诊信息
        /// </summary>
        [XmlElement("clinic_info")]
        public ClinicInfo ClinicInfo { get; set; }

        /// <summary>
        /// 关闭原因
        /// </summary>
        [XmlElement("close_reason")]
        public string CloseReason { get; set; }

        /// <summary>
        /// 关闭备注
        /// </summary>
        [XmlElement("close_remark")]
        public string CloseRemark { get; set; }

        /// <summary>
        /// 关闭时间
        /// </summary>
        [XmlElement("close_time")]
        public string CloseTime { get; set; }

        /// <summary>
        /// 订单创建时间
        /// </summary>
        [XmlElement("create_time")]
        public string CreateTime { get; set; }

        /// <summary>
        /// 订单完成时间审核通过
        /// </summary>
        [XmlElement("finish_time")]
        public string FinishTime { get; set; }

        /// <summary>
        /// 患者信息
        /// </summary>
        [XmlElement("patient_info")]
        public FulfillmentPatientInfo PatientInfo { get; set; }

        /// <summary>
        /// 服务安排时间
        /// </summary>
        [XmlElement("scheduled_time")]
        public string ScheduledTime { get; set; }

        /// <summary>
        /// 服务结束时间
        /// </summary>
        [XmlElement("service_end_time")]
        public string ServiceEndTime { get; set; }

        /// <summary>
        /// 服务结果
        /// </summary>
        [XmlElement("service_result")]
        public ServiceResult ServiceResult { get; set; }

        /// <summary>
        /// 陪诊开始时间
        /// </summary>
        [XmlElement("service_start_time")]
        public string ServiceStartTime { get; set; }

        /// <summary>
        /// 陪诊人员信息
        /// </summary>
        [XmlElement("staff_info")]
        public FulfillmentStaffInfo StaffInfo { get; set; }

        /// <summary>
        /// 更新时间
        /// </summary>
        [XmlElement("update_time")]
        public string UpdateTime { get; set; }
    }
}
