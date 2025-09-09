using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AntfortuneFinresearchSessionDetailQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AntfortuneFinresearchSessionDetailQueryModel : AopObject
    {
        /// <summary>
        /// 合作方内部用户标识这个参数等价于identity_id，如果传了这个参数，会优先生效此参数，identity_id随便传一个即可。这个参数没传的话，identity_id一定要有值
        /// </summary>
        [XmlElement("bu_unique_id")]
        public string BuUniqueId { get; set; }

        /// <summary>
        /// 本次会话的主体ID, 业务方体系内部的id
        /// </summary>
        [XmlElement("identity_id")]
        public string IdentityId { get; set; }

        /// <summary>
        /// 会话ID
        /// </summary>
        [XmlElement("session_id")]
        public string SessionId { get; set; }

        /// <summary>
        /// 租户id, 已经分配租户id的请求方请务必要传，否则会造成接口失败
        /// </summary>
        [XmlElement("tenant_id")]
        public string TenantId { get; set; }
    }
}
