using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// EpBranchDetailInfo Data Structure.
    /// </summary>
    [Serializable]
    public class EpBranchDetailInfo : AopObject
    {
        /// <summary>
        /// 核准日期
        /// </summary>
        [XmlElement("approval_date")]
        public string ApprovalDate { get; set; }

        /// <summary>
        /// 企业名称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 分支机构曾用名
        /// </summary>
        [XmlArray("old_name")]
        [XmlArrayItem("string")]
        public List<string> OldName { get; set; }

        /// <summary>
        /// 企业分支机构登记机关
        /// </summary>
        [XmlElement("register_organ")]
        public string RegisterOrgan { get; set; }

        /// <summary>
        /// 企业分支机构登记状态
        /// </summary>
        [XmlElement("registration_state")]
        public string RegistrationState { get; set; }

        /// <summary>
        /// 企业工商注册号
        /// </summary>
        [XmlElement("registry_id")]
        public string RegistryId { get; set; }

        /// <summary>
        /// 企业注册号或统一社会信用代码，一般为18位
        /// </summary>
        [XmlElement("tyshxydm")]
        public string Tyshxydm { get; set; }
    }
}
