using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCloudCloudrunStorageDirectoryDeleteModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCloudCloudrunStorageDirectoryDeleteModel : AopObject
    {
        /// <summary>
        /// 要删除的文件名称
        /// </summary>
        [XmlElement("dir_name")]
        public string DirName { get; set; }

        /// <summary>
        /// 环境ID
        /// </summary>
        [XmlElement("env")]
        public string Env { get; set; }

        /// <summary>
        /// 要删除的文件的路径
        /// </summary>
        [XmlElement("path")]
        public string Path { get; set; }
    }
}
