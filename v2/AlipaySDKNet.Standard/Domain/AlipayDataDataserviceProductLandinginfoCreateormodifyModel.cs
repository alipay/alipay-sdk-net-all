using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayDataDataserviceProductLandinginfoCreateormodifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayDataDataserviceProductLandinginfoCreateormodifyModel : AopObject
    {
        /// <summary>
        /// 支付宝平台侧商品ID，是支付宝平台侧商品的唯一标识，后续与平台交互，需要使用该 ID
        /// </summary>
        [XmlElement("item_id")]
        public string ItemId { get; set; }

        /// <summary>
        /// 每次请求需要包含全量的落地页信息，本次请求的落地页信息会对之前的落地页信息来做覆盖操作
        /// </summary>
        [XmlArray("landing")]
        [XmlArrayItem("landing_type_dto")]
        public List<LandingTypeDto> Landing { get; set; }

        /// <summary>
        /// 商家侧商品ID，要求 APPID 下全局唯一。
        /// </summary>
        [XmlElement("out_item_id")]
        public string OutItemId { get; set; }
    }
}
