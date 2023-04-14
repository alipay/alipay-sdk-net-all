using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// DeviceRecords Data Structure.
    /// </summary>
    [Serializable]
    public class DeviceRecords : AopObject
    {
        /// <summary>
        /// 设备唯一标识
        /// </summary>
        [XmlElement("biz_tid")]
        public string BizTid { get; set; }

        /// <summary>
        /// 极简绑定：G1 三绑定：G3
        /// </summary>
        [XmlElement("device_grade")]
        public string DeviceGrade { get; set; }

        /// <summary>
        /// 设备档案
        /// </summary>
        [XmlArray("device_record_files")]
        [XmlArrayItem("device_record_file")]
        public List<DeviceRecordFile> DeviceRecordFiles { get; set; }

        /// <summary>
        /// 设备档案拓展参数
        /// </summary>
        [XmlElement("ext_params")]
        public DeviceExtParams ExtParams { get; set; }

        /// <summary>
        /// 设备序列号
        /// </summary>
        [XmlElement("sn")]
        public string Sn { get; set; }

        /// <summary>
        /// 设备供应商ID
        /// </summary>
        [XmlElement("supplier_id")]
        public string SupplierId { get; set; }
    }
}
