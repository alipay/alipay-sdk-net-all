using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceEcFundStrategyCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceEcFundStrategyCreateModel : AopObject
    {
        /// <summary>
        /// 企业id
        /// </summary>
        [XmlElement("enterprise_id")]
        public string EnterpriseId { get; set; }

        /// <summary>
        /// 出资账户唯一编号
        /// </summary>
        [XmlElement("fund_account_id")]
        public string FundAccountId { get; set; }

        /// <summary>
        /// 出资方式名称，不填写时，系统自动生成
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 账户使用条件
        /// </summary>
        [XmlArray("restrictions")]
        [XmlArrayItem("ec_pay_restriction")]
        public List<EcPayRestriction> Restrictions { get; set; }
    }
}
