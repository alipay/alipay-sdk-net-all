using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AntfortuneFinresearchExpertframeworkListQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AntfortuneFinresearchExpertframeworkListQueryModel : AopObject
    {
        /// <summary>
        /// 分配给调用方的唯一id用于鉴权等操作，请勿转给别人
        /// </summary>
        [XmlElement("tenant_id")]
        public string TenantId { get; set; }
    }
}
