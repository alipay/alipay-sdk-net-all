using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCloudCloudrunObjectstorageFilelistDeleteModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCloudCloudrunObjectstorageFilelistDeleteModel : AopObject
    {
        /// <summary>
        /// 环境ID
        /// </summary>
        [XmlElement("env")]
        public string Env { get; set; }

        /// <summary>
        /// 要删除的文件id列表
        /// </summary>
        [XmlArray("file_id_list")]
        [XmlArrayItem("string")]
        public List<string> FileIdList { get; set; }
    }
}
