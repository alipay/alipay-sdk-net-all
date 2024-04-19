using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// InvestorMaterialInfo Data Structure.
    /// </summary>
    [Serializable]
    public class InvestorMaterialInfo : AopObject
    {
        /// <summary>
        /// 材料文件ID
        /// </summary>
        [XmlElement("file_id")]
        public string FileId { get; set; }

        /// <summary>
        /// 材料文件链接
        /// </summary>
        [XmlElement("file_url")]
        public string FileUrl { get; set; }

        /// <summary>
        /// 合投材料类型
        /// </summary>
        [XmlElement("material_type")]
        public string MaterialType { get; set; }

        /// <summary>
        /// 用户材料类型大类
        /// </summary>
        [XmlElement("type")]
        public string Type { get; set; }
    }
}
