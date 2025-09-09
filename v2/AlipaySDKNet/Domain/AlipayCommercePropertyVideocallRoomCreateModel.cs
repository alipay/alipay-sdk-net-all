using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommercePropertyVideocallRoomCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommercePropertyVideocallRoomCreateModel : AopObject
    {
        /// <summary>
        /// 如果typeList有天猫精灵，则deviceId必传
        /// </summary>
        [XmlElement("device_id")]
        public string DeviceId { get; set; }

        /// <summary>
        /// 外部小区id,绿城天猫精灵模式必传
        /// </summary>
        [XmlElement("out_community_id")]
        public string OutCommunityId { get; set; }

        /// <summary>
        /// 如果typeList有三方跳转呼叫业主，则owner_id必传；
        /// </summary>
        [XmlElement("owner_id")]
        public string OwnerId { get; set; }

        /// <summary>
        /// 拨叫类型集合 消控室、 业主、 三方跳转呼叫业主、 三方跳转呼叫消控室、 天猫精灵
        /// </summary>
        [XmlArray("type_list")]
        [XmlArrayItem("string")]
        public List<string> TypeList { get; set; }

        /// <summary>
        /// 天猫精灵主叫端id
        /// </summary>
        [XmlElement("visitor_id")]
        public string VisitorId { get; set; }
    }
}
