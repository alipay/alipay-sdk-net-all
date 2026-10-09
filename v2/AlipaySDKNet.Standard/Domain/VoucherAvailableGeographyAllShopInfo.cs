using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// VoucherAvailableGeographyAllShopInfo Data Structure.
    /// </summary>
    [Serializable]
    public class VoucherAvailableGeographyAllShopInfo : AopObject
    {
        /// <summary>
        /// 全部门店可用的品牌ID 提示: 1.目前只支持传入当前券归属商户的品牌ID 2.品牌ID可以在登录b.alipay.com-账户中心-品牌管理里查看。如果没有品牌，可以先创建品牌。Sop： 注意事项 1.只支持传入单个品牌ID 2.传入品牌ID后，券的商户品牌和logo仍以voucher_display_pattern_info传入为准。
        /// </summary>
        [XmlElement("available_brand_id")]
        public string AvailableBrandId { get; set; }

        /// <summary>
        /// 券不可使用的门店列表。指定商户全部门店可用时可通过该字段排除部分不可用门店。 列表中的门店id是通过调用接口ant.merchant.expand.shop.create创建门店返回的支付宝门店id 接口参数是列表类型。
        /// </summary>
        [XmlArray("exclude_shop_ids")]
        [XmlArrayItem("string")]
        public List<string> ExcludeShopIds { get; set; }

        /// <summary>
        /// 全部门店可用的商户ID
        /// </summary>
        [XmlArray("merchant_ids")]
        [XmlArrayItem("string")]
        public List<string> MerchantIds { get; set; }
    }
}
