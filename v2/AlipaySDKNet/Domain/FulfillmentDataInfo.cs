using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// FulfillmentDataInfo Data Structure.
    /// </summary>
    [Serializable]
    public class FulfillmentDataInfo : AopObject
    {
        /// <summary>
        /// 顾问数据
        /// </summary>
        [XmlElement("advisor")]
        public AdvisorParam Advisor { get; set; }

        /// <summary>
        /// 问诊类数据
        /// </summary>
        [XmlElement("consultation")]
        public ConsultationParam Consultation { get; set; }

        /// <summary>
        /// 检查检验数据
        /// </summary>
        [XmlElement("examination")]
        public ExaminationParam Examination { get; set; }

        /// <summary>
        /// 检查加急
        /// </summary>
        [XmlElement("examination_urgent_fulfillment_detail_data")]
        public ExaminationUrgentFulfillmentDetailData ExaminationUrgentFulfillmentDetailData { get; set; }

        /// <summary>
        /// 高端医疗
        /// </summary>
        [XmlElement("highend_medical_fulfillment_detail_data")]
        public HighEndMedicalFulfillmentDetailData HighendMedicalFulfillmentDetailData { get; set; }

        /// <summary>
        /// 住院协助
        /// </summary>
        [XmlElement("inpatient_assist_fulfillment_detail_data")]
        public InpatientAssistFulfillmentDetailData InpatientAssistFulfillmentDetailData { get; set; }

        /// <summary>
        /// 陪护数据
        /// </summary>
        [XmlElement("inpatient_nursing_fulfillment_detail_data")]
        public InpatientNursingFulfillmentDetailData InpatientNursingFulfillmentDetailData { get; set; }

        /// <summary>
        /// 陪诊数据
        /// </summary>
        [XmlElement("offline_escort_fulfillment_detail_data")]
        public OfflineEscortFulfillmentDetailData OfflineEscortFulfillmentDetailData { get; set; }

        /// <summary>
        /// 体检服务
        /// </summary>
        [XmlElement("physical_examination_fulfillment_detail_data")]
        public PhysicalExaminationFulfillmentDetailData PhysicalExaminationFulfillmentDetailData { get; set; }

        /// <summary>
        /// 心理权益
        /// </summary>
        [XmlElement("psychological_fulfillment_detail_data")]
        public PsychologicalFulfillmentDetailData PsychologicalFulfillmentDetailData { get; set; }

        /// <summary>
        /// 挂号绿通
        /// </summary>
        [XmlElement("registration_green_channel_fulfillment_detail_data")]
        public RegistrationGreenChannelFulfillmentDetailData RegistrationGreenChannelFulfillmentDetailData { get; set; }
    }
}
