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
        /// 信用服务ID，为必传字段。
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
