using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// InviteMemberBusinessParamsDTO Data Structure.
    /// </summary>
    [Serializable]
    public class InviteMemberBusinessParamsDTO : AopObject
    {
        /// <summary>
        /// 企业员工工卡
        /// </summary>
        [XmlElement("employee_id")]
        public string EmployeeId { get; set; }

        /// <summary>
        /// 出资信息
        /// </summary>
        [XmlElement("fund_ext_info")]
        public FundExtInfo FundExtInfo { get; set; }

        /// <summary>
        /// 员工关联的群组ID，当前系统仅支持一个
        /// </summary>
        [XmlArray("group_id_list")]
        [XmlArrayItem("string")]
        public List<string> GroupIdList { get; set; }
    }
}
