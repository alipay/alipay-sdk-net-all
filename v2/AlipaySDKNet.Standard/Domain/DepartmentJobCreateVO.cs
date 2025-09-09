using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// DepartmentJobCreateVO Data Structure.
    /// </summary>
    [Serializable]
    public class DepartmentJobCreateVO : AopObject
    {
        /// <summary>
        /// 部门id
        /// </summary>
        [XmlElement("department_id")]
        public string DepartmentId { get; set; }

        /// <summary>
        /// 岗位id 保安：SECURITY 保洁：CLEANING 保绿：GREENERY 保修：REPAIR
        /// </summary>
        [XmlElement("job_id")]
        public string JobId { get; set; }

        /// <summary>
        /// 类型 管理&属于：MANAGE_BELONG 管理：MANAGE 属于：BELONG（默认）
        /// </summary>
        [XmlElement("type")]
        public string Type { get; set; }
    }
}
