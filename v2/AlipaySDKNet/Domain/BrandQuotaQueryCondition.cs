using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// BrandQuotaQueryCondition Data Structure.
    /// </summary>
    [Serializable]
    public class BrandQuotaQueryCondition : AopObject
    {
        /// <summary>
        /// 是否查询可使用商家列表,true时不用填seller信息,false时必填seller信息
        /// </summary>
        [XmlElement("is_query_seller_list")]
        public bool IsQuerySellerList { get; set; }

        /// <summary>
        /// 卖家信息
        /// </summary>
        [XmlElement("seller_info")]
        public CreditPayUserVO SellerInfo { get; set; }
    }
}
