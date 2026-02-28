using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceGasMcardReturnModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceGasMcardReturnModel : AopObject
    {
        /// <summary>
        /// 小程序id
        /// </summary>
        [XmlElement("appid")]
        public string Appid { get; set; }

        /// <summary>
        /// 支付宝用户openid
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 机构侧会员卡号
        /// </summary>
        [XmlElement("out_card_no")]
        public string OutCardNo { get; set; }

        /// <summary>
        /// 支付宝用户uid
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
