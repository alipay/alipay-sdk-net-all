using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenMiniMarketMemberQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenMiniMarketMemberQueryModel : AopObject
    {
        /// <summary>
        /// 小程序appId
        /// </summary>
        [XmlElement("mini_app_id")]
        public string MiniAppId { get; set; }

        /// <summary>
        /// 支付宝用户UID
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
