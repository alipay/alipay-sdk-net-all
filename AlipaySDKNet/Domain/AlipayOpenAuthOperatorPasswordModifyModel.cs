using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenAuthOperatorPasswordModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenAuthOperatorPasswordModifyModel : AopObject
    {
        /// <summary>
        /// 新的密码
        /// </summary>
        [XmlElement("new_password")]
        public string NewPassword { get; set; }

        /// <summary>
        /// 操作员
        /// </summary>
        [XmlElement("operator")]
        public OperatorQuery Operator { get; set; }

        /// <summary>
        /// 指定租户ID，新增值需联系蚂蚁操作员operator团队人工处理
        /// </summary>
        [XmlElement("tenant_id")]
        public string TenantId { get; set; }
    }
}
