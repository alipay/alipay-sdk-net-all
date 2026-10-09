using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceEducateSchooldeviceSmCheckModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceEducateSchooldeviceSmCheckModel : AopObject
    {
        /// <summary>
        /// 活动码
        /// </summary>
        [XmlElement("activity_code")]
        public string ActivityCode { get; set; }

        /// <summary>
        /// 业务码
        /// </summary>
        [XmlElement("biz_code")]
        public string BizCode { get; set; }

        /// <summary>
        /// 间联商户ID
        /// </summary>
        [XmlElement("sm_id")]
        public string SmId { get; set; }
    }
}
