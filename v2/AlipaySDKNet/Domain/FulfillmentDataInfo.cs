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
        /// 陪护数据
        /// </summary>
        [XmlElement("inpatient_nursing_fulfillment_detail_data")]
        public InpatientNursingFulfillmentDetailData InpatientNursingFulfillmentDetailData { get; set; }

        /// <summary>
        /// 陪诊数据
        /// </summary>
        [XmlElement("offline_escort_fulfillment_detail_data")]
        public OfflineEscortFulfillmentDetailData OfflineEscortFulfillmentDetailData { get; set; }
    }
}
