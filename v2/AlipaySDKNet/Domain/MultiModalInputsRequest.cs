using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MultiModalInputsRequest Data Structure.
    /// </summary>
    [Serializable]
    public class MultiModalInputsRequest : AopObject
    {
        /// <summary>
        /// 上传到atfs后的图片文件 ID 列表
        /// </summary>
        [XmlArray("images")]
        [XmlArrayItem("string")]
        public List<string> Images { get; set; }
    }
}
