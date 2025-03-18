using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MerchantRelationEntity Data Structure.
    /// </summary>
    [Serializable]
    public class MerchantRelationEntity : AopObject
    {
        /// <summary>
        /// 备注信息
        /// </summary>
        [XmlElement("memo")]
        public string Memo { get; set; }

        /// <summary>
        /// 主商户支付宝id，对客提供服务方
        /// </summary>
        [XmlElement("seller_id")]
        public string SellerId { get; set; }

        /// <summary>
        /// 用于标记支付宝用户在应用下的唯一标识
        /// </summary>
        [XmlElement("seller_open_id")]
        public string SellerOpenId { get; set; }

        /// <summary>
        /// 合作商户支付宝id，不直接提供对客服务，与primary_id关系可能是分销等
        /// </summary>
        [XmlElement("sub_seller_id")]
        public string SubSellerId { get; set; }

        /// <summary>
        /// 用于标记支付宝用户在应用下的唯一标识
        /// </summary>
        [XmlElement("sub_seller_open_id")]
        public string SubSellerOpenId { get; set; }
    }
}
