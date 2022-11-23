using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayUserCardInstanceQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayUserCardInstanceQueryModel : AopObject
    {
        /// <summary>
        /// card_no：商家业务系统中的卡号
        /// </summary>
        [XmlElement("card_no")]
        public string CardNo { get; set; }

        /// <summary>
        /// open_id:唯一用户标识
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// user_id:蚂蚁统一会员ID
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
