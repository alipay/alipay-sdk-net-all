using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// CorroborationMaterials Data Structure.
    /// </summary>
    [Serializable]
    public class CorroborationMaterials : AopObject
    {
        /// <summary>
        /// 佐证材料文件列表
        /// </summary>
        [XmlArray("material_file_list")]
        [XmlArrayItem("string")]
        public List<string> MaterialFileList { get; set; }

        /// <summary>
        /// 当前材料的类型
        /// </summary>
        [XmlElement("material_type")]
        public string MaterialType { get; set; }
    }
}
