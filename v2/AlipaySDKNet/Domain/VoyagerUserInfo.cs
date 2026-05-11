using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// VoyagerUserInfo Data Structure.
    /// </summary>
    [Serializable]
    public class VoyagerUserInfo : AopObject
    {
        /// <summary>
        /// Voyager对流量端分配的ID
        /// </summary>
        [XmlElement("traffic_side_id")]
        public string TrafficSideId { get; set; }

        /// <summary>
        /// Voyager业务在流量端的用户openId
        /// </summary>
        [XmlElement("traffic_side_open_id")]
        public string TrafficSideOpenId { get; set; }

        /// <summary>
        /// Voyager对外提供的用户openId
        /// </summary>
        [XmlElement("voyager_user_id")]
        public string VoyagerUserId { get; set; }
    }
}
