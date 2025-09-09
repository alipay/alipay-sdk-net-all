using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOfflineNbinteractSceneBindModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOfflineNbinteractSceneBindModel : AopObject
    {
        /// <summary>
        /// 跳转支付宝小程序的链接
        /// </summary>
        [XmlElement("link_url")]
        public string LinkUrl { get; set; }

        /// <summary>
        /// 碰一下互动跳转链接所属类型,从枚举中选择
        /// </summary>
        [XmlElement("link_url_type")]
        public string LinkUrlType { get; set; }

        /// <summary>
        /// 设备唯一标识
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
