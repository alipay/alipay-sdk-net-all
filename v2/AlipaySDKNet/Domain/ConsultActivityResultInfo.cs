using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ConsultActivityResultInfo Data Structure.
    /// </summary>
    [Serializable]
    public class ConsultActivityResultInfo : AopObject
    {
        /// <summary>
        /// 活动id
        /// </summary>
        [XmlElement("activity_id")]
        public string ActivityId { get; set; }

        /// <summary>
        /// 咨询结果码
        /// </summary>
        [XmlElement("consult_result_code")]
        public string ConsultResultCode { get; set; }
    }
}
