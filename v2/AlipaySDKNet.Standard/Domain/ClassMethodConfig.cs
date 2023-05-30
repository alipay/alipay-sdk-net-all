using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ClassMethodConfig Data Structure.
    /// </summary>
    [Serializable]
    public class ClassMethodConfig : AopObject
    {
        /// <summary>
        /// 加固的类名
        /// </summary>
        [XmlElement("class_name")]
        public string ClassName { get; set; }

        /// <summary>
        /// 方法集合，多个使用英文逗号分隔
        /// </summary>
        [XmlElement("methods")]
        public string Methods { get; set; }
    }
}
