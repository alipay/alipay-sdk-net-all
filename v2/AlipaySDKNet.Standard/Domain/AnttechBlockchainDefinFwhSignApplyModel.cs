using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AnttechBlockchainDefinFwhSignApplyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AnttechBlockchainDefinFwhSignApplyModel : AopObject
    {
        /// <summary>
        /// 授权有效期，单位为天；不填为永久有效
        /// </summary>
        [XmlElement("expiry_period")]
        public string ExpiryPeriod { get; set; }

        /// <summary>
        /// 商家证件号
        /// </summary>
        [XmlElement("merchant_id_number")]
        public string MerchantIdNumber { get; set; }

        /// <summary>
        /// 商家证件类型
        /// </summary>
        [XmlElement("merchant_id_type")]
        public string MerchantIdType { get; set; }

        /// <summary>
        /// 商家名称，即出金商家名称
        /// </summary>
        [XmlElement("merchant_name")]
        public string MerchantName { get; set; }

        /// <summary>
        /// 外部脱敏登录号，用于签约页面展示
        /// </summary>
        [XmlElement("outer_logon_id")]
        public string OuterLogonId { get; set; }

        /// <summary>
        /// 代扣授权产品合约码，即在产品中心签约的商户代扣产品一级合约编码，可联系运营获取
        /// </summary>
        [XmlElement("product_agrt_code")]
        public string ProductAgrtCode { get; set; }

        /// <summary>
        /// 请求流水号，即调用方系统中唯一流水号
        /// </summary>
        [XmlElement("request_no")]
        public string RequestNo { get; set; }

        /// <summary>
        /// 签约链接有效期，单位为秒；过期后该签约链接不可用；不传使用默认值
        /// </summary>
        [XmlElement("sign_link_expiry_period")]
        public string SignLinkExpiryPeriod { get; set; }
    }
}
