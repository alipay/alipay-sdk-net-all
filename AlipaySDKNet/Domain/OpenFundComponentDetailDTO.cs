using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// OpenFundComponentDetailDTO Data Structure.
    /// </summary>
    [Serializable]
    public class OpenFundComponentDetailDTO : AopObject
    {
        /// <summary>
        /// 本次交易流水的金额
        /// </summary>
        [XmlElement("amount")]
        public long Amount { get; set; }

        /// <summary>
        /// 本次交易流水的现金价值
        /// </summary>
        [XmlElement("cash")]
        public long Cash { get; set; }

        /// <summary>
        /// 资金成分Id
        /// </summary>
        [XmlElement("component_id")]
        public string ComponentId { get; set; }

        /// <summary>
        /// 资金成分类型
        /// </summary>
        [XmlElement("component_type")]
        public string ComponentType { get; set; }

        /// <summary>
        /// 出资账号。 1) 资金池出资时，为fundSchemeId 2) 基础出资类型时，可能为空
        /// </summary>
        [XmlElement("fund_account")]
        public string FundAccount { get; set; }

        /// <summary>
        /// 出资子账号。 1）资金池出资时，为fundRelationGroupId。 2）基础出资类型时，可能为空
        /// </summary>
        [XmlElement("fund_sub_account")]
        public string FundSubAccount { get; set; }

        /// <summary>
        /// 出资类型: 基础出资类型时，可能为空
        /// </summary>
        [XmlElement("fund_type")]
        public string FundType { get; set; }
    }
}
