using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceIotWifiStatusQueryResponse.
    /// </summary>
    public class AlipayCommerceIotWifiStatusQueryResponse : AopResponse
    {
        /// <summary>
        /// 当前wifi名称
        /// </summary>
        [XmlElement("cur_ssid")]
        public string CurSsid { get; set; }

        /// <summary>
        /// 设备扫码出来的ssid名称列表
        /// </summary>
        [XmlArray("ssid_list")]
        [XmlArrayItem("string")]
        public List<string> SsidList { get; set; }

        /// <summary>
        /// 当前设备的wifi状态  1.表示2G联网  2.表示wifi联网
        /// </summary>
        [XmlElement("wifi_type")]
        public long WifiType { get; set; }
    }
}
