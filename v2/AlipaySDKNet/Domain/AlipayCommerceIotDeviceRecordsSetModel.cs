using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceIotDeviceRecordsSetModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceIotDeviceRecordsSetModel : AopObject
    {
        /// <summary>
        /// 极简绑定、三绑定、升级三绑定、可用绑定、解绑时必填，绑定查询时选填
        /// </summary>
        [XmlArray("device_record_files")]
        [XmlArrayItem("device_record_file")]
        public List<DeviceRecordFile> DeviceRecordFiles { get; set; }

        /// <summary>
        /// 填写商户在isv系统内身份资料
        /// </summary>
        [XmlElement("ext_params")]
        public DeviceExtParams ExtParams { get; set; }

        /// <summary>
        /// 设备档案管理场景 IOT_DEVICE_RECORDS_G1(极简绑定) IOT_DEVICE_RECORDS_G3_INDIRECT(间连三绑定) IOT_DEVICE_RECORDS_G3_DIRECT(直连三绑定) IOT_DEVICE_RECORDS_DELETE(解绑) IOT_DEVICE_RECORDS_QUERY（绑定查询） IOT_DEVICE_RECORDS_G2(可用绑定)
        /// </summary>
        [XmlElement("scene_code")]
        public string SceneCode { get; set; }

        /// <summary>
        /// CREATE（极简绑定、间连三绑定、可用绑定、直连三绑定时传） UPDATE（极简绑定升级为间连三绑定时传） DEFAULT（解绑、绑定查询时传） G2TOG3_UPDATE（可用绑定升级为间联三绑定时传）
        /// </summary>
        [XmlElement("scene_params")]
        public string SceneParams { get; set; }

        /// <summary>
        /// 设备序列号
        /// </summary>
        [XmlElement("sn")]
        public string Sn { get; set; }

        /// <summary>
        /// 设备供应商ID：supplierId，如意生态版AMX设备请填写“201901111100635561”
        /// </summary>
        [XmlElement("supplier_id")]
        public string SupplierId { get; set; }
    }
}
