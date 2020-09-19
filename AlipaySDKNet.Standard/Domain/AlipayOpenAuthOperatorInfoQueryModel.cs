using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenAuthOperatorInfoQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenAuthOperatorInfoQueryModel : AopObject
    {
        /// <summary>
        /// 操作员查询参数
        /// </summary>
        [XmlElement("operator_query")]
        public OperatorQuery OperatorQuery { get; set; }

        /// <summary>
        /// 指定租户ID，新增值需联系蚂蚁操作员operator团队人工处理
        /// </summary>
        [XmlElement("tenant_id")]
        public string TenantId { get; set; }
    }
}
