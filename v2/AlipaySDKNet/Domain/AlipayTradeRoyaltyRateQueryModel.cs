using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayTradeRoyaltyRateQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayTradeRoyaltyRateQueryModel : AopObject
    {
        /// <summary>
        /// 外部请求号，由商家自定义。32个字符以内，仅可包含字母、数字、下划线。需保证在商户端不重复。
        /// </summary>
        [XmlElement("out_request_no")]
        public string OutRequestNo { get; set; }
    }
}
