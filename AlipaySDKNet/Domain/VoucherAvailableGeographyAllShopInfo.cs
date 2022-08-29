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
