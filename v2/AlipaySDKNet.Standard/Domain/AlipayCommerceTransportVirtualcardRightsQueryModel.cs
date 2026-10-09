using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceTransportVirtualcardRightsQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceTransportVirtualcardRightsQueryModel : AopObject
    {
        /// <summary>
        /// 卡号
        /// </summary>
        [XmlElement("card_no")]
        public string CardNo { get; set; }

        /// <summary>
        /// 支付宝分配的卡类型
        /// </summary>
        [XmlElement("card_type")]
        public string CardType { get; set; }

        /// <summary>
        /// 用户open_id
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 用户权益类型
        /// </summary>
        [XmlArray("right_type_list")]
        [XmlArrayItem("string")]
        public List<string> RightTypeList { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
