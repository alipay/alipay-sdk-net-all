using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayDataDataserviceProductLandinginfoCreateormodifyResponse.
    /// </summary>
    public class AlipayDataDataserviceProductLandinginfoCreateormodifyResponse : AopResponse
    {
        /// <summary>
        /// 请求成功时返回该字段；支付宝平台侧商品ID，是支付宝平台侧商品的唯一标识，后续与平台交互，需要使用该 ID
        /// </summary>
        [XmlElement("item_id")]
        public string ItemId { get; set; }

        /// <summary>
        /// 请求成功时返回该字段；商家侧商品ID，要求 APPID 下全局唯一。
        /// </summary>
        [XmlElement("out_item_id")]
        public string OutItemId { get; set; }
    }
}
