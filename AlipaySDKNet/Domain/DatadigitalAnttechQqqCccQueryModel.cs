using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// DatadigitalAnttechQqqCccQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class DatadigitalAnttechQqqCccQueryModel : AopObject
    {
        /// <summary>
        /// 省份
        /// </summary>
        [XmlElement("province_code")]
        public string ProvinceCode { get; set; }

        /// <summary>
        /// dgbhr
        /// </summary>
        [XmlElement("re")]
        public string Re { get; set; }
    }
}
