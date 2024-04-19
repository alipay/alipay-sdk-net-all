using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// OpenApiAuthAmountDTO Data Structure.
    /// </summary>
    [Serializable]
    public class OpenApiAuthAmountDTO : AopObject
    {
        /// <summary>
        /// 授权金额的数值，单位为：分.
        /// </summary>
        [XmlElement("amount")]
        public string Amount { get; set; }

        /// <summary>
        /// 授权因子
        /// </summary>
        [XmlElement("auth_factor")]
        public string AuthFactor { get; set; }

        /// <summary>
        /// 授权金额的币种
        /// </summary>
        [XmlElement("currency")]
        public string Currency { get; set; }
    }
}
