using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayFincoreFunddsAccountWitnessCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayFincoreFunddsAccountWitnessCreateModel : AopObject
    {
        /// <summary>
        /// COMPANY-公司，INDIVIDUAL-个人
        /// </summary>
        [XmlElement("account_principal_type")]
        public string AccountPrincipalType { get; set; }

        /// <summary>
        /// 账户类型,目前支持ENTRUST_SUB_ACC托管子户,INST_PARTNER_SUB_ACCOUNT银行企业结算子户
        /// </summary>
        [XmlElement("account_type")]
        public string AccountType { get; set; }

        /// <summary>
        /// 可变ID，用来识别同一个user_id账户下面多维度账户。当account_type=ENTRUST_SUB_ACC或INST_PARTNER_SUB_ACCOUNT时生效。
        /// </summary>
        [XmlElement("external_entity_id")]
        public string ExternalEntityId { get; set; }

        /// <summary>
        /// 外部机构账户相关要素,当accountPrincipalType=INST_PARTNER_SUB_ACCOUNT或INST_USER_SUB_ACCOUNT时必填
        /// </summary>
        [XmlElement("inst_account_elements")]
        public InstAccountElementsDTO InstAccountElements { get; set; }

        /// <summary>
        /// 开户备注
        /// </summary>
        [XmlElement("memo")]
        public string Memo { get; set; }

        /// <summary>
        /// 必填，操作员，调用方appname
        /// </summary>
        [XmlElement("operator")]
        public string Operator { get; set; }

        /// <summary>
        /// 签约产品码,唯一,区分资金存管服务产品类型
        /// </summary>
        [XmlElement("product_code")]
        public string ProductCode { get; set; }

        /// <summary>
        /// 用户id或二级商户smid，子户维度。2088开头16位数字。
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
