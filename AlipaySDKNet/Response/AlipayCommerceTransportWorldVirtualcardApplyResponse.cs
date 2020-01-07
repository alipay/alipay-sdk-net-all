using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceTransportWorldVirtualcardApplyResponse.
    /// </summary>
    public class AlipayCommerceTransportWorldVirtualcardApplyResponse : AopResponse
    {
        /// <summary>
        /// 用户的卡号
        /// </summary>
        [XmlElement("card_no")]
        public string CardNo { get; set; }

        /// <summary>
        /// 虚拟卡卡类型
        /// </summary>
        [XmlElement("card_type")]
        public string CardType { get; set; }

        /// <summary>
        /// 请求失败时的错误信息
        /// </summary>
        [XmlElement("error_message")]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// 请求失败时返回的子错误码信息
        /// </summary>
        [XmlElement("sub_error_code")]
        public string SubErrorCode { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
