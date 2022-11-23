using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceEcEmployeeTitleModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceEcEmployeeTitleModifyModel : AopObject
    {
        /// <summary>
        /// 共同账号id，与enterprise_id两者必填其一
        /// </summary>
        [XmlElement("account_id")]
        public string AccountId { get; set; }

        /// <summary>
        /// 创建人
        /// </summary>
        [XmlElement("create_by")]
        public string CreateBy { get; set; }

        /// <summary>
        /// 企业域定义的员工id，与user_id两者必填其一
        /// </summary>
        [XmlElement("employee_id")]
        public string EmployeeId { get; set; }

        /// <summary>
        /// 企业域定义下的企业id，与accountId两者必填其一
        /// </summary>
        [XmlElement("enterprise_id")]
        public string EnterpriseId { get; set; }

        /// <summary>
        /// 修改人
        /// </summary>
        [XmlElement("modify_by")]
        public string ModifyBy { get; set; }

        /// <summary>
        /// 修改后的抬头id
        /// </summary>
        [XmlElement("new_title_id")]
        public string NewTitleId { get; set; }

        /// <summary>
        /// 修改前的抬头id
        /// </summary>
        [XmlElement("old_title_id")]
        public string OldTitleId { get; set; }

        /// <summary>
        /// 支付宝open_id，与employee_id两者必填其一
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 员工抬头关系标
        /// </summary>
        [XmlElement("title_tag")]
        public string TitleTag { get; set; }

        /// <summary>
        /// 支付宝id2088，与employee_id两者必填其一
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
