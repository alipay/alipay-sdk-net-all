using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AppItemVoucherUseGuideInfo Data Structure.
    /// </summary>
    [Serializable]
    public class AppItemVoucherUseGuideInfo : AopObject
    {
        /// <summary>
        /// 小程序核销详情
        /// </summary>
        [XmlElement("app_item_mini_app_use_guide_info")]
        public AppItemMiniAppUseGuideInfo AppItemMiniAppUseGuideInfo { get; set; }

        /// <summary>
        /// 【描述】核销引导模式；根据不同引导模式，决定用户在支付宝卡包中使用优惠券的跳转页面。“标准商品列表”模式，跳转至可用券商品的汇总列表页；“小程序线上核销”模式，则跳转至商家提供的小程序页面，需要结合mini_app_url字段使用。 【枚举值】 ● 标准商品列表：STANDARD_ITEM_LIST ● 小程序线上核销：MINI_APP
        /// </summary>
        [XmlArray("use_guide_mode")]
        [XmlArrayItem("string")]
        public List<string> UseGuideMode { get; set; }
    }
}
