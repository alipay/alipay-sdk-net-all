using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// GoodsActivityContentVO Data Structure.
    /// </summary>
    [Serializable]
    public class GoodsActivityContentVO : AopObject
    {
        /// <summary>
        /// 商品Id。传入商品id后可支持在群内发商品消息。请先通过小程序商品创建接口<a href="https://opendocs.alipay.com/mini/4880cf68_alipay.open.app.item.create?scene=common&pathHash=250eb20d">https://opendocs.alipay.com/mini/4880cf68_alipay.open.app.item.create?scene=common&pathHash=250eb20d</a> 或小程序本地商品创建接口<a href="https://opendocs.alipay.com/mini/4aa8dac1_alipay.open.app.localitem.create?pathHash=9bdb074d&highlight_field=item_id">https://opendocs.alipay.com/mini/4aa8dac1_alipay.open.app.localitem.create?pathHash=9bdb074d&highlight_field=item_id</a>创建商品，并获取item_id 平台侧商品ID作为这个入参的值。
        /// </summary>
        [XmlElement("goods_id")]
        public string GoodsId { get; set; }

        /// <summary>
        /// 应用ID
        /// </summary>
        [XmlElement("related_app_id")]
        public string RelatedAppId { get; set; }
    }
}
