using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// GoodsMsgVO Data Structure.
    /// </summary>
    [Serializable]
    public class GoodsMsgVO : AopObject
    {
        /// <summary>
        /// 多个商品投放类型支持优惠券
        /// </summary>
        [XmlElement("activity_id")]
        public string ActivityId { get; set; }

        /// <summary>
        /// 自定义来源时必填,最多配置5个商品
        /// </summary>
        [XmlArray("custom_goods_list")]
        [XmlArrayItem("custom_goods_v_o")]
        public List<CustomGoodsVO> CustomGoodsList { get; set; }

        /// <summary>
        /// 对推送商品的简单介绍（参考：美妆好物应有尽有，快戳进来看看呀）
        /// </summary>
        [XmlElement("desc")]
        public string Desc { get; set; }

        /// <summary>
        /// 单商品投放类型时必填 商品Id。传入商品id后可支持在群内发商品消息。
        /// </summary>
        [XmlElement("goods_item_id")]
        public string GoodsItemId { get; set; }

        /// <summary>
        /// 多商品投放类型且商品库来源时必填,最多配置5个商品 商品Id。传入商品id后可支持在群内发商品消息。
        /// </summary>
        [XmlArray("goods_item_id_list")]
        [XmlArrayItem("string")]
        public List<string> GoodsItemIdList { get; set; }

        /// <summary>
        /// 商品库：goodsStore；自定义：custom 若选择自定义来源,自定义商品列表必填 若选择商品库来源,多哥商品投放时,平台侧商品ID列表必填;单个商品投放时,平台侧商品ID必填
        /// </summary>
        [XmlElement("goods_source")]
        public string GoodsSource { get; set; }

        /// <summary>
        /// 单个商品：false；多个商品：true 多个商品投放类型支持自定义商品和优惠券，单个商品投放类型不支持自定义商品和优惠券
        /// </summary>
        [XmlElement("multi_goods")]
        public bool MultiGoods { get; set; }

        /// <summary>
        /// 小程序应用id，商品库来源时必填
        /// </summary>
        [XmlElement("related_app_id")]
        public string RelatedAppId { get; set; }

        /// <summary>
        /// 推送的消息文案标题（参考：好物分享来咯！）
        /// </summary>
        [XmlElement("title")]
        public string Title { get; set; }
    }
}
