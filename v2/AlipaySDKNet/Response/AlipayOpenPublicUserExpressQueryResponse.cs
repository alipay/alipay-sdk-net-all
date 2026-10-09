using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenPublicUserExpressQueryResponse.
    /// </summary>
    public class AlipayOpenPublicUserExpressQueryResponse : AopResponse
    {
        /// <summary>
        /// 是否为快捷绑卡用户
        /// </summary>
        [XmlElement("express_user")]
        public bool ExpressUser { get; set; }

        /// <summary>
        /// 支付宝用户唯一标识
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
