using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// BsEnrollParticipantResultDetail Data Structure.
    /// </summary>
    [Serializable]
    public class BsEnrollParticipantResultDetail : AopObject
    {
        /// <summary>
        /// 数字化门店id，仅当报名对象类型为SN，且方案类型为UTC时会返回
        /// </summary>
        [XmlElement("digital_poi_id")]
        public string DigitalPoiId { get; set; }

        /// <summary>
        /// 仅当报名对象类型为SN，且方案类型为UTC时会返回
        /// </summary>
        [XmlElement("digital_poi_name")]
        public string DigitalPoiName { get; set; }

        /// <summary>
        /// 返回报名对象的门店相关信息
        /// </summary>
        [XmlElement("store_address")]
        public BsEnrollParticipantAddress StoreAddress { get; set; }
    }
}
