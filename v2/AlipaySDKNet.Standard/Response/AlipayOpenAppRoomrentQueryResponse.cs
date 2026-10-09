using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenAppRoomrentQueryResponse.
    /// </summary>
    public class AlipayOpenAppRoomrentQueryResponse : AopResponse
    {
        /// <summary>
        /// 通过alipay.open.app.localitem.template.query获取本地商品模板信息接口得到商品属性key，is_required=1时属性必填
        /// </summary>
        [XmlElement("attrs")]
        public AppItemAttrVO Attrs { get; set; }

        /// <summary>
        /// 类目ID
        /// </summary>
        [XmlElement("category_id")]
        public string CategoryId { get; set; }

        /// <summary>
        /// 商品创建时间
        /// </summary>
        [XmlElement("create_time")]
        public string CreateTime { get; set; }

        /// <summary>
        /// 图片地址，展示在商品详情页的轮播图中，图片宽高为750px*750px，宽高比1:1，800kb以内。支持jpg、jpeg、png格式的图片。
        /// </summary>
        [XmlElement("head_img")]
        public string HeadImg { get; set; }

        /// <summary>
        /// 支付宝平台侧商品ID，是支付宝平台侧商品的唯一标识，后续与平台交互，需要使用该 ID，建议持久化。
        /// </summary>
        [XmlElement("item_id")]
        public string ItemId { get; set; }

        /// <summary>
        /// 字符类型，最少不低于3，最长不超过60个字。注：1.商品标题只允许汉字、数字、英文字母、特殊字符集；2.商品标题不得仅为数字、字母、特殊字符集或上述三种的组合。
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 要求 APPID 下全局唯一
        /// </summary>
        [XmlElement("out_item_id")]
        public string OutItemId { get; set; }

        /// <summary>
        /// 审核驳回：商品审核失败时，商品状态为审核驳回。 审核中：商品处于审核流程中时，商品状态为审核中。 已下架：商家可以通过调用接口下架商品，也可以通过商家后台下架商品。 可售卖：商家可以通过调用接口上架商品，也可以通过商家后台上架商品。 冻结：当商家出现违规操作时，支付宝侧将发起冻结，商品无法对外透出。 当商品包含多个规格时，只要有一个规格的商品状态为“可售卖”，spu的商品状态则为“可售卖”。
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 库存
        /// </summary>
        [XmlElement("stock_num")]
        public long StockNum { get; set; }

        /// <summary>
        /// 商品更新时间
        /// </summary>
        [XmlElement("update_time")]
        public string UpdateTime { get; set; }
    }
}
