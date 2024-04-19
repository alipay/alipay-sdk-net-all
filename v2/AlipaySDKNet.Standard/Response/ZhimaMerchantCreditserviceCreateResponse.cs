using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// ZhimaMerchantCreditserviceCreateResponse.
    /// </summary>
    public class ZhimaMerchantCreditserviceCreateResponse : AopResponse
    {
        /// <summary>
        /// 成功创建后返回信用服务的ID。
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
