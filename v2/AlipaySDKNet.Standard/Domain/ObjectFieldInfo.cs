using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ObjectFieldInfo Data Structure.
    /// </summary>
    [Serializable]
    public class ObjectFieldInfo : AopObject
    {
        /// <summary>
        /// 属性key，如是否医保等，必须在对象库字段表里存在
        /// </summary>
        [XmlElement("key")]
        public string Key { get; set; }

        /// <summary>
        /// 属性值，如 true；上传图片时，先使用 alipay.open.file.upload 接口上传文件，返回 file_id 后通过这个值传入
        /// </summary>
        [XmlElement("value")]
        public string Value { get; set; }
    }
}
