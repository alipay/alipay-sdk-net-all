using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// DecisionExtInfo Data Structure.
    /// </summary>
    [Serializable]
    public class DecisionExtInfo : AopObject
    {
        /// <summary>
        /// 省份编码，由入参传入后拼接到结果数据中
        /// </summary>
        [XmlElement("province_code")]
        public string ProvinceCode { get; set; }
    }
}
