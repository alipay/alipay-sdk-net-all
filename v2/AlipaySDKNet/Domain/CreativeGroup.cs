using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// CreativeGroup Data Structure.
    /// </summary>
    [Serializable]
    public class CreativeGroup : AopObject
    {
        /// <summary>
        /// 素材组创建时间
        /// </summary>
        [XmlElement("create_time")]
        public string CreateTime { get; set; }

        /// <summary>
        /// 项目组描述
        /// </summary>
        [XmlElement("descrption")]
        public string Descrption { get; set; }

        /// <summary>
        /// 创意组id
        /// </summary>
        [XmlElement("group_id")]
        public string GroupId { get; set; }

        /// <summary>
        /// 项目组名称
        /// </summary>
        [XmlElement("group_name")]
        public string GroupName { get; set; }

        /// <summary>
        /// 创意组的包含的商品总数
        /// </summary>
        [XmlElement("item_sum_count")]
        public string ItemSumCount { get; set; }

        /// <summary>
        /// 创意组状态
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
