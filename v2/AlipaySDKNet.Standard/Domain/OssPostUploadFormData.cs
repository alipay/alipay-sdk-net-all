using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// OssPostUploadFormData Data Structure.
    /// </summary>
    [Serializable]
    public class OssPostUploadFormData : AopObject
    {
        /// <summary>
        /// POST Form上传表单的参数名
        /// </summary>
        [XmlElement("key")]
        public string Key { get; set; }

        /// <summary>
        /// POST Form上传的参数值。
        /// </summary>
        [XmlElement("value")]
        public string Value { get; set; }
    }
}
