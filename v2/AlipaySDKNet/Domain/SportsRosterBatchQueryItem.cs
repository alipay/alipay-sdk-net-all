using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// SportsRosterBatchQueryItem Data Structure.
    /// </summary>
    [Serializable]
    public class SportsRosterBatchQueryItem : AopObject
    {
        /// <summary>
        /// 部门（xxx/xx/xx 完整路径）
        /// </summary>
        [XmlElement("department")]
        public string Department { get; set; }

        /// <summary>
        /// 学工号
        /// </summary>
        [XmlElement("employee_no")]
        public string EmployeeNo { get; set; }

        /// <summary>
        /// 花名册姓名
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 状态 BIND 已绑定 / UNBIND 未绑定
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 花名册人员编码
        /// </summary>
        [XmlElement("user_code")]
        public string UserCode { get; set; }
    }
}
