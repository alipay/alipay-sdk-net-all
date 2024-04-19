using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayUserDtbankcustActivityconfigQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayUserDtbankcustActivityconfigQueryModel : AopObject
    {
        /// <summary>
        /// 数字分行活动唯一id
        /// </summary>
        [XmlElement("activity_id")]
        public string ActivityId { get; set; }

        /// <summary>
        /// 数字分行活动类型
        /// </summary>
        [XmlElement("activity_type")]
        public string ActivityType { get; set; }
    }
}
