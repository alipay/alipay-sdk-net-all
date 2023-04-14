using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayFundZcardprodMerchantSignModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayFundZcardprodMerchantSignModel : AopObject
    {
        /// <summary>
        /// 账户名称 该名称会显示在账单和收银台
        /// </summary>
        [XmlElement("account_name")]
        public string AccountName { get; set; }

        /// <summary>
        /// 餐饮
        /// </summary>
        [XmlElement("biz_scene_code")]
        public string BizSceneCode { get; set; }

        /// <summary>
        /// 场景id（商户自己控制幂等维度） 注意：商户在同一场景id下只能生成一个账户
        /// </summary>
        [XmlElement("biz_scene_id")]
        public string BizSceneId { get; set; }

        /// <summary>
        /// 扩展字段
        /// </summary>
        [XmlElement("business_params")]
        public string BusinessParams { get; set; }

        /// <summary>
        /// 支卡通
        /// </summary>
        [XmlElement("product_code")]
        public string ProductCode { get; set; }
    }
}
