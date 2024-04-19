using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenIotmbsImageModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenIotmbsImageModifyModel : AopObject
    {
        /// <summary>
        /// 配置的图片id列表
        /// </summary>
        [XmlArray("image_id_list")]
        [XmlArrayItem("string")]
        public List<string> ImageIdList { get; set; }

        /// <summary>
        /// 图片配置类型
        /// </summary>
        [XmlElement("operate_type")]
        public string OperateType { get; set; }

        /// <summary>
        /// 关联的项目id
        /// </summary>
        [XmlElement("project_id")]
        public string ProjectId { get; set; }
    }
}
