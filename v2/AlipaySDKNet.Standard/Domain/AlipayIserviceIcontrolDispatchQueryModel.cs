using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayIserviceIcontrolDispatchQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayIserviceIcontrolDispatchQueryModel : AopObject
    {
        /// <summary>
        /// 业务类型
        /// </summary>
        [XmlElement("business_type")]
        public string BusinessType { get; set; }

        /// <summary>
        /// 问题级别
        /// </summary>
        [XmlElement("question_level")]
        public string QuestionLevel { get; set; }
    }
}
