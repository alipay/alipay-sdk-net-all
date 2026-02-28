using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceTransportTrafficshareCrowdSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceTransportTrafficshareCrowdSyncModel : AopObject
    {
        /// <summary>
        /// 由商户侧定义本次业务传输的用户归属的人群类型标识
        /// </summary>
        [XmlElement("biz_crowd_type_identity")]
        public string BizCrowdTypeIdentity { get; set; }

        /// <summary>
        /// 同步日期，格式为YYYYMMDD
        /// </summary>
        [XmlElement("biz_date")]
        public string BizDate { get; set; }

        /// <summary>
        /// 枚举类型， 顺风车:hitchhike 网约车:onlineride 无人车:tobotaxi 共享单车:bikesharing 私人电动车:ebike 两轮充电:ebikecharging 两轮租车:ebikerental
        /// </summary>
        [XmlElement("biz_scene")]
        public string BizScene { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("data_list")]
        [XmlArrayItem("trafficshare_crowd_user_sync")]
        public List<TrafficshareCrowdUserSync> DataList { get; set; }
    }
}
