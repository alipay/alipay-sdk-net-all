using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOfflineNbinteractSceneUnbindModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOfflineNbinteractSceneUnbindModel : AopObject
    {
        /// <summary>
        /// 碰一下互动跳转链接所属类型
        /// </summary>
        [XmlElement("link_url_type")]
        public string LinkUrlType { get; set; }

        /// <summary>
        /// 设备sn
        /// </summary>
        [XmlElement("sn")]
        public string Sn { get; set; }

        /// <summary>
        /// 设备供应商 ID：supplierId，如意生态版AMX设备请填写“201901111100635561”
        /// </summary>
        [XmlElement("supplier_id")]
        public string SupplierId { get; set; }
    }
}
