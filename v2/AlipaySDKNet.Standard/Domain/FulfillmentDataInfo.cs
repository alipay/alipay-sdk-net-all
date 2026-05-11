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
        /// 问诊类数据
        /// </summary>
        [XmlElement("consultation")]
        public ConsultationParam Consultation { get; set; }

        /// <summary>
        /// 检查检验数据
        /// </summary>
        [XmlElement("examination")]
        public ExaminationParam Examination { get; set; }
    }
}
