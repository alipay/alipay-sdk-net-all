using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// FulfillmentBizInfo Data Structure.
    /// </summary>
    [Serializable]
    public class FulfillmentBizInfo : AopObject
    {
        /// <summary>
        /// 顾问类数据
        /// </summary>
        [XmlElement("advisory")]
        public Advisory Advisory { get; set; }

        /// <summary>
        /// 问诊类数据
        /// </summary>
        [XmlElement("consultation")]
        public Consultation Consultation { get; set; }

        /// <summary>
        /// 陪诊对象
        /// </summary>
        [XmlElement("escort")]
        public EscortVO Escort { get; set; }

        /// <summary>
        /// 检查检验类数据
        /// </summary>
        [XmlElement("examination")]
        public Examination Examination { get; set; }

        /// <summary>
        /// 检查加急
        /// </summary>
        [XmlElement("examination_urgent")]
        public FulfillmentBizVO ExaminationUrgent { get; set; }

        /// <summary>
        /// 高端医疗
        /// </summary>
        [XmlElement("highend_medical")]
        public HighEndMedicalFulfillmentDetailData HighendMedical { get; set; }

        /// <summary>
        /// 住院协助
        /// </summary>
        [XmlElement("inpatient_assist")]
        public FulfillmentBizVO InpatientAssist { get; set; }

        /// <summary>
        /// 陪护类型
        /// </summary>
        [XmlElement("nursing")]
        public NursingVO Nursing { get; set; }

        /// <summary>
        /// 体检服务
        /// </summary>
        [XmlElement("physical_examination")]
        public FulfillmentBizVO PhysicalExamination { get; set; }

        /// <summary>
        /// 心理权益
        /// </summary>
        [XmlElement("psychological")]
        public PsychologicalVO Psychological { get; set; }

        /// <summary>
        /// 挂号绿通
        /// </summary>
        [XmlElement("registration_green_channel")]
        public FulfillmentBizVO RegistrationGreenChannel { get; set; }
    }
}
