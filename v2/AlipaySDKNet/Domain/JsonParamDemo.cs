using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// JsonParamDemo Data Structure.
    /// </summary>
    [Serializable]
    public class JsonParamDemo : AopObject
    {
        /// <summary>
        /// 列表
        /// </summary>
        [XmlArray("array_param")]
        [XmlArrayItem("string")]
        public List<string> ArrayParam { get; set; }

        /// <summary>
        /// 布尔类型参数
        /// </summary>
        [XmlElement("bool_param")]
        public bool BoolParam { get; set; }

        /// <summary>
        /// 日期
        /// </summary>
        [XmlElement("date_param")]
        public string DateParam { get; set; }

        /// <summary>
        /// 时间戳格式
        /// </summary>
        [XmlElement("datetime")]
        public string Datetime { get; set; }

        /// <summary>
        /// 数字类型参数
        /// </summary>
        [XmlElement("num_param")]
        public long NumParam { get; set; }

        /// <summary>
        /// 金额
        /// </summary>
        [XmlElement("price")]
        public string Price { get; set; }
    }
}
