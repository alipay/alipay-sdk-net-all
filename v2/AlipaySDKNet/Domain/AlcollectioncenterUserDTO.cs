using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlcollectioncenterUserDTO Data Structure.
    /// </summary>
    [Serializable]
    public class AlcollectioncenterUserDTO : AopObject
    {
        /// <summary>
        /// 案件id
        /// </summary>
        [XmlElement("affair_id")]
        public string AffairId { get; set; }

        /// <summary>
        /// 部门
        /// </summary>
        [XmlElement("dept_name")]
        public string DeptName { get; set; }

        /// <summary>
        /// 部门编号
        /// </summary>
        [XmlElement("dept_no")]
        public string DeptNo { get; set; }

        /// <summary>
        /// 邮箱
        /// </summary>
        [XmlElement("email")]
        public string Email { get; set; }

        /// <summary>
        /// 花名
        /// </summary>
        [XmlElement("nick_name")]
        public string NickName { get; set; }

        /// <summary>
        /// 姓名
        /// </summary>
        [XmlElement("real_name")]
        public string RealName { get; set; }

        /// <summary>
        /// 用户类型
        /// </summary>
        [XmlElement("user_type")]
        public string UserType { get; set; }

        /// <summary>
        /// 工号
        /// </summary>
        [XmlElement("work_no")]
        public string WorkNo { get; set; }
    }
}
