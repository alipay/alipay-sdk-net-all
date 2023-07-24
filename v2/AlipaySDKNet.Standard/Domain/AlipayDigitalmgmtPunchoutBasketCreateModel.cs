using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayDigitalmgmtPunchoutBasketCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayDigitalmgmtPunchoutBasketCreateModel : AopObject
    {
        /// <summary>
        /// 用于合并购物车
        /// </summary>
        [XmlElement("param_mall_merge_cart_request_dto")]
        public MallMergeCartRequestDto ParamMallMergeCartRequestDto { get; set; }
    }
}
