using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayUserAigcDiyitemhdCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayUserAigcDiyitemhdCreateModel : AopObject
    {
        /// <summary>
        /// 支付宝AIGC订单ID
        /// </summary>
        [XmlElement("aigc_order_id")]
        public string AigcOrderId { get; set; }

        /// <summary>
        /// 多媒体图片ID
        /// </summary>
        [XmlElement("image_id")]
        public string ImageId { get; set; }

        /// <summary>
        /// 蚂蚁开放id
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 业务订单号，如商家侧的订单ID
        /// </summary>
        [XmlElement("order_id")]
        public string OrderId { get; set; }

        /// <summary>
        /// 场景码
        /// </summary>
        [XmlElement("scene_code")]
        public string SceneCode { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
