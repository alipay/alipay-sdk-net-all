using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// DatadigitalFincloudGeneralsaasOnepassQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class DatadigitalFincloudGeneralsaasOnepassQueryModel : AopObject
    {
        /// <summary>
        /// 填入一键登录/H5一键登录阶段获取到的certify_id
        /// </summary>
        [XmlElement("certify_id")]
        public string CertifyId { get; set; }
    }
}
