using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// StoreInfo Data Structure.
    /// </summary>
    [Serializable]
    public class StoreInfo : AopObject
    {
        /// <summary>
        /// 支付宝品牌ID
        /// </summary>
        [XmlElement("alipay_brand_id")]
        public string AlipayBrandId { get; set; }

        /// <summary>
        /// 支付宝运营店ID
        /// </summary>
        [XmlElement("alipay_shop_id")]
        public string AlipayShopId { get; set; }

        /// <summary>
        /// 门店小程序列表
        /// </summary>
        [XmlElement("app_infos")]
        public Appinfos AppInfos { get; set; }

        /// <summary>
        /// 业务码
        /// </summary>
        [XmlElement("biz_code")]
        public string BizCode { get; set; }

        /// <summary>
        /// 操作类型: 飞猪开店  0 飞猪挂接关系调整 1
        /// </summary>
        [XmlElement("biz_type")]
        public long BizType { get; set; }

        /// <summary>
        /// 透传信息
        /// </summary>
        [XmlElement("ext")]
        public string Ext { get; set; }

        /// <summary>
        /// 飞猪POIID
        /// </summary>
        [XmlElement("fliggy_poi_id")]
        public long FliggyPoiId { get; set; }

        /// <summary>
        /// 小程序描述
        /// </summary>
        [XmlElement("mini_app_desc")]
        public string MiniAppDesc { get; set; }

        /// <summary>
        /// 小程序名称
        /// </summary>
        [XmlElement("mini_app_name")]
        public string MiniAppName { get; set; }

        /// <summary>
        /// 主账号ID
        /// </summary>
        [XmlElement("seller_id")]
        public long SellerId { get; set; }

        /// <summary>
        /// 卖家昵称
        /// </summary>
        [XmlElement("seller_nick")]
        public string SellerNick { get; set; }

        /// <summary>
        /// 商户中心门店ID
        /// </summary>
        [XmlElement("store_id")]
        public long StoreId { get; set; }

        /// <summary>
        /// 门店状态
        /// </summary>
        [XmlElement("store_status")]
        public long StoreStatus { get; set; }

        /// <summary>
        /// 子账号ID
        /// </summary>
        [XmlElement("sub_seller_id")]
        public long SubSellerId { get; set; }
    }
}
