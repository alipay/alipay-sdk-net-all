using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenAppServicePromoQueryResponse.
    /// </summary>
    public class AlipayOpenAppServicePromoQueryResponse : AopResponse
    {
        /// <summary>
        /// 编辑中版本的服务场景素材详情
        /// </summary>
        [XmlElement("editing_service_promo")]
        public ServicePromoBaseVO EditingServicePromo { get; set; }

        /// <summary>
        /// 生效版本的服务场景素材详情
        /// </summary>
        [XmlElement("valid_service_promo")]
        public ServicePromoBaseVO ValidServicePromo { get; set; }
    }
}
