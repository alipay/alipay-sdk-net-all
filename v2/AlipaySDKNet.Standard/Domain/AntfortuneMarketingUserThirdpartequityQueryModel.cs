using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AntfortuneMarketingUserThirdpartequityQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AntfortuneMarketingUserThirdpartequityQueryModel : AopObject
    {
        /// <summary>
        /// 权益类型，查询用户在该权益类型下的可用权益
        /// </summary>
        [XmlElement("equity_type")]
        public string EquityType { get; set; }

        /// <summary>
        /// 消费id
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 来源，每个接入的第三方都会有一个来源号
        /// </summary>
        [XmlElement("source")]
        public string Source { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
