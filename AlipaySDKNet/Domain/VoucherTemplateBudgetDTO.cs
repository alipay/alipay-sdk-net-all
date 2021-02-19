using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// VoucherTemplateBudgetDTO Data Structure.
    /// </summary>
    [Serializable]
    public class VoucherTemplateBudgetDTO : AopObject
    {
        /// <summary>
        /// 当前可用余额，单位：分
        /// </summary>
        [XmlElement("current_amount")]
        public long CurrentAmount { get; set; }

        /// <summary>
        /// 预算类型，MONEY代表金额，AMOUNT代表数量
        /// </summary>
        [XmlElement("mode")]
        public string Mode { get; set; }

        /// <summary>
        /// 券模板ID
        /// </summary>
        [XmlElement("template_id")]
        public string TemplateId { get; set; }

        /// <summary>
        /// 总预算金额，单位：分
        /// </summary>
        [XmlElement("total_amount")]
        public long TotalAmount { get; set; }
    }
}
