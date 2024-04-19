using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// ZhimaMerchantCreditserviceModifyResponse.
    /// </summary>
    public class ZhimaMerchantCreditserviceModifyResponse : AopResponse
    {
        /// <summary>
        /// 信用服务ID，通过zhima.merchant.creditservice.create(芝麻信用信用服务创建)接口创建信用服务后获取。
        /// </summary>
        [XmlElement("credit_service_id")]
        public string CreditServiceId { get; set; }

        /// <summary>
        /// 成功创建后返回的信用服务的版本号，从1开始，随着信用服务配置更新递增。
        /// </summary>
        [XmlElement("version_no")]
        public string VersionNo { get; set; }
    }
}
