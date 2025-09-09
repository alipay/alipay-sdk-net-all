using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayIserviceItaskAvatarQuerytaskQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayIserviceItaskAvatarQuerytaskQueryModel : AopObject
    {
        /// <summary>
        /// 任务列表
        /// </summary>
        [XmlArray("ids")]
        [XmlArrayItem("number")]
        public List<long> Ids { get; set; }

        /// <summary>
        /// 租户code
        /// </summary>
        [XmlElement("tenant_code")]
        public string TenantCode { get; set; }
    }
}
