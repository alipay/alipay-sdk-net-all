using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayDataDataserviceAdentitylibraryTmallgoodsCreateResponse.
    /// </summary>
    public class AlipayDataDataserviceAdentitylibraryTmallgoodsCreateResponse : AopResponse
    {
        /// <summary>
        /// 商品 ID
        /// </summary>
        [XmlElement("goods_id")]
        public string GoodsId { get; set; }
    }
}
