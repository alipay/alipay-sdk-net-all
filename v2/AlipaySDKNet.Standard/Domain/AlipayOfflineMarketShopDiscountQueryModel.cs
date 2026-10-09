using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOfflineMarketShopDiscountQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOfflineMarketShopDiscountQueryModel : AopObject
    {
        /// <summary>
        /// 活动业务类型列表。当 query_type 为MERCHANT 且 user_id 不为空时生效，将对返回结果进行过滤，返回列表中指定业务类型的活动。默认为空，代表不过滤，返回所有活动。 支持过滤的业务类型如下： *  CONSUME_SEND：消费送； *  MRT_DISCOUNT：商户立减； *  OBTAIN：通用领券。
        /// </summary>
        [XmlArray("camp_biz_type_list")]
        [XmlArrayItem("string")]
        public List<string> CampBizTypeList { get; set; }

        /// <summary>
        /// 用户id，当query_type为MERCHANT时生效，如果查询的优惠活动需要过用户规则，则用户id必须传入，目前只支持查询活动列表的场景;
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 查询类型，暂仅支持：MERCHANT(商户活动)。 如果不传递该参数或者指定参数值，出参只返回item_list，discount_list， 反之返回camp_num,camp_list。
        /// </summary>
        [XmlElement("query_type")]
        public string QueryType { get; set; }

        /// <summary>
        /// 门店id。 注意：必须传递 isv 授权商户下的门店，否则无权限查询。
        /// </summary>
        [XmlElement("shop_id")]
        public string ShopId { get; set; }

        /// <summary>
        /// 用户id，当query_type为MERCHANT时生效，如果查询的优惠活动需要过用户规则，则用户id必须传入，目前只支持查询活动列表的场景;
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
