using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayDataDataserviceAdBudgetcutTransferModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayDataDataserviceAdBudgetcutTransferModel : AopObject
    {
        /// <summary>
        /// 转入总金额（元）,支持两位小数
        /// </summary>
        [XmlElement("amount_total")]
        public string AmountTotal { get; set; }

        /// <summary>
        /// 分配模式： 自动分配-AUTO 自定义分配-CUSTOM 如选择了自定义分配，则必须输入现金金额、授信金额、流量红包金额、普通红包金额
        /// </summary>
        [XmlElement("assign_mod")]
        public string AssignMod { get; set; }

        /// <summary>
        /// 普通红包金额（元）,支持两位小数
        /// </summary>
        [XmlElement("benefit_amount")]
        public string BenefitAmount { get; set; }

        /// <summary>
        /// 钱包类型： 通用钱包-INTELLIGENT 外投钱包-XAB_BP
        /// </summary>
        [XmlElement("biz_scene")]
        public string BizScene { get; set; }

        /// <summary>
        /// 授信金额（元）,支持两位小数
        /// </summary>
        [XmlElement("credit_principal_amount")]
        public string CreditPrincipalAmount { get; set; }

        /// <summary>
        /// 流量红包金额（元）,支持两位小数
        /// </summary>
        [XmlElement("marketing_amount")]
        public string MarketingAmount { get; set; }

        /// <summary>
        /// 现金金额（元）,支持两位小数
        /// </summary>
        [XmlElement("principal_amount")]
        public string PrincipalAmount { get; set; }

        /// <summary>
        /// 根据此tag反查principal_id。转入方tag
        /// </summary>
        [XmlElement("principal_tag")]
        public string PrincipalTag { get; set; }
    }
}
