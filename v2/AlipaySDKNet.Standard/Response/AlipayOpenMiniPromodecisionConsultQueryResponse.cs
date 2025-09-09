using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenMiniPromodecisionConsultQueryResponse.
    /// </summary>
    public class AlipayOpenMiniPromodecisionConsultQueryResponse : AopResponse
    {
        /// <summary>
        /// 商详优惠信息
        /// </summary>
        [XmlElement("discount_detail_info")]
        public ItemDiscountDetailInfo DiscountDetailInfo { get; set; }

        /// <summary>
        /// 错误码
        /// </summary>
        [XmlElement("result_code")]
        public string ResultCode { get; set; }
    }
}
