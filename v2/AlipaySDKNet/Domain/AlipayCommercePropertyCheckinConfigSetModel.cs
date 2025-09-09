using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommercePropertyCheckinConfigSetModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommercePropertyCheckinConfigSetModel : AopObject
    {
        /// <summary>
        /// 打卡链接
        /// </summary>
        [XmlElement("clock_url")]
        public string ClockUrl { get; set; }

        /// <summary>
        /// 岗位id
        /// </summary>
        [XmlElement("job_id")]
        public string JobId { get; set; }
    }
}
