using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayMarketingToolSignupSubmitModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMarketingToolSignupSubmitModel : AopObject
    {
        /// <summary>
        /// 玩法ID。
        /// </summary>
        [XmlElement("play_id")]
        public string PlayId { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
