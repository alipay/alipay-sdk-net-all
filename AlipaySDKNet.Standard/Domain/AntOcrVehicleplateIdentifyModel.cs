using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AntOcrVehicleplateIdentifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AntOcrVehicleplateIdentifyModel : AopObject
    {
        /// <summary>
        /// 图片地址
        /// </summary>
        [XmlElement("image")]
        public string Image { get; set; }

        /// <summary>
        /// 图片存储类型，url：图片url地址；aftsId：afts文件服务Id
        /// </summary>
        [XmlElement("type")]
        public string Type { get; set; }
    }
}
