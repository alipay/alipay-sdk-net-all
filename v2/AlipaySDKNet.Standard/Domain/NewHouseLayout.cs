using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// NewHouseLayout Data Structure.
    /// </summary>
    [Serializable]
    public class NewHouseLayout : AopObject
    {
        /// <summary>
        /// 如：1#楼，2#楼
        /// </summary>
        [XmlElement("buildings")]
        public string Buildings { get; set; }

        /// <summary>
        /// 建筑面积(平方米)
        /// </summary>
        [XmlElement("constructed_area")]
        public string ConstructedArea { get; set; }

        /// <summary>
        /// 楼盘id
        /// </summary>
        [XmlElement("estate_project_id")]
        public string EstateProjectId { get; set; }

        /// <summary>
        /// 外部户型id
        /// </summary>
        [XmlElement("external_id")]
        public string ExternalId { get; set; }

        /// <summary>
        /// 户型介绍
        /// </summary>
        [XmlElement("introduction")]
        public string Introduction { get; set; }

        /// <summary>
        /// 户型id
        /// </summary>
        [XmlElement("layout_id")]
        public string LayoutId { get; set; }

        /// <summary>
        /// 户型名称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 朝向
        /// </summary>
        [XmlElement("orientation")]
        public string Orientation { get; set; }

        /// <summary>
        /// 如：***万元/套
        /// </summary>
        [XmlElement("price")]
        public string Price { get; set; }
    }
}
