using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayFundWalletCollectioncodeCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayFundWalletCollectioncodeCreateModel : AopObject
    {
        /// <summary>
        /// 回跳链接，从收款码页面回跳的地址
        /// </summary>
        [XmlElement("back_url")]
        public string BackUrl { get; set; }

        /// <summary>
        /// 场景码
        /// </summary>
        [XmlElement("biz_scene")]
        public string BizScene { get; set; }

        /// <summary>
        /// 产品码，每一个产品都有属于自己的产品码，这里填的参数必须要和签约场景钱包产品码一致
        /// </summary>
        [XmlElement("product_code")]
        public string ProductCode { get; set; }

        /// <summary>
        /// 用户钱包id，用户开通钱包后的钱包id
        /// </summary>
        [XmlElement("user_wallet_id")]
        public string UserWalletId { get; set; }
    }
}
