using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayEcoCityserviceExtSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEcoCityserviceExtSyncModel : AopObject
    {
        /// <summary>
        /// 同步数据
        /// </summary>
        [XmlArray("data")]
        [XmlArrayItem("sync_data")]
        public List<SyncData> Data { get; set; }

        /// <summary>
        /// 数据同步类型
        /// </summary>
        [XmlElement("data_type")]
        public string DataType { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
