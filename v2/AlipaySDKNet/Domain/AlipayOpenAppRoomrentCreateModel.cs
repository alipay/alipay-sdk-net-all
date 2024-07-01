using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenAppRoomrentCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenAppRoomrentCreateModel : AopObject
    {
        /// <summary>
        /// 通过alipay.open.app.localitem.template.query获取本地商品模板信息接口得到商品属性key，is_required=1时属性必填
        /// </summary>
        [XmlArray("attrs")]
        [XmlArrayItem("app_item_attr_v_o")]
        public List<AppItemAttrVO> Attrs { get; set; }

        /// <summary>
        /// 商品提报，如果需要自动推广则传此参数true，如没有这需求传false
        /// </summary>
        [XmlElement("auto_marketing_delivery")]
        public bool AutoMarketingDelivery { get; set; }

        /// <summary>
        /// 可通过alipay.open.app.localitem.allcategory.query接口获取
        /// </summary>
        [XmlElement("category_id")]
        public string CategoryId { get; set; }

        /// <summary>
        /// 展示在商品详情页的轮播图中，图片宽高为750px*750px，宽高比1:1，800kb以内。支持jpg、jpeg、png格式的图片。
        /// </summary>
        [XmlElement("head_img")]
        public string HeadImg { get; set; }

        /// <summary>
        /// 要求 APPID 下全局唯一
        /// </summary>
        [XmlElement("out_item_id")]
        public string OutItemId { get; set; }
    }
}
