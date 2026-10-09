using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceTransportWorldCarddataApplyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceTransportWorldCarddataApplyModel : AopObject
    {
        /// <summary>
        /// 请求号
        /// </summary>
        [XmlElement("biz_id")]
        public string BizId { get; set; }

        /// <summary>
        /// 用户的卡号
        /// </summary>
        [XmlElement("card_no")]
        public string CardNo { get; set; }

        /// <summary>
        /// 卡类型，城市交通部门维度，如羊城通是一种cardtype。
        /// </summary>
        [XmlElement("card_type")]
        public string CardType { get; set; }

        /// <summary>
        /// 客户端SDK版本
        /// </summary>
        [XmlElement("client_gencode_sdkversion")]
        public string ClientGencodeSdkversion { get; set; }

        /// <summary>
        /// 扩展信息
        /// </summary>
        [XmlElement("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 请求来源，大湾区本期只支持“GN_HK”。
        /// </summary>
        [XmlElement("source")]
        public string Source { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
