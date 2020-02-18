using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// KoubeiMallScanpurchaseTradeConsultResponse.
    /// </summary>
    public class KoubeiMallScanpurchaseTradeConsultResponse : AopResponse
    {
        /// <summary>
        /// 用户实付金额
        /// </summary>
        [XmlElement("buyer_pay_amount")]
        public string BuyerPayAmount { get; set; }

        /// <summary>
        /// 优惠信息
        /// </summary>
        [XmlArray("discount_detail")]
        [XmlArrayItem("mall_discount_detail")]
        public List<MallDiscountDetail> DiscountDetail { get; set; }

        /// <summary>
        /// 请求中的request_id
        /// </summary>
        [XmlElement("request_id")]
        public string RequestId { get; set; }
    }
}
