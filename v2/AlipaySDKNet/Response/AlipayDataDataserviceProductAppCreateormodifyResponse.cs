using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayDataDataserviceProductAppCreateormodifyResponse.
    /// </summary>
    public class AlipayDataDataserviceProductAppCreateormodifyResponse : AopResponse
    {
        /// <summary>
        /// 商品灯火侧外部id
        /// </summary>
        [XmlElement("out_id")]
        public string OutId { get; set; }

        /// <summary>
        /// 商家侧商品id
        /// </summary>
        [XmlElement("out_item_id")]
        public string OutItemId { get; set; }

        /// <summary>
        /// 是否创建或更新成功
        /// </summary>
        [XmlElement("suc")]
        public bool Suc { get; set; }
    }
}
