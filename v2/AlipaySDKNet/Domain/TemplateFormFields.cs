using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// TemplateFormFields Data Structure.
    /// </summary>
    [Serializable]
    public class TemplateFormFields : AopObject
    {
        /// <summary>
        /// 开卡表单可填字段，可选字段选项不能与必填字段required重复
        /// </summary>
        [XmlArray("optional")]
        [XmlArrayItem("string")]
        public List<string> Optional { get; set; }

        /// <summary>
        /// 开卡表单必填字段，必填字段必须有一个值，并且不能与可选字段optional里面重复
        /// </summary>
        [XmlArray("required")]
        [XmlArrayItem("string")]
        public List<string> Required { get; set; }
    }
}
