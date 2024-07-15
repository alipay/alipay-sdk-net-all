using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AuthResourceContent Data Structure.
    /// </summary>
    [Serializable]
    public class AuthResourceContent : AopObject
    {
        /// <summary>
        /// 激励，单位是g
        /// </summary>
        [XmlElement("award_amount")]
        public long AwardAmount { get; set; }

        /// <summary>
        /// 人群
        /// </summary>
        [XmlElement("group_type")]
        public string GroupType { get; set; }
    }
}
