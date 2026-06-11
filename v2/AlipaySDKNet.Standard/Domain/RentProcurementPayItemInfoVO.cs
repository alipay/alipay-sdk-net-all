using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RentProcurementPayItemInfoVO Data Structure.
    /// </summary>
    [Serializable]
    public class RentProcurementPayItemInfoVO : AopObject
    {
        /// <summary>
        /// 金额，单位：元，精确到小数点后两位
        /// </summary>
        [XmlElement("pay_amount")]
        public string PayAmount { get; set; }

        /// <summary>
        /// 费项类型
        /// </summary>
        [XmlElement("type")]
        public string Type { get; set; }
    }
}
