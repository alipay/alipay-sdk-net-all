using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayPayAppPocketmoneyPromoBatchqueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayPayAppPocketmoneyPromoBatchqueryModel : AopObject
    {
        /// <summary>
        /// 为空-批量查询，不为空-根据流水id查询
        /// </summary>
        [XmlArray("biz_no_list")]
        [XmlArrayItem("string")]
        public List<string> BizNoList { get; set; }

        /// <summary>
        /// 活动场景数组
        /// </summary>
        [XmlArray("biz_scene_list")]
        [XmlArrayItem("string")]
        public List<string> BizSceneList { get; set; }

        /// <summary>
        /// 设备号，openWatchId，rtos设备可不传
        /// </summary>
        [XmlElement("device_id")]
        public string DeviceId { get; set; }

        /// <summary>
        /// 兼容设备号，openId
        /// </summary>
        [XmlElement("extra_device_id")]
        public string ExtraDeviceId { get; set; }

        /// <summary>
        /// 操作系统，android，rtos
        /// </summary>
        [XmlElement("os_type")]
        public string OsType { get; set; }

        /// <summary>
        /// 厂商名称
        /// </summary>
        [XmlElement("solution_vendor")]
        public string SolutionVendor { get; set; }
    }
}
