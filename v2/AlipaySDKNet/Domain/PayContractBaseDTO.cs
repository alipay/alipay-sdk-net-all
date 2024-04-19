using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// PayContractBaseDTO Data Structure.
    /// </summary>
    [Serializable]
    public class PayContractBaseDTO : AopObject
    {
        /// <summary>
        /// 合约号
        /// </summary>
        [XmlElement("agreement_no")]
        public string AgreementNo { get; set; }

        /// <summary>
        /// 合约来源,集采平台：acep
        /// </summary>
        [XmlElement("agreement_source")]
        public string AgreementSource { get; set; }

        /// <summary>
        /// 业务产品码
        /// </summary>
        [XmlElement("biz_pd_code")]
        public string BizPdCode { get; set; }

        /// <summary>
        /// 幂等号
        /// </summary>
        [XmlElement("idempotent_no")]
        public string IdempotentNo { get; set; }

        /// <summary>
        /// 供应商蚂蚁2088账号
        /// </summary>
        [XmlElement("ip_role_id")]
        public string IpRoleId { get; set; }

        /// <summary>
        /// 供应商来源
        /// </summary>
        [XmlElement("ip_role_source")]
        public string IpRoleSource { get; set; }

        /// <summary>
        /// 端产品码
        /// </summary>
        [XmlElement("pd_code")]
        public string PdCode { get; set; }

        /// <summary>
        /// 签约产品码
        /// </summary>
        [XmlElement("sales_product_code")]
        public string SalesProductCode { get; set; }
    }
}
