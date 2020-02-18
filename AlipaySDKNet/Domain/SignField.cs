using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// SignField Data Structure.
    /// </summary>
    [Serializable]
    public class SignField : AopObject
    {
        /// <summary>
        /// 平台自动签
        /// </summary>
        [XmlElement("auto_execute")]
        public string AutoExecute { get; set; }

        /// <summary>
        /// 签署人信息
        /// </summary>
        [XmlElement("signer")]
        public Signer Signer { get; set; }

        /// <summary>
        /// 模板组件id
        /// </summary>
        [XmlElement("struct_key")]
        public string StructKey { get; set; }
    }
}
