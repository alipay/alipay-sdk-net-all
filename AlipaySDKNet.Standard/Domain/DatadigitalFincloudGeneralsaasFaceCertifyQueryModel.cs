using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// DatadigitalFincloudGeneralsaasFaceCertifyQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class DatadigitalFincloudGeneralsaasFaceCertifyQueryModel : AopObject
    {
        /// <summary>
        /// 本次申请操作的唯一标识，通过initialize(身份认证初始化服务)接口同步响应获取。
        /// </summary>
        [XmlElement("certify_id")]
        public string CertifyId { get; set; }
    }
}
