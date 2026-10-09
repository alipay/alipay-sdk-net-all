using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenAuthOperatorStateModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenAuthOperatorStateModifyModel : AopObject
    {
        /// <summary>
        /// 修改动作。取值如下： FREEZE=冻结操作员 UNFREEZE=解冻操作员 DELETE=删除操作员
        /// </summary>
        [XmlElement("action")]
        public string Action { get; set; }

        /// <summary>
        /// 操作员ID列表。一次最多20个
        /// </summary>
        [XmlArray("operator_ids")]
        [XmlArrayItem("string")]
        public List<string> OperatorIds { get; set; }

        /// <summary>
        /// 指定租户ID，新增值需联系蚂蚁操作员operator团队人工处理
        /// </summary>
        [XmlElement("tenant_id")]
        public string TenantId { get; set; }
    }
}
