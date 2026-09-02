using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// NfcExpoCheckPlaceItemVO Data Structure.
    /// </summary>
    [Serializable]
    public class NfcExpoCheckPlaceItemVO : AopObject
    {
        /// <summary>
        /// 打卡小程序URL
        /// </summary>
        [XmlElement("check_app_url")]
        public string CheckAppUrl { get; set; }

        /// <summary>
        /// 是否打卡
        /// </summary>
        [XmlElement("checked")]
        public bool Checked { get; set; }

        /// <summary>
        /// 外部自定义标识
        /// </summary>
        [XmlElement("external_place_mark")]
        public string ExternalPlaceMark { get; set; }

        /// <summary>
        /// 打卡点全称
        /// </summary>
        [XmlElement("place_full_name")]
        public string PlaceFullName { get; set; }

        /// <summary>
        /// 打卡点id
        /// </summary>
        [XmlElement("place_id")]
        public string PlaceId { get; set; }

        /// <summary>
        /// 打卡点名称
        /// </summary>
        [XmlElement("place_name")]
        public string PlaceName { get; set; }

        /// <summary>
        /// 打卡点位置
        /// </summary>
        [XmlElement("position")]
        public string Position { get; set; }
    }
}
