using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayMerchantSolcreditserviceprodMerchantreviewQueryResponse.
    /// </summary>
    public class AlipayMerchantSolcreditserviceprodMerchantreviewQueryResponse : AopResponse
    {
        /// <summary>
        /// 不传则默认小程序首页
        /// </summary>
        [XmlElement("app_jump_link")]
        public string AppJumpLink { get; set; }

        /// <summary>
        /// 商户邮箱
        /// </summary>
        [XmlElement("contact_email")]
        public string ContactEmail { get; set; }

        /// <summary>
        /// 座机或手机
        /// </summary>
        [XmlElement("contact_number")]
        public string ContactNumber { get; set; }

        /// <summary>
        /// 需要使用通用图片上传接口返回的链接
        /// </summary>
        [XmlElement("logo_url")]
        public string LogoUrl { get; set; }

        /// <summary>
        /// 商户使用的小程序ID
        /// </summary>
        [XmlElement("merchant_app_id")]
        public string MerchantAppId { get; set; }

        /// <summary>
        /// 商家自定义
        /// </summary>
        [XmlElement("merchant_name")]
        public string MerchantName { get; set; }

        /// <summary>
        /// 信用服务守护配置，为必传字段。此字段为复杂模型，其中商户服务电话为必传属性。
        /// </summary>
        [XmlElement("promise_config")]
        public PromiseConfigDTO PromiseConfig { get; set; }

        /// <summary>
        /// 信用服务风控配置，为必传字段。此字段为复杂模型，其中类目code为必传属性。
        /// </summary>
        [XmlElement("risk_config")]
        public RiskConfigDTO RiskConfig { get; set; }

        /// <summary>
        /// 对应使用场景
        /// </summary>
        [XmlElement("scene_code")]
        public string SceneCode { get; set; }

        /// <summary>
        /// 为空则表示暂无审核通过版本
        /// </summary>
        [XmlElement("version_no")]
        public string VersionNo { get; set; }
    }
}
