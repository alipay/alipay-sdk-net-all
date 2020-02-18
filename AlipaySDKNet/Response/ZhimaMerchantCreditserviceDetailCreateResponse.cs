using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// ZhimaMerchantCreditserviceDetailCreateResponse.
    /// </summary>
    public class ZhimaMerchantCreditserviceDetailCreateResponse : AopResponse
    {
        /// <summary>
        /// 信用服务ID，是成功创建信用服务的ID。
        /// </summary>
        [XmlElement("credit_service_id")]
        public string CreditServiceId { get; set; }

        /// <summary>
        /// 信用服务版本号，是成功创建信用服务的版本号。
        /// </summary>
        [XmlElement("version_no")]
        public string VersionNo { get; set; }
    }
}
