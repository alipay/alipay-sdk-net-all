using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// DatadigitalFincloudGeneralsaasDigitalcredentialVpQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class DatadigitalFincloudGeneralsaasDigitalcredentialVpQueryModel : AopObject
    {
        /// <summary>
        /// 数字凭证初始化接口返回的certify_id，用于查询加密VP。
        /// </summary>
        [XmlElement("certify_id")]
        public string CertifyId { get; set; }
    }
}
