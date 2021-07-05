using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RecruitVoucher Data Structure.
    /// </summary>
    [Serializable]
    public class RecruitVoucher : AopObject
    {
        /// <summary>
        /// 券活动id
        /// </summary>
        [XmlElement("activity_id")]
        public string ActivityId { get; set; }
    }
}
