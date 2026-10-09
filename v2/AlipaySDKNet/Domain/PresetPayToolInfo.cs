using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// PresetPayToolInfo Data Structure.
    /// </summary>
    [Serializable]
    public class PresetPayToolInfo : AopObject
    {
        /// <summary>
        /// 前置资产金额
        /// </summary>
        [XmlArray("amount")]
        [XmlArrayItem("price")]
        public List<string> Amount { get; set; }

        /// <summary>
        /// 前置资产类型编码，和收单支付传入的preset_pay_tool里面的类型编码保持一致。
        /// </summary>
        [XmlElement("assert_type_code")]
        public string AssertTypeCode { get; set; }
    }
}
