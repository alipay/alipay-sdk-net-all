using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayBossProdAntlegalchainNdasignerCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayBossProdAntlegalchainNdasignerCreateModel : AopObject
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
        /// 签约人列表,新增签约人单批次不能超过200人，且不传员工名字会查询名字，传员工名字则按该名字发起签约
        /// </summary>
        [XmlArray("signer_list")]
        [XmlArrayItem("antlc_signer_request")]
        public List<AntlcSignerRequest> SignerList { get; set; }

        /// <summary>
        /// 租户信息
        /// </summary>
        [XmlElement("tenant")]
        public string Tenant { get; set; }
    }
}
