using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// NDeviceWorkPosition Data Structure.
    /// </summary>
    [Serializable]
    public class NDeviceWorkPosition : AopObject
    {
        /// <summary>
        /// 当前作业人员所在位置纬度
        /// </summary>
        [XmlElement("latitude")]
        public string Latitude { get; set; }

        /// <summary>
        /// 支付宝侧门店leadsId
        /// </summary>
        [XmlElement("leads_id")]
        public string LeadsId { get; set; }

        /// <summary>
        /// 当前作业人员所在位置纬度
        /// </summary>
        [XmlElement("longitude")]
        public string Longitude { get; set; }

        /// <summary>
        /// 外部门店编号，门店leads上报时的外部门店编号
        /// </summary>
        [XmlElement("out_store_id")]
        public string OutStoreId { get; set; }
    }
}
