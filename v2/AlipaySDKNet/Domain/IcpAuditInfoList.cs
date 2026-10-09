using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// IcpAuditInfoList Data Structure.
    /// </summary>
    [Serializable]
    public class IcpAuditInfoList : AopObject
    {
        /// <summary>
        /// 小程序前置审批文件材料凭证media_id（参考：备案文件材料上传接口）
        /// </summary>
        [XmlElement("audit_material")]
        public string AuditMaterial { get; set; }

        /// <summary>
        /// 小程序前置审批号
        /// </summary>
        [XmlElement("audit_number")]
        public string AuditNumber { get; set; }

        /// <summary>
        /// 小程序前置审批项类型（参考：获取小程序前置审批项接口）
        /// </summary>
        [XmlElement("audit_type")]
        public string AuditType { get; set; }
    }
}
