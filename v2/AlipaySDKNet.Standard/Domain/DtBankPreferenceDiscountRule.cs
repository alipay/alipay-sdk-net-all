using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// DtBankPreferenceDiscountRule Data Structure.
    /// </summary>
    [Serializable]
    public class DtBankPreferenceDiscountRule : AopObject
    {
        /// <summary>
        /// 折扣立减最大优惠金额，单位分
        /// </summary>
        [XmlElement("max_amount")]
        public long MaxAmount { get; set; }

        /// <summary>
        /// 折扣，例如85表示85折优惠，50表示5折优惠，5表示0.5折优惠，取值范围(0,100)。
        /// </summary>
        [XmlElement("ratio")]
        public long Ratio { get; set; }
    }
}
