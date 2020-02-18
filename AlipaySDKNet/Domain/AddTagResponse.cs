using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AddTagResponse Data Structure.
    /// </summary>
    [Serializable]
    public class AddTagResponse : AopObject
    {
        /// <summary>
        /// 批量打标接口返回值
        /// </summary>
        [XmlArray("add_tag_result")]
        [XmlArrayItem("add_tag_result")]
        public List<AddTagResult> AddTagResult { get; set; }
    }
}
