using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayUserCertifyOpenQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayUserCertifyOpenQueryModel : AopObject
    {
        /// <summary>
        /// 本次申请操作的唯一标识，由开放认证初始化接口调用后生成，后续的操作都需要用到
        /// </summary>
        [XmlElement("certify_id")]
        public string CertifyId { get; set; }
    }
}
