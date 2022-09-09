using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// WidgetGoodsAuditPassResult Data Structure.
    /// </summary>
    [Serializable]
    public class WidgetGoodsAuditPassResult : AopObject
    {
        /// <summary>
        /// 支付宝商品内部唯一标识
        /// </summary>
        [XmlElement("alipay_goods_id")]
        public string AlipayGoodsId { get; set; }

        /// <summary>
        /// 商品外部唯一标识
        /// </summary>
        [XmlElement("goods_id")]
        public string GoodsId { get; set; }
    }
}
