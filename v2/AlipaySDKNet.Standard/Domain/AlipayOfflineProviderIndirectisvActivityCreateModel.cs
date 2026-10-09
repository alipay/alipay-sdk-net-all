using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOfflineProviderIndirectisvActivityCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOfflineProviderIndirectisvActivityCreateModel : AopObject
    {
        /// <summary>
        /// 商户的其他备注信息
        /// </summary>
        [XmlElement("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 设备信息
        /// </summary>
        [XmlArray("indirect_isv_terminal_info")]
        [XmlArrayItem("indirect_isv_terminal_info")]
        public List<IndirectIsvTerminalInfo> IndirectIsvTerminalInfo { get; set; }

        /// <summary>
        /// 商户收单账号
        /// </summary>
        [XmlElement("merchant_id")]
        public string MerchantId { get; set; }
    }
}
