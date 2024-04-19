using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AppAttribute Data Structure.
    /// </summary>
    [Serializable]
    public class AppAttribute : AopObject
    {
        /// <summary>
        /// 属性的Key，对于类目属性，支付宝侧约定属性编码，商户侧根据实际情况，按需传入。具体可以参见接口所在功能包的产品说明文档。
        /// </summary>
        [XmlElement("key")]
        public string Key { get; set; }

        /// <summary>
        /// 属性的Value，对于类目属性，如果值是枚举化的，支付宝测约会定具体的编码，商户侧根据实际情况，按需传入。具体可以参考接口所在功能包的产品说明文档。
        /// </summary>
        [XmlArray("value")]
        [XmlArrayItem("string")]
        public List<string> Value { get; set; }
    }
}
