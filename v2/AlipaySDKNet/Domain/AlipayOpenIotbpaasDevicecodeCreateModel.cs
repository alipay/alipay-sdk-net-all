using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenIotbpaasDevicecodeCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenIotbpaasDevicecodeCreateModel : AopObject
    {
        /// <summary>
        /// 设备biztid
        /// </summary>
        [XmlElement("biztid")]
        public string Biztid { get; set; }

        /// <summary>
        /// 码类型为动态码/静态码，取值STATIC或DYNAMIC
        /// </summary>
        [XmlElement("code_type")]
        public string CodeType { get; set; }

        /// <summary>
        /// 设备物料ID
        /// </summary>
        [XmlElement("item_id")]
        public string ItemId { get; set; }

        /// <summary>
        /// 设备SN
        /// </summary>
        [XmlElement("sn")]
        public string Sn { get; set; }

        /// <summary>
        /// IoT设备供应商ID
        /// </summary>
        [XmlElement("supplier_id")]
        public string SupplierId { get; set; }
    }
}
