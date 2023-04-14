using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MassifBaseInfo Data Structure.
    /// </summary>
    [Serializable]
    public class MassifBaseInfo : AopObject
    {
        /// <summary>
        /// 市
        /// </summary>
        [XmlElement("city")]
        public string City { get; set; }

        /// <summary>
        /// 县
        /// </summary>
        [XmlElement("county")]
        public string County { get; set; }

        /// <summary>
        /// 土地面积(亩） 土地确权、流转等合同总面积,单位亩 精度 double
        /// </summary>
        [XmlElement("land_area")]
        public string LandArea { get; set; }

        /// <summary>
        /// 地块名称
        /// </summary>
        [XmlElement("land_name")]
        public string LandName { get; set; }

        /// <summary>
        /// 大地块的标注数据，Json形式
        /// </summary>
        [XmlElement("lbs")]
        public string Lbs { get; set; }

        /// <summary>
        /// 地块编号
        /// </summary>
        [XmlElement("massif_id")]
        public string MassifId { get; set; }

        /// <summary>
        /// 种植大类
        /// </summary>
        [XmlElement("plant_category")]
        public string PlantCategory { get; set; }

        /// <summary>
        /// 种植小类
        /// </summary>
        [XmlElement("plant_crop")]
        public string PlantCrop { get; set; }

        /// <summary>
        /// 省
        /// </summary>
        [XmlElement("province")]
        public string Province { get; set; }
    }
}
