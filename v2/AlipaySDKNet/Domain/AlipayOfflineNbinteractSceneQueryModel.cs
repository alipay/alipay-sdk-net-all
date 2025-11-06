using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOfflineNbinteractSceneQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOfflineNbinteractSceneQueryModel : AopObject
    {
        /// <summary>
        /// 碰一下互动跳转链接所属类型,从枚举中选择,不填写默认返回最新的
        /// </summary>
        [XmlElement("link_url_type")]
        public string LinkUrlType { get; set; }

        /// <summary>
        /// 设备sn
        /// </summary>
        [XmlElement("sn")]
        public string Sn { get; set; }

        /// <summary>
        /// 设备供应商 ID
        /// </summary>
        [XmlElement("supplier_id")]
        public string SupplierId { get; set; }
    }
}
