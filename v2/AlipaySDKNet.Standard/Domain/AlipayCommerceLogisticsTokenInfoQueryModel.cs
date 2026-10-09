using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceLogisticsTokenInfoQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceLogisticsTokenInfoQueryModel : AopObject
    {
        /// <summary>
        /// 支付宝聚合下单页跳转商户小程序携带的token，商户通过token回查支付宝获取用户填选的信息
        /// </summary>
        [XmlElement("info_token")]
        public string InfoToken { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
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
