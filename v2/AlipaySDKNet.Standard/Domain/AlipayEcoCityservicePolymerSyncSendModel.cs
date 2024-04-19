using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayEcoCityservicePolymerSyncSendModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEcoCityservicePolymerSyncSendModel : AopObject
    {
        /// <summary>
        /// 描述实体变更类型，包含新增、删除、修改
        /// </summary>
        [XmlElement("cud_type")]
        public string CudType { get; set; }

        /// <summary>
        /// 变更实体的详细内容，为json格式，根据entity_type的不同而具有不同的格式。
        /// </summary>
        [XmlElement("entity_content")]
        public string EntityContent { get; set; }

        /// <summary>
        /// 该参数为变更实体类型，可能的变更实体包含： 城市、分类、服务、展台、角标、标签
        /// </summary>
        [XmlElement("entity_type")]
        public string EntityType { get; set; }
    }
}
