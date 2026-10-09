using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ContractPeople Data Structure.
    /// </summary>
    [Serializable]
    public class ContractPeople : AopObject
    {
        /// <summary>
        /// 域账号
        /// </summary>
        [XmlElement("login_name")]
        public string LoginName { get; set; }

        /// <summary>
        /// 花名
        /// </summary>
        [XmlElement("nick_name")]
        public string NickName { get; set; }

        /// <summary>
        /// 真实姓名
        /// </summary>
        [XmlElement("real_name")]
        public string RealName { get; set; }

        /// <summary>
        /// 合同用户是否传递的域账号表示 true 是 false 否
        /// </summary>
        [XmlElement("type_is_login_name")]
        public bool TypeIsLoginName { get; set; }

        /// <summary>
        /// 工号
        /// </summary>
        [XmlElement("work_no")]
        public string WorkNo { get; set; }
    }
}
