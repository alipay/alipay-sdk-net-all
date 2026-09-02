using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// SolWifiShopInfo Data Structure.
    /// </summary>
    [Serializable]
    public class SolWifiShopInfo : AopObject
    {
        /// <summary>
        /// 1：新增必传； 2：修改可传，不传不修改；
        /// </summary>
        [XmlElement("city_code")]
        public string CityCode { get; set; }

        /// <summary>
        /// 1：新增必传； 2：修改可传，不传不修改；
        /// </summary>
        [XmlElement("city_name")]
        public string CityName { get; set; }

        /// <summary>
        /// 1：新增可传； 2：修改可传，不传不修改；
        /// </summary>
        [XmlElement("contact_number")]
        public string ContactNumber { get; set; }

        /// <summary>
        /// 1：新增必传； 2：修改可传，不传不修改；
        /// </summary>
        [XmlElement("detail")]
        public string Detail { get; set; }

        /// <summary>
        /// 1：新增必传; 2：修改可不传，不传不改;
        /// </summary>
        [XmlElement("district_code")]
        public string DistrictCode { get; set; }

        /// <summary>
        /// 1：新增必传; 2：修改可传，不传不改;
        /// </summary>
        [XmlElement("district_name")]
        public string DistrictName { get; set; }

        /// <summary>
        /// 1：新增可传； 2：修改可传，不传不修改；
        /// </summary>
        [XmlElement("door_number")]
        public string DoorNumber { get; set; }

        /// <summary>
        /// 1：新增可不传，默认ENABLE; 2：修改可不传，默认不变更;
        /// </summary>
        [XmlElement("enable_flag")]
        public string EnableFlag { get; set; }

        /// <summary>
        /// 1：新增可传； 2：修改可传，不传不修改；
        /// </summary>
        [XmlElement("latitude")]
        public string Latitude { get; set; }

        /// <summary>
        /// 1：新增可传； 2：修改可传，不传不修改；
        /// </summary>
        [XmlElement("longitude")]
        public string Longitude { get; set; }

        /// <summary>
        /// 1：新增可传； 2：修改可传，不传不修改；
        /// </summary>
        [XmlElement("province_code")]
        public string ProvinceCode { get; set; }

        /// <summary>
        /// 1：新增可传； 2：修改可传，不传不修改；
        /// </summary>
        [XmlElement("province_name")]
        public string ProvinceName { get; set; }

        /// <summary>
        /// 1：新增可不传; 2：修改必传;
        /// </summary>
        [XmlElement("shop_id")]
        public string ShopId { get; set; }

        /// <summary>
        /// 1：新增必传； 2：修改可传，不传不修改；
        /// </summary>
        [XmlElement("shop_name")]
        public string ShopName { get; set; }
    }
}
