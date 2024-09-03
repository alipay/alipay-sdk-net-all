using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// StoreVO Data Structure.
    /// </summary>
    [Serializable]
    public class StoreVO : AopObject
    {
        /// <summary>
        /// 门店纬度
        /// </summary>
        [XmlElement("latitude")]
        public string Latitude { get; set; }

        /// <summary>
        /// 门店经度
        /// </summary>
        [XmlElement("longitude")]
        public string Longitude { get; set; }

        /// <summary>
        /// APP方门店ID
        /// </summary>
        [XmlElement("store_code")]
        public string StoreCode { get; set; }

        /// <summary>
        /// 平台方门店ID
        /// </summary>
        [XmlElement("store_id")]
        public long StoreId { get; set; }

        /// <summary>
        /// 门店名称
        /// </summary>
        [XmlElement("store_name")]
        public string StoreName { get; set; }

        /// <summary>
        /// 门店电话
        /// </summary>
        [XmlElement("store_phone")]
        public string StorePhone { get; set; }
    }
}
