using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayBossProdAntlegalchainNdalistQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayBossProdAntlegalchainNdalistQueryModel : AopObject
    {
        /// <summary>
        /// 来源系统
        /// </summary>
        [XmlElement("app_code")]
        public string AppCode { get; set; }

        /// <summary>
        /// 协议编号
        /// </summary>
        [XmlElement("instl_id")]
        public long InstlId { get; set; }

        /// <summary>
        /// 操作人的员工工号,请注意是对应协议发布人企业/组织/团队的员工工号
        /// </summary>
        [XmlElement("opr_staff_id")]
        public string OprStaffId { get; set; }

        /// <summary>
        /// 当前页码，从1开始作为首页,如果不传，默认为1
        /// </summary>
        [XmlElement("page")]
        public long Page { get; set; }

        /// <summary>
        /// 签约状态，精确查询，值有SIGNED：已签约；SENT：未签约；FAILED：初始化失败；INIT：初始化中
        /// </summary>
        [XmlElement("sign_status")]
        public string SignStatus { get; set; }

        /// <summary>
        /// 每页结果条数,如果不传，默认为10，注意最大不能超过500条
        /// </summary>
        [XmlElement("size")]
        public long Size { get; set; }

        /// <summary>
        /// 协议签约人员工号，模糊查询,注意是对应协议发布人企业/组织/团队的员工工号
        /// </summary>
        [XmlElement("staff_id")]
        public string StaffId { get; set; }

        /// <summary>
        /// 协议签约人员名称，模糊查询
        /// </summary>
        [XmlElement("staff_name")]
        public string StaffName { get; set; }

        /// <summary>
        /// 租户信息
        /// </summary>
        [XmlElement("tenant")]
        public string Tenant { get; set; }
    }
}
