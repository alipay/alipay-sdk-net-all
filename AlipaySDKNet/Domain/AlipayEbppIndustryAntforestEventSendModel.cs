using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayEbppIndustryAntforestEventSendModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEbppIndustryAntforestEventSendModel : AopObject
    {
        /// <summary>
        /// 用于标识行业-蚂蚁森林能量事件的类别
        /// </summary>
        [XmlElement("type")]
        public string Type { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
