using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOfflineProviderBroadcastCoilBindModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOfflineProviderBroadcastCoilBindModel : AopObject
    {
        /// <summary>
        /// 线圈NFCURL。服务商从线圈读取后原样传入。nfc_url和tag_sn必须传入至少一个值。
        /// </summary>
        [XmlElement("nfc_url")]
        public string NfcUrl { get; set; }

        /// <summary>
        /// 服务商自定义作业员标识，用于审计和问题追踪
        /// </summary>
        [XmlElement("operator_id")]
        public string OperatorId { get; set; }

        /// <summary>
        /// 绑定后触达页面地址；再次调用本接口可更新该地址。
        /// </summary>
        [XmlElement("route_url")]
        public string RouteUrl { get; set; }

        /// <summary>
        /// 间联商户ID。用于校验Lite设备已完成商户进件，并作为归属校验条件
        /// </summary>
        [XmlElement("smid")]
        public string Smid { get; set; }

        /// <summary>
        /// 线圈tagSN。服务商可从线圈物料上获取并原样传入。nfc_url和tag_sn必须传入至少一个值。
        /// </summary>
        [XmlElement("tag_sn")]
        public string TagSn { get; set; }
    }
}
