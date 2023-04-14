using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// KoubeiCateringItemModifyResponse.
    /// </summary>
    public class KoubeiCateringItemModifyResponse : AopResponse
    {
        /// <summary>
        /// 口碑体系内部商品的唯一标识
        /// </summary>
        [XmlElement("item_id")]
        public string ItemId { get; set; }

        /// <summary>
        /// 支持英文字母和数字，由开发者自行定义（不允许重复）
        /// </summary>
        [XmlElement("request_id")]
        public string RequestId { get; set; }
    }
}
