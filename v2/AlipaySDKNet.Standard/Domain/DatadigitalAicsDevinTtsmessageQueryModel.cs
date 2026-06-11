using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// DatadigitalAicsDevinTtsmessageQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class DatadigitalAicsDevinTtsmessageQueryModel : AopObject
    {
        /// <summary>
        /// 通话ID，从通话记录中获取
        /// </summary>
        [XmlElement("acid")]
        public string Acid { get; set; }

        /// <summary>
        /// 租户实例id，必填，智能拓客平台分配
        /// </summary>
        [XmlElement("tenant_id")]
        public string TenantId { get; set; }
    }
}
