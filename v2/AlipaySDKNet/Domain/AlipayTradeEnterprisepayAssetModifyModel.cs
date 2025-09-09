using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayTradeEnterprisepayAssetModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayTradeEnterprisepayAssetModifyModel : AopObject
    {
        /// <summary>
        /// 因公付企业账户ID
        /// </summary>
        [XmlElement("account_id")]
        public string AccountId { get; set; }

        /// <summary>
        /// 因公付账户需要切换的资产信息。没传则接口返回通用的资产切换链接，不限制指定资产。
        /// </summary>
        [XmlElement("asset_info")]
        public AssetInfoForm AssetInfo { get; set; }

        /// <summary>
        /// 场景码
        /// </summary>
        [XmlElement("biz_scene")]
        public string BizScene { get; set; }

        /// <summary>
        /// 用于标记支付宝用户在应用下的唯一标识
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 产品码
        /// </summary>
        [XmlElement("product_code")]
        public string ProductCode { get; set; }

        /// <summary>
        /// 支付宝用户的userId。
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
