using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceLogisticsPointTagOfflineModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceLogisticsPointTagOfflineModel : AopObject
    {
        /// <summary>
        /// 物流行业线圈ID
        /// </summary>
        [XmlElement("logistics_nfc_id")]
        public string LogisticsNfcId { get; set; }

        /// <summary>
        /// n6设备的下线时间
        /// </summary>
        [XmlElement("offline_time")]
        public string OfflineTime { get; set; }

        /// <summary>
        /// 下线类型
        /// </summary>
        [XmlElement("offline_type")]
        public string OfflineType { get; set; }

        /// <summary>
        /// n6设备ID
        /// </summary>
        [XmlElement("sn_id")]
        public string SnId { get; set; }

        /// <summary>
        /// 作业租户码
        /// </summary>
        [XmlElement("tenant_code")]
        public string TenantCode { get; set; }
    }
}
