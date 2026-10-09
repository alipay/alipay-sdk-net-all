using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayEcoMycarVehicleVehicleiovSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEcoMycarVehicleVehicleiovSyncModel : AopObject
    {
        /// <summary>
        /// 扩展字段
        /// </summary>
        [XmlElement("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 车联数据列表
        /// </summary>
        [XmlArray("iov_datas")]
        [XmlArrayItem("vehicle_iov_data")]
        public List<VehicleIovData> IovDatas { get; set; }

        /// <summary>
        /// 车联数据业务流水号
        /// </summary>
        [XmlElement("iov_seq_no")]
        public string IovSeqNo { get; set; }

        /// <summary>
        /// 支付宝用户openid
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 当前系统时间戳
        /// </summary>
        [XmlElement("system_timestamp")]
        public string SystemTimestamp { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }

        /// <summary>
        /// 车企openid
        /// </summary>
        [XmlElement("vehicle_open_id")]
        public string VehicleOpenId { get; set; }

        /// <summary>
        /// 车辆id
        /// </summary>
        [XmlElement("vi_id")]
        public string ViId { get; set; }
    }
}
