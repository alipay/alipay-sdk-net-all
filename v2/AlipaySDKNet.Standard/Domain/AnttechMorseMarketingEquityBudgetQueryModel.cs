using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AnttechMorseMarketingEquityBudgetQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AnttechMorseMarketingEquityBudgetQueryModel : AopObject
    {
        /// <summary>
        /// 开发者可从摩斯营销计划的权益配置或权益创建结果中获取：立减权益填写对应的discountId；立减金权益填写对应的outputCampaignId。该权益必须归属于tenant_id指定的租户。
        /// </summary>
        [XmlElement("equity_id")]
        public string EquityId { get; set; }

        /// <summary>
        /// 摩斯营销计划租户ID，必须与调用应用授权的租户一致
        /// </summary>
        [XmlElement("tenant_id")]
        public string TenantId { get; set; }
    }
}
