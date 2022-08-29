using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenAuthOperatorInfoModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenAuthOperatorInfoModifyModel : AopObject
    {
        /// <summary>
        /// 操作员信息修改内容
        /// </summary>
        [XmlElement("modify_vo")]
        public OperatorModifyVO ModifyVo { get; set; }

        /// <summary>
        /// 操作员ID
        /// </summary>
        [XmlElement("operator_id")]
        public string OperatorId { get; set; }

        /// <summary>
        /// 指定租户ID，新增值需联系蚂蚁操作员operator团队人工处理
        /// </summary>
        [XmlElement("tenant_id")]
        public string TenantId { get; set; }
    }
}
