using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// EtcDeviceTripInfo Data Structure.
    /// </summary>
    [Serializable]
    public class EtcDeviceTripInfo : AopObject
    {
        /// <summary>
        /// 行程记录唯一流水号
        /// </summary>
        [XmlElement("biz_no")]
        public string BizNo { get; set; }

        /// <summary>
        /// 行程出站站点id十六进制编码
        /// </summary>
        [XmlElement("end_station_id_hex")]
        public string EndStationIdHex { get; set; }

        /// <summary>
        /// 行程结束时间
        /// </summary>
        [XmlElement("end_time")]
        public string EndTime { get; set; }

        /// <summary>
        /// 行程进站站点id十六进制编码
        /// </summary>
        [XmlElement("start_station_id_hex")]
        public string StartStationIdHex { get; set; }

        /// <summary>
        /// 行程开始时间
        /// </summary>
        [XmlElement("start_time")]
        public string StartTime { get; set; }

        /// <summary>
        /// 行程总金额，单位元
        /// </summary>
        [XmlElement("total_amount")]
        public string TotalAmount { get; set; }
    }
}
