using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceEducateTrainShopModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceEducateTrainShopModifyModel : AopObject
    {
        /// <summary>
        /// 经营地址信息
        /// </summary>
        [XmlElement("address_info")]
        public ShopAddressInfo AddressInfo { get; set; }

        /// <summary>
        /// 小程序appId
        /// </summary>
        [XmlElement("applet_appid")]
        public string AppletAppid { get; set; }

        /// <summary>
        /// 业务类型
        /// </summary>
        [XmlElement("biz_type")]
        public string BizType { get; set; }

        /// <summary>
        /// 店铺简介
        /// </summary>
        [XmlElement("desc")]
        public string Desc { get; set; }

        /// <summary>
        /// 收款账户
        /// </summary>
        [XmlElement("income_account")]
        public string IncomeAccount { get; set; }

        /// <summary>
        /// 店铺所属商家信息
        /// </summary>
        [XmlElement("merchant_info")]
        public ShopMerchantInfo MerchantInfo { get; set; }

        /// <summary>
        /// 店铺名称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 外部店铺id
        /// </summary>
        [XmlElement("out_shop_id")]
        public string OutShopId { get; set; }

        /// <summary>
        /// 图片地址
        /// </summary>
        [XmlElement("pic")]
        public string Pic { get; set; }

        /// <summary>
        /// 客服电话列表
        /// </summary>
        [XmlArray("service_phone")]
        [XmlArrayItem("string")]
        public List<string> ServicePhone { get; set; }

        /// <summary>
        /// 支付宝店铺id
        /// </summary>
        [XmlElement("shop_id")]
        public string ShopId { get; set; }

        /// <summary>
        /// 来源类型(XIAOBAO：校宝)
        /// </summary>
        [XmlElement("source_type")]
        public string SourceType { get; set; }

        /// <summary>
        /// 店铺url
        /// </summary>
        [XmlElement("url")]
        public string Url { get; set; }
    }
}
