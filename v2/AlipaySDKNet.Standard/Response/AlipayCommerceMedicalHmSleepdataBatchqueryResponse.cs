using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceMedicalHmSleepdataBatchqueryResponse.
    /// </summary>
    public class AlipayCommerceMedicalHmSleepdataBatchqueryResponse : AopResponse
    {
        /// <summary>
        /// 是否已经绑定硬件设备 Y/N
        /// </summary>
        [XmlElement("is_hardware_device_bound")]
        public string IsHardwareDeviceBound { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("sleepdata_list")]
        [XmlArrayItem("medical_hm_daily_sleep_record")]
        public List<MedicalHmDailySleepRecord> SleepdataList { get; set; }
    }
}
