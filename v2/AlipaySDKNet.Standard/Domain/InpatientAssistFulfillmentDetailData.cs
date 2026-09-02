using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// InpatientAssistFulfillmentDetailData Data Structure.
    /// </summary>
    [Serializable]
    public class InpatientAssistFulfillmentDetailData : AopObject
    {
        /// <summary>
        /// 就医信息
        /// </summary>
        [XmlElement("actual_visit_info")]
        public ActualVisitInfo ActualVisitInfo { get; set; }

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
        /// 确认时间
        /// </summary>
        [XmlElement("confirmed_time")]
        public string ConfirmedTime { get; set; }

        /// <summary>
        /// 订单创建时间
        /// </summary>
        [XmlElement("create_time")]
        public string CreateTime { get; set; }

        /// <summary>
        /// 订单完成时间(审核通过)
        /// </summary>
        [XmlElement("finish_time")]
        public string FinishTime { get; set; }

        /// <summary>
        /// 资料信息
        /// </summary>
        [XmlElement("material_info")]
        public FulfillmentMaterialInfo MaterialInfo { get; set; }

        /// <summary>
        /// 患者信息
        /// </summary>
        [XmlElement("patient_info")]
        public FulfillmentPatientInfo PatientInfo { get; set; }

        /// <summary>
        /// 接单时间
        /// </summary>
        [XmlElement("processed_time")]
        public string ProcessedTime { get; set; }

        /// <summary>
        /// 预约成功时间
        /// </summary>
        [XmlElement("reserved_time")]
        public string ReservedTime { get; set; }

        /// <summary>
        /// 更新时间
        /// </summary>
        [XmlElement("update_time")]
        public string UpdateTime { get; set; }
    }
}
