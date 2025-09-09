using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayDataHqtestCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayDataHqtestCreateModel : AopObject
    {
        /// <summary>
        /// 测试布尔
        /// </summary>
        [XmlElement("bool")]
        public bool Bool { get; set; }

        /// <summary>
        /// 布尔类型测试
        /// </summary>
        [XmlArray("bool_arr")]
        [XmlArrayItem("boolean")]
        public List<bool> BoolArr { get; set; }

        /// <summary>
        /// 测试日期
        /// </summary>
        [XmlElement("date")]
        public string Date { get; set; }

        /// <summary>
        /// 测试日期数组
        /// </summary>
        [XmlArray("date_arr")]
        [XmlArrayItem("date")]
        public List<string> DateArr { get; set; }

        /// <summary>
        /// 测试
        /// </summary>
        [XmlElement("test")]
        public string Test { get; set; }

        /// <summary>
        /// s啊撒撒撒
        /// </summary>
        [XmlElement("total")]
        public string Total { get; set; }
    }
}
