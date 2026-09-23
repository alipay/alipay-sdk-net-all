using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOfflineProviderBroadcastReportDownloadModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOfflineProviderBroadcastReportDownloadModel : AopObject
    {
        /// <summary>
        /// 音响设备SN，输入后将仅导出对应音响设备的数据，同时输入smid和device_sn会取AND逻辑
        /// </summary>
        [XmlElement("device_sn")]
        public string DeviceSn { get; set; }

        /// <summary>
        /// 报表生成日期，对应离线报表 dt 分区；当前仅支持T-1日（如今天是2026年9月15日，仅支持输入2026-09-14）
        /// </summary>
        [XmlElement("report_dt")]
        public string ReportDt { get; set; }

        /// <summary>
        /// 商户 SMID，映射报表字段 last_bind_merchant_id，输入后将只导出本商户名下所有音响设备的数据，同时输入smid和device_sn会取AND逻辑
        /// </summary>
        [XmlElement("smid")]
        public string Smid { get; set; }
    }
}
