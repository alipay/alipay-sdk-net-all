using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// CreditPayGuaranteeAssetVO Data Structure.
    /// </summary>
    [Serializable]
    public class CreditPayGuaranteeAssetVO : AopObject
    {
        /// <summary>
        /// 信用支付基础视图
        /// </summary>
        [XmlElement("base_info")]
        public CreditPayAssetBaseVO BaseInfo { get; set; }

        /// <summary>
        /// 代偿方案
        /// </summary>
        [XmlElement("compensate_detail")]
        public CreditPayCompensateDetailVO CompensateDetail { get; set; }

        /// <summary>
        /// 担保期限
        /// </summary>
        [XmlElement("guar_term")]
        public long GuarTerm { get; set; }

        /// <summary>
        /// 担保期限类型(D-日，M-月，Y-年)
        /// </summary>
        [XmlElement("guar_term_type")]
        public string GuarTermType { get; set; }
    }
}
