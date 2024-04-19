using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayEbppInvoiceInstitutionScopeModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEbppInvoiceInstitutionScopeModifyModel : AopObject
    {
        /// <summary>
        /// 企业共同账户id
        /// </summary>
        [XmlElement("account_id")]
        public string AccountId { get; set; }

        /// <summary>
        /// 制度适用范围类型
        /// </summary>
        [XmlElement("adapter_type")]
        public string AdapterType { get; set; }

        /// <summary>
        /// 增加适配id列表
        /// </summary>
        [XmlArray("add_owner_id_list")]
        [XmlArrayItem("string")]
        public List<string> AddOwnerIdList { get; set; }

        /// <summary>
        /// 增加适配开放id列表
        /// </summary>
        [XmlArray("add_owner_open_id_list")]
        [XmlArrayItem("string")]
        public List<string> AddOwnerOpenIdList { get; set; }

        /// <summary>
        /// 授权签约协议号
        /// </summary>
        [XmlElement("agreement_no")]
        public string AgreementNo { get; set; }

        /// <summary>
        /// 企业id
        /// </summary>
        [XmlElement("enterprise_id")]
        public string EnterpriseId { get; set; }

        /// <summary>
        /// 制度id
        /// </summary>
        [XmlElement("institution_id")]
        public string InstitutionId { get; set; }

        /// <summary>
        /// 归属类型
        /// </summary>
        [XmlElement("owner_type")]
        public string OwnerType { get; set; }

        /// <summary>
        /// 删除适配id列表
        /// </summary>
        [XmlArray("remove_owner_id_list")]
        [XmlArrayItem("string")]
        public List<string> RemoveOwnerIdList { get; set; }

        /// <summary>
        /// 删除适配开放id列表
        /// </summary>
        [XmlArray("remove_owner_open_id_list")]
        [XmlArrayItem("string")]
        public List<string> RemoveOwnerOpenIdList { get; set; }
    }
}
