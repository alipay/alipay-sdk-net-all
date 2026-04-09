using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOfflineProviderDeviceTradeQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOfflineProviderDeviceTradeQueryModel : AopObject
    {
        /// <summary>
        /// 设备sn
        /// </summary>
        [XmlElement("device_sn")]
        public string DeviceSn { get; set; }

        /// <summary>
        /// 查询开始时间与查询结束时间间隔不得超过6个月
        /// </summary>
        [XmlElement("end_date")]
        public string EndDate { get; set; }

        /// <summary>
        /// 间联商户id
        /// </summary>
        [XmlElement("smid")]
        public string Smid { get; set; }

        /// <summary>
        /// 查询开始时间与查询结束时间间隔不得超过6个月
        /// </summary>
        [XmlElement("start_date")]
        public string StartDate { get; set; }
    }
}
