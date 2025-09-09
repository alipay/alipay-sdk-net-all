using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceHousingNewhouseLayoutSaveModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceHousingNewhouseLayoutSaveModel : AopObject
    {
        /// <summary>
        /// 楼栋信息
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
        /// null
        /// </summary>
        [XmlArray("layout_img")]
        [XmlArrayItem("string")]
        public List<string> LayoutImg { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("layout_video")]
        [XmlArrayItem("string")]
        public List<string> LayoutVideo { get; set; }

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
        /// 价格(元/套)
        /// </summary>
        [XmlElement("price")]
        public string Price { get; set; }
    }
}
