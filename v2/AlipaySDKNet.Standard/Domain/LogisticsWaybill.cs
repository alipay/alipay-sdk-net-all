using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// LogisticsWaybill Data Structure.
    /// </summary>
    [Serializable]
    public class LogisticsWaybill : AopObject
    {
        /// <summary>
        /// 物流公司编号
        /// </summary>
        [XmlElement("logistics_code")]
        public string LogisticsCode { get; set; }

        /// <summary>
        /// 状态
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 物流详情
        /// </summary>
        [XmlArray("steps")]
        [XmlArrayItem("waybill_step")]
        public List<WaybillStep> Steps { get; set; }

        /// <summary>
        /// 运单号
        /// </summary>
        [XmlElement("waybill_no")]
        public string WaybillNo { get; set; }
    }
}
