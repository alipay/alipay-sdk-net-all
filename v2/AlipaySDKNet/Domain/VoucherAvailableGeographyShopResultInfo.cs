using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// VoucherAvailableGeographyShopResultInfo Data Structure.
    /// </summary>
    [Serializable]
    public class VoucherAvailableGeographyShopResultInfo : AopObject
    {
        /// <summary>
        /// 全部门店结果。
        /// </summary>
        [XmlElement("available_geography_all_shop_result_info")]
        public VoucherAvailableGeographyAllShopResultInfo AvailableGeographyAllShopResultInfo { get; set; }

        /// <summary>
        /// 失败的物理门店详情。
        /// </summary>
        [XmlArray("fail_available_real_shop_infos")]
        [XmlArrayItem("voucher_fail_shop_info")]
        public List<VoucherFailShopInfo> FailAvailableRealShopInfos { get; set; }

        /// <summary>
        /// 失败的可用门店。
        /// </summary>
        [XmlArray("fail_available_shop_infos")]
        [XmlArrayItem("voucher_fail_shop_info")]
        public List<VoucherFailShopInfo> FailAvailableShopInfos { get; set; }

        /// <summary>
        /// 代运营商业关系门店列表，列表中的门店id是调用接口alipay.business.relation.shop.create创建门店返回的real_shop_id 接口参数是列表类型。
        /// </summary>
        [XmlArray("success_available_real_shop_ids")]
        [XmlArrayItem("string")]
        public List<string> SuccessAvailableRealShopIds { get; set; }

        /// <summary>
        /// 券可使用的门店列表。列表中的门店id是通过调用接口ant.merchant.expand.shop.create创建门店返回的支付宝门店id 接口参数是列表类型。
        /// </summary>
        [XmlArray("success_available_shop_ids")]
        [XmlArrayItem("string")]
        public List<string> SuccessAvailableShopIds { get; set; }
    }
}
