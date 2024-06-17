using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MedicalShopDeliveryPoint Data Structure.
    /// </summary>
    [Serializable]
    public class MedicalShopDeliveryPoint : AopObject
    {
        /// <summary>
        /// 1. 配送围栏点位维度，精确到小数点后6位； 2. 采用火星坐标系标准，其他坐标系需提前转换；
        /// </summary>
        [XmlElement("latitude")]
        public string Latitude { get; set; }

        /// <summary>
        /// 1. 配送围栏点位经度，精确到小数点后6位； 2. 采用火星坐标系标准，其他坐标系需提前转换；
        /// </summary>
        [XmlElement("longitude")]
        public string Longitude { get; set; }
    }
}
