using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ServiceItemOrderInfo Data Structure.
    /// </summary>
    [Serializable]
    public class ServiceItemOrderInfo : AopObject
    {
        /// <summary>
        /// 服务包结束时间（格式：yyyy-MM-dd HH:mm:ss）
        /// </summary>
        [XmlElement("bill_end_time")]
        public string BillEndTime { get; set; }

        /// <summary>
        /// 服务包开始时间（格式：yyyy-MM-dd HH:mm:ss）
        /// </summary>
        [XmlElement("bill_start_time")]
        public string BillStartTime { get; set; }

        /// <summary>
        /// 患者名称
        /// </summary>
        [XmlElement("patient_name")]
        public string PatientName { get; set; }
    }
}
