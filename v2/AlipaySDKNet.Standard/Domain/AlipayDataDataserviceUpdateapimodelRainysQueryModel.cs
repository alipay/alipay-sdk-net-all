using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayDataDataserviceUpdateapimodelRainysQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayDataDataserviceUpdateapimodelRainysQueryModel : AopObject
    {
        /// <summary>
        /// 123
        /// </summary>
        [XmlArray("array_tc_1")]
        [XmlArrayItem("string")]
        public List<string> ArrayTc1 { get; set; }

        /// <summary>
        /// 存量数据修改
        /// </summary>
        [XmlElement("rainy_test")]
        public string RainyTest { get; set; }
    }
}
