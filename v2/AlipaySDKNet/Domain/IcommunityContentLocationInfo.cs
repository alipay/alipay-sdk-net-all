using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// IcommunityContentLocationInfo Data Structure.
    /// </summary>
    [Serializable]
    public class IcommunityContentLocationInfo : AopObject
    {
        /// <summary>
        /// 内容发布时的地理位置详细地址
        /// </summary>
        [XmlElement("location_detail")]
        public string LocationDetail { get; set; }

        /// <summary>
        /// 内容发布时的纬度
        /// </summary>
        [XmlElement("location_latitude")]
        public string LocationLatitude { get; set; }

        /// <summary>
        /// 内容发布时的经度
        /// </summary>
        [XmlElement("location_longitude")]
        public string LocationLongitude { get; set; }

        /// <summary>
        /// 内容发布时的地理位置名称
        /// </summary>
        [XmlElement("location_name")]
        public string LocationName { get; set; }
    }
}
