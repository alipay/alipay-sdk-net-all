using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// TourInfoDTO Data Structure.
    /// </summary>
    [Serializable]
    public class TourInfoDTO : AopObject
    {
        /// <summary>
        /// 始发地
        /// </summary>
        [XmlElement("from_location")]
        public string FromLocation { get; set; }

        /// <summary>
        /// 出游套餐信息
        /// </summary>
        [XmlElement("package_info")]
        public TourPackageInfoDTO PackageInfo { get; set; }

        /// <summary>
        /// 目的地
        /// </summary>
        [XmlElement("to_location")]
        public string ToLocation { get; set; }
    }
}
