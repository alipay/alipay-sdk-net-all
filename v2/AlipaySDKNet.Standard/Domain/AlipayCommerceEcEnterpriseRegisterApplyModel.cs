using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceEcEnterpriseRegisterApplyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceEcEnterpriseRegisterApplyModel : AopObject
    {
        /// <summary>
        /// 企业简称
        /// </summary>
        [XmlElement("enterprise_alias")]
        public string EnterpriseAlias { get; set; }

        /// <summary>
        /// 企业邮箱
        /// </summary>
        [XmlElement("enterprise_email")]
        public string EnterpriseEmail { get; set; }

        /// <summary>
        /// 企业名称
        /// </summary>
        [XmlElement("enterprise_name")]
        public string EnterpriseName { get; set; }

        /// <summary>
        /// 外部业务号
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 上级企业id
        /// </summary>
        [XmlElement("parent_enterprise_id")]
        public string ParentEnterpriseId { get; set; }
    }
}
