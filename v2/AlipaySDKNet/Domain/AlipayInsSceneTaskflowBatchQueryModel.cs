using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayInsSceneTaskflowBatchQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayInsSceneTaskflowBatchQueryModel : AopObject
    {
        /// <summary>
        /// 支付宝账号openId
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
