using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// KoubeiMarketingDataMallDiscountQueryResponse.
    /// </summary>
    public class KoubeiMarketingDataMallDiscountQueryResponse : AopResponse
    {
        /// <summary>
        /// 集卡信息列表（最多50条）
        /// </summary>
        [XmlArray("card_list")]
        [XmlArrayItem("card_info")]
        public List<CardInfo> CardList { get; set; }

        /// <summary>
        /// 口令信息列表（最多50条）
        /// </summary>
        [XmlArray("code_coupon_list")]
        [XmlArrayItem("code_coupon_info")]
        public List<CodeCouponInfo> CodeCouponList { get; set; }

        /// <summary>
        /// 消费送信息列表（最多50条）
        /// </summary>
        [XmlArray("consume_list")]
        [XmlArrayItem("consume_info")]
        public List<ConsumeInfo> ConsumeList { get; set; }

        /// <summary>
        /// 订单优惠信息列表（最多50条）
        /// </summary>
        [XmlArray("reduce_list")]
        [XmlArrayItem("reduce_info")]
        public List<ReduceInfo> ReduceList { get; set; }
    }
}
