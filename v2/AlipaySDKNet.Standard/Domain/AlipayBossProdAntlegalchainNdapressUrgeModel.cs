using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayBossProdAntlegalchainNdapressUrgeModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayBossProdAntlegalchainNdapressUrgeModel : AopObject
    {
        /// <summary>
        /// 来源系统
        /// </summary>
        [XmlElement("app_code")]
        public string AppCode { get; set; }

        /// <summary>
        /// 协议编号,请注意过期协议，非签约中协议都是不能催签的
        /// </summary>
        [XmlElement("instl_id")]
        public long InstlId { get; set; }

        /// <summary>
        /// 操作人的员工工号,请注意是对应协议发布人企业/组织/团队的员工工号
        /// </summary>
        [XmlElement("opr_staff_id")]
        public string OprStaffId { get; set; }

        /// <summary>
        /// 协议签约人员工号集合,请注意是对应协议发布人企业/组织/团队的员工工号，请注意如果传入错误或不存在的工号，所有工号催签失败
        /// </summary>
        [XmlArray("staff_ids")]
        [XmlArrayItem("string")]
        public List<string> StaffIds { get; set; }

        /// <summary>
        /// 租户信息
        /// </summary>
        [XmlElement("tenant")]
        public string Tenant { get; set; }
    }
}
