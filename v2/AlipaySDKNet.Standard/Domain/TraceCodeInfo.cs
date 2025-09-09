using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// TraceCodeInfo Data Structure.
    /// </summary>
    [Serializable]
    public class TraceCodeInfo : AopObject
    {
        /// <summary>
        /// APP方商品编码，对应商品接口的sku_code｜商品编码
        /// </summary>
        [XmlElement("app_item_code")]
        public string AppItemCode { get; set; }

        /// <summary>
        /// 商品追溯码集合
        /// </summary>
        [XmlArray("trace_codes")]
        [XmlArrayItem("string")]
        public List<string> TraceCodes { get; set; }
    }
}
