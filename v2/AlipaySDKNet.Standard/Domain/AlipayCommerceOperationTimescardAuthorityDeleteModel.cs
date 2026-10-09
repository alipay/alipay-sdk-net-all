using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceOperationTimescardAuthorityDeleteModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceOperationTimescardAuthorityDeleteModel : AopObject
    {
        /// <summary>
        /// 店员支付宝账户
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 场景码
        /// </summary>
        [XmlElement("scene_code")]
        public string SceneCode { get; set; }

        /// <summary>
        /// 店员支付宝账户
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
