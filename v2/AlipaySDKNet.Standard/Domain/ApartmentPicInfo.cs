using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ApartmentPicInfo Data Structure.
    /// </summary>
    [Serializable]
    public class ApartmentPicInfo : AopObject
    {
        /// <summary>
        /// 公寓外观图片
        /// </summary>
        [XmlArray("appearance_pic_list")]
        [XmlArrayItem("string")]
        public List<string> AppearancePicList { get; set; }

        /// <summary>
        /// 公寓休闲区的图片
        /// </summary>
        [XmlArray("function_area_pic_list")]
        [XmlArrayItem("string")]
        public List<string> FunctionAreaPicList { get; set; }

        /// <summary>
        /// 公寓大厅图片
        /// </summary>
        [XmlArray("hall_pic_list")]
        [XmlArrayItem("string")]
        public List<string> HallPicList { get; set; }

        /// <summary>
        /// 公寓休闲区的图片
        /// </summary>
        [XmlArray("leisure_area_pic_list")]
        [XmlArrayItem("string")]
        public List<string> LeisureAreaPicList { get; set; }
    }
}
