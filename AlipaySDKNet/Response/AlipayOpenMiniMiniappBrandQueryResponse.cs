using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenMiniMiniappBrandQueryResponse.
    /// </summary>
    public class AlipayOpenMiniMiniappBrandQueryResponse : AopResponse
    {
        /// <summary>
        /// 商户已有品牌
        /// </summary>
        [XmlElement("merchant_brand_list_result")]
        public MerchantBrandListResult MerchantBrandListResult { get; set; }

        /// <summary>
        /// 小程序品牌认证结果
        /// </summary>
        [XmlElement("miniapp_brand_audit_result")]
        public MiniappBrandAuditResult MiniappBrandAuditResult { get; set; }
    }
}
