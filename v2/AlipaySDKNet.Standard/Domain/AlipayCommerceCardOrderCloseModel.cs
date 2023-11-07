using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceCardOrderCloseModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceCardOrderCloseModel : AopObject
    {
        /// <summary>
        /// 卡ID
        /// </summary>
        [XmlElement("card_id")]
        public string CardId { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }

        /// <summary>
        /// 用户openId
        /// </summary>
        [XmlElement("user_id_open_id")]
        public string UserIdOpenId { get; set; }
    }
}
