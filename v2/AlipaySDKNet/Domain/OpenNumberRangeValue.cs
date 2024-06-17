using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// OpenNumberRangeValue Data Structure.
    /// </summary>
    [Serializable]
    public class OpenNumberRangeValue : AopObject
    {
        /// <summary>
        /// 数值操作符是大于、大于等于、小于、小于等于时，传入单个数值，数值操作符是介于，传入2个数值，逗号分割。 不需要传入具体数值单位，如果是金额数值范围，传入金额范围单位是「元」。
        /// </summary>
        [XmlElement("number_value")]
        public string NumberValue { get; set; }

        /// <summary>
        /// 数值范围操作符
        /// </summary>
        [XmlElement("operator")]
        public string Operator { get; set; }
    }
}
