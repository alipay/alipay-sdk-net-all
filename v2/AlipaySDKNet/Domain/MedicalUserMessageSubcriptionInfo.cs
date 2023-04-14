using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MedicalUserMessageSubcriptionInfo Data Structure.
    /// </summary>
    [Serializable]
    public class MedicalUserMessageSubcriptionInfo : AopObject
    {
        /// <summary>
        /// 行业类型id，医保动账5
        /// </summary>
        [XmlElement("industry_type_id")]
        public long IndustryTypeId { get; set; }

        /// <summary>
        /// 开放id
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 1已订阅，0未订阅
        /// </summary>
        [XmlElement("state")]
        public long State { get; set; }

        /// <summary>
        /// 用户id
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
