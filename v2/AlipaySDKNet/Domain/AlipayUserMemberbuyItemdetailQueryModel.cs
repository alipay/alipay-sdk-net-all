using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayUserMemberbuyItemdetailQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayUserMemberbuyItemdetailQueryModel : AopObject
    {
        /// <summary>
        /// 支付宝会员账户对应的用户ID对应的统一开放ID
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 外部商户侧的商品ID，由商户提供
        /// </summary>
        [XmlElement("out_item_id")]
        public string OutItemId { get; set; }

        /// <summary>
        /// 支付宝会员账户对应的用户ID
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
