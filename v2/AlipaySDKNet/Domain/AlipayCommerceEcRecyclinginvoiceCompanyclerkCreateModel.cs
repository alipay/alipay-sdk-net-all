using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceEcRecyclinginvoiceCompanyclerkCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceEcRecyclinginvoiceCompanyclerkCreateModel : AopObject
    {
        /// <summary>
        /// 员工名称，新增开票员时以乐企可信开票员信息为准
        /// </summary>
        [XmlElement("clerk_name")]
        public string ClerkName { get; set; }

        /// <summary>
        /// 开票人身份标识
        /// </summary>
        [XmlElement("clerk_no")]
        public string ClerkNo { get; set; }

        /// <summary>
        /// 员工权限
        /// </summary>
        [XmlArray("clerk_permit_list")]
        [XmlArrayItem("string")]
        public List<string> ClerkPermitList { get; set; }

        /// <summary>
        /// 员工手机号
        /// </summary>
        [XmlElement("clerk_phone")]
        public string ClerkPhone { get; set; }

        /// <summary>
        /// 员工角色
        /// </summary>
        [XmlElement("clerk_role")]
        public string ClerkRole { get; set; }

        /// <summary>
        /// 外部营业员ID，用于唯一标识外部系统中的员工信息。该ID与外部系统的员工一一对应，确保数据的准确性和一致性。
        /// </summary>
        [XmlElement("out_clerk_id")]
        public string OutClerkId { get; set; }

        /// <summary>
        /// 企业（商户）税号
        /// </summary>
        [XmlElement("tax_no")]
        public string TaxNo { get; set; }
    }
}
