using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceRecycleRoyaltyRelationModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceRecycleRoyaltyRelationModifyModel : AopObject
    {
        /// <summary>
        /// 回收商订单ID
        /// </summary>
        [XmlElement("merchant_order_no")]
        public string MerchantOrderNo { get; set; }

        /// <summary>
        /// 用于标记支付宝用户在应用下的唯一标识
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 分账信息
        /// </summary>
        [XmlArray("royalty_info_list")]
        [XmlArrayItem("recycle_royalty_info")]
        public List<RecycleRoyaltyInfo> RoyaltyInfoList { get; set; }

        /// <summary>
        /// 支付宝用户的userId。
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
