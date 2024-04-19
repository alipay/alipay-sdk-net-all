using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// VoucherPrincipalInfo Data Structure.
    /// </summary>
    [Serializable]
    public class VoucherPrincipalInfo : AopObject
    {
        /// <summary>
        /// 1、商户传入商户品牌id，由支付宝内部进行品牌映射关联 2、如传入此字段，请先行和支付宝联系。
        /// </summary>
        [XmlElement("brand_id")]
        public string BrandId { get; set; }

        /// <summary>
        /// 商户品牌的logo图片地址
        /// </summary>
        [XmlElement("brand_logo")]
        public string BrandLogo { get; set; }

        /// <summary>
        /// 商户品牌的中文名称
        /// </summary>
        [XmlElement("brand_name")]
        public string BrandName { get; set; }

        /// <summary>
        /// 发券小程序id
        /// </summary>
        [XmlElement("tiny_app_id")]
        public string TinyAppId { get; set; }
    }
}
