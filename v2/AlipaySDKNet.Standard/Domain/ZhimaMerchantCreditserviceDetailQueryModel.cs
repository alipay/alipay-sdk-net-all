using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ZhimaMerchantCreditserviceDetailQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class ZhimaMerchantCreditserviceDetailQueryModel : AopObject
    {
        /// <summary>
        /// 信用服务ID，通过<a href="https://opendocs.alipay.com/apis/api_8/zhima.merchant.creditservice.detail.create">zhima.merchant.creditservice.detail.create</a>(芝麻信用信用服务创建)接口创建信用服务后获取。
        /// </summary>
        [XmlElement("credit_service_id")]
        public string CreditServiceId { get; set; }

        /// <summary>
        /// 信用服务版本的版本号。
        /// </summary>
        [XmlElement("version_no")]
        public string VersionNo { get; set; }
    }
}
