using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayUserGameopenpromoChallengeQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayUserGameopenpromoChallengeQueryModel : AopObject
    {
        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 获取小程序启动参数的channel字段，未获取到请默认传other
        /// </summary>
        [XmlElement("query_channel")]
        public string QueryChannel { get; set; }

        /// <summary>
        /// 支付宝唯一用户ID
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
