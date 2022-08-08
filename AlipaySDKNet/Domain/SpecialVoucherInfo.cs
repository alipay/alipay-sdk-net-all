using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// SpecialVoucherInfo Data Structure.
    /// </summary>
    [Serializable]
    public class SpecialVoucherInfo : AopObject
    {
        /// <summary>
        /// 门槛金额。 限制： 币种为人民币，单位为元； 小数点以后最多保留两位； 取值范围:0.1<=x<= 50000; 说明： 该字段可不填，认为无门槛;
        /// </summary>
        [XmlElement("floor_amount")]
        public string FloorAmount { get; set; }

        /// <summary>
        /// 特价，即：原价-特价=优惠金额。 限制： 币种为人民币，单位为元。小数点以后最多保留两位; 取值范围:0<=x<=999; 原价必须大于特价，即:origin_amount>special_amount;
        /// </summary>
        [XmlElement("special_amount")]
        public string SpecialAmount { get; set; }
    }
}
