using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenMiniPromodecisionOrderconsultQueryResponse.
    /// </summary>
    public class AlipayOpenMiniPromodecisionOrderconsultQueryResponse : AopResponse
    {
        /// <summary>
        /// 订单优惠信息
        /// </summary>
        [XmlElement("order_discount_detail_info")]
        public OrderDiscountDetailInfo OrderDiscountDetailInfo { get; set; }

        /// <summary>
        /// 错误码
        /// </summary>
        [XmlElement("result_code")]
        public string ResultCode { get; set; }
    }
}
