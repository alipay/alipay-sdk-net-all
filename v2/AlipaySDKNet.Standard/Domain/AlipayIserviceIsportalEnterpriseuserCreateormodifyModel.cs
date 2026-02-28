using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayIserviceIsportalEnterpriseuserCreateormodifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayIserviceIsportalEnterpriseuserCreateormodifyModel : AopObject
    {
        /// <summary>
        /// 用户账号信息： tntInstId(租户id) account(账号) status(用户状态) orgId(组织架构id)
        /// </summary>
        [XmlElement("account")]
        public string Account { get; set; }

        /// <summary>
        /// 用户手机号
        /// </summary>
        [XmlElement("mobile")]
        public string Mobile { get; set; }

        /// <summary>
        /// 创建、修改或删除的类型，传入create、update、delete
        /// </summary>
        [XmlElement("operate")]
        public string Operate { get; set; }

        /// <summary>
        /// 用户的真实姓名
        /// </summary>
        [XmlElement("real_name")]
        public string RealName { get; set; }

        /// <summary>
        /// 用户角色
        /// </summary>
        [XmlElement("role_code")]
        public string RoleCode { get; set; }
    }
}
