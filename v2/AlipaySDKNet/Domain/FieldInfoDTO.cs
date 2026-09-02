using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// FieldInfoDTO Data Structure.
    /// </summary>
    [Serializable]
    public class FieldInfoDTO : AopObject
    {
        /// <summary>
        /// 字段Key，办事保险箱属性字段key，注册授权配置时分配
        /// </summary>
        [XmlElement("field_key")]
        public string FieldKey { get; set; }

        /// <summary>
        /// 字段值
        /// </summary>
        [XmlElement("field_value")]
        public string FieldValue { get; set; }
    }
}
