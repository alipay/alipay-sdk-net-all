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
        /// 检查检验类数据
        /// </summary>
        [XmlElement("examination")]
        public Examination Examination { get; set; }
    }
}
