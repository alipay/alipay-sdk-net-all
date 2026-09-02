using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// DistributionOrderInspectDeductFeeDTO Data Structure.
    /// </summary>
    [Serializable]
    public class DistributionOrderInspectDeductFeeDTO : AopObject
    {
        /// <summary>
        /// 费用金额，单位元
        /// </summary>
        [XmlElement("amount")]
        public string Amount { get; set; }

        /// <summary>
        /// 费用类型
        /// </summary>
        [XmlElement("type")]
        public string Type { get; set; }
    }
}
