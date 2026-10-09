using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceEcEnterpriseRegisterapplyQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceEcEnterpriseRegisterapplyQueryModel : AopObject
    {
        /// <summary>
        /// 注册申请id
        /// </summary>
        [XmlElement("apply_id")]
        public string ApplyId { get; set; }

        /// <summary>
        /// 企业邮箱
        /// </summary>
        [XmlElement("enterprise_email")]
        public string EnterpriseEmail { get; set; }

        /// <summary>
        /// 企业名称模糊搜索
        /// </summary>
        [XmlElement("enterprise_name")]
        public string EnterpriseName { get; set; }

        /// <summary>
        /// 页码
        /// </summary>
        [XmlElement("page_num")]
        public long PageNum { get; set; }

        /// <summary>
        /// 页容量
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }
    }
}
