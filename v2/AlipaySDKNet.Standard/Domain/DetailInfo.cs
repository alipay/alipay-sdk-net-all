using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// DetailInfo Data Structure.
    /// </summary>
    [Serializable]
    public class DetailInfo : AopObject
    {
        /// <summary>
        /// 数据类型
        /// </summary>
        [XmlElement("data_name")]
        public string DataName { get; set; }

        /// <summary>
        /// 数据值
        /// </summary>
        [XmlElement("data_value")]
        public string DataValue { get; set; }
    }
}
