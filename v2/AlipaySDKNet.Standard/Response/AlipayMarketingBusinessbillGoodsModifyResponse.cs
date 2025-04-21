using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayMarketingBusinessbillGoodsModifyResponse.
    /// </summary>
    public class AlipayMarketingBusinessbillGoodsModifyResponse : AopResponse
    {
        /// <summary>
        /// 商品id，后续修改/删除唯一凭证
        /// </summary>
        [XmlElement("id")]
        public string Id { get; set; }
    }
}
