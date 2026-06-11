using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// InpatientNursingFulfillmentDetailData Data Structure.
    /// </summary>
    [Serializable]
    public class InpatientNursingFulfillmentDetailData : AopObject
    {
        /// <summary>
        /// 到达时间
        /// </summary>
        [XmlElement("arrival_time")]
        public string ArrivalTime { get; set; }

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
        /// 住院信息
        /// </summary>
        [XmlElement("care_info")]
        public CareInfo CareInfo { get; set; }

        /// <summary>
        /// 2023-10-26 16:00:00
        /// </summary>
        [XmlElement("completion_time")]
        public string CompletionTime { get; set; }

        /// <summary>
        /// 订单创建时间
        /// </summary>
        [XmlElement("create_time")]
        public string CreateTime { get; set; }

        /// <summary>
        /// 离开时间
        /// </summary>
        [XmlElement("departure_time")]
        public string DepartureTime { get; set; }

        /// <summary>
        /// 订单完成时间审核通过
        /// </summary>
        [XmlElement("finish_time")]
        public string FinishTime { get; set; }

        /// <summary>
        /// 患者信息
        /// </summary>
        [XmlElement("patient_info")]
        public InpatientNursingPatientInfo PatientInfo { get; set; }

        /// <summary>
        /// 服务结果
        /// </summary>
        [XmlElement("service_result")]
        public InpatientNursingServiceResult ServiceResult { get; set; }

        /// <summary>
        /// 人员信息
        /// </summary>
        [XmlElement("staff_info")]
        public InpatientNursingStaffInfo StaffInfo { get; set; }

        /// <summary>
        /// 更新时间
        /// </summary>
        [XmlElement("update_time")]
        public string UpdateTime { get; set; }
    }
}
