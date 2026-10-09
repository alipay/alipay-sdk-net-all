using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenSearchboxDowngradePreconsultResponse.
    /// </summary>
    public class AlipayOpenSearchboxDowngradePreconsultResponse : AopResponse
    {
        /// <summary>
        /// 准入校验
        /// </summary>
        [XmlElement("access_check_info")]
        public AccessCheckInfo AccessCheckInfo { get; set; }

        /// <summary>
        /// 可申请的box类型; 为空代表不满足条件, 可通过 access_check_info查看不匹配规则详情
        /// </summary>
        [XmlElement("applicable_box_type")]
        public string ApplicableBoxType { get; set; }

        /// <summary>
        /// 品牌认证信息
        /// </summary>
        [XmlElement("brand_cert_info")]
        public BrandCertInfo BrandCertInfo { get; set; }

        /// <summary>
        /// 运营主体id;applicableBoxType不为空时,返回值不为空;品牌直达返回品牌id，其他直达返回小程序id
        /// </summary>
        [XmlElement("opt_principal_id")]
        public string OptPrincipalId { get; set; }

        /// <summary>
        /// 小程序信息
        /// </summary>
        [XmlElement("tiny_app_info")]
        public SearchBoxAppInfo TinyAppInfo { get; set; }
    }
}
