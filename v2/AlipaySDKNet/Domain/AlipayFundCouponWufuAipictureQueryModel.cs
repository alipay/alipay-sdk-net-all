using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayFundCouponWufuAipictureQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayFundCouponWufuAipictureQueryModel : AopObject
    {
        /// <summary>
        /// 蚂蚁统一开放id
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 场景码，由支付宝侧生成
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
