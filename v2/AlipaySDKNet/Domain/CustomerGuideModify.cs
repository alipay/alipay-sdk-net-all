using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// CustomerGuideModify Data Structure.
    /// </summary>
    [Serializable]
    public class CustomerGuideModify : AopObject
    {
        /// <summary>
        /// 券可用的小程序 appId，卡包详情页可跳转到该 appId。
        /// </summary>
        [XmlElement("mini_app_id")]
        public string MiniAppId { get; set; }

        /// <summary>
        /// 指定跳转到 mini_app_id 时的具体页面路径。
        /// </summary>
        [XmlElement("mini_app_path")]
        public string MiniAppPath { get; set; }

        /// <summary>
        /// 券可使用的商业关系门店列表,列表中的门店id是调用接口alipay.business.relation.shop.create创建门店返回的real_shop_id。
        /// </summary>
        [XmlArray("real_shop_ids")]
        [XmlArrayItem("string")]
        public List<string> RealShopIds { get; set; }

        /// <summary>
        /// 小程序服务编码，通过 alipay.open.app.appcontent.function.create(小程序服务创建)接口创建服务后获取。
        /// </summary>
        [XmlArray("service_codes")]
        [XmlArrayItem("string")]
        public List<string> ServiceCodes { get; set; }

        /// <summary>
        /// 券可使用的门店列表。列表中的门店id是通过调用接口ant.merchant.expand.shop.create创建门店返回的支付宝门店 id 接口参数是列表类型。 接口参数是列表类型。
        /// </summary>
        [XmlArray("shop_ids")]
        [XmlArrayItem("string")]
        public List<string> ShopIds { get; set; }

        /// <summary>
        /// 后续废弃。券可使用的门店列表。列表中的门店id是通过调用接口ant.merchant.expand.shop.create创建门店返回的支付宝门店 id 接口参数是列表类型。 接口参数是列表类型。
        /// </summary>
        [XmlArray("store_ids")]
        [XmlArrayItem("string")]
        public List<string> StoreIds { get; set; }

        /// <summary>
        /// 券发放引导信息。
        /// </summary>
        [XmlElement("voucher_send_guide")]
        public VoucherSendGuideModify VoucherSendGuide { get; set; }

        /// <summary>
        /// 券核销引导信息。
        /// </summary>
        [XmlElement("voucher_use_guide")]
        public VoucherUseGuideModify VoucherUseGuide { get; set; }
    }
}
