using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayTradeSolutionprodMerchantupgradeApplyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayTradeSolutionprodMerchantupgradeApplyModel : AopObject
    {
        /// <summary>
        /// 结果页点击完成后的跳转地址 1、跳转类型为ALIPAY_URL，back_url就做支付宝端内跳转 2、跳转类型为MERCHANT_URL，back_url就跳转到端外
        /// </summary>
        [XmlElement("back_url")]
        public string BackUrl { get; set; }

        /// <summary>
        /// 用于升级完成之后的回跳地址类型： 1、类型为MERCHANT_URL，代表需要回跳至端外商户地址，back_url按照跳端方式拼接 2、类型为ALIPAY_URL，代表需要回跳至支付宝端内地址，back_url按照跳支付宝端内方式拼接，支持小程序或h5
        /// </summary>
        [XmlElement("back_url_type")]
        public string BackUrlType { get; set; }

        /// <summary>
        /// 个人商户的城市名称
        /// </summary>
        [XmlElement("city_name")]
        public string CityName { get; set; }

        /// <summary>
        /// 当前个人收款方类型
        /// </summary>
        [XmlElement("current_merchant_type")]
        public string CurrentMerchantType { get; set; }

        /// <summary>
        /// 外部单据号，由商家自定义。64个字符以内，仅可包含字母、数字、下划线。需保证在商户端不重复。该参数用于幂等
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 个人商户省份的名称
        /// </summary>
        [XmlElement("province_name")]
        public string ProvinceName { get; set; }

        /// <summary>
        /// 个人收款方使用服务
        /// </summary>
        [XmlArray("service")]
        [XmlArrayItem("string")]
        public List<string> Service { get; set; }

        /// <summary>
        /// 商户站点信息,包括网站、app、小程序。商户使用服务包含电脑支付，必须填充一个类型为01(网站)的SolutionSiteInfo对象，site_type/site_url/site_name必填；、当包含wap支付时，必须至少填充类型为01(网站)或07(手机网站)中一种类型的SolutionSiteInfo对象，site_type/site_url/site_name必填；当包含app支付时，必须至少填充类型为02(APP)或06(支付宝小程序)中一种类型的SolutionSiteInfo对象，site_type/site_name必填；当包含jsapi支付时，必须填充一个类型为06(支付宝小程序)的SolutionSiteInfo对象site_type/site_url/site_name/tiny_app_id必填；
        /// </summary>
        [XmlArray("sites")]
        [XmlArrayItem("solution_site_info")]
        public List<SolutionSiteInfo> Sites { get; set; }

        /// <summary>
        /// 需要升级的个人收款方smid
        /// </summary>
        [XmlElement("smid")]
        public string Smid { get; set; }

        /// <summary>
        /// 解决方案code
        /// </summary>
        [XmlElement("solution_code")]
        public string SolutionCode { get; set; }

        /// <summary>
        /// 目标个人收款方类型，当前仅支持PERSONAL_MERCHANTS
        /// </summary>
        [XmlElement("target_merchant_type")]
        public string TargetMerchantType { get; set; }
    }
}
