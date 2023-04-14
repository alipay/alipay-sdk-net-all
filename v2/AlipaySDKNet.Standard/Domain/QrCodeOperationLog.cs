using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// QrCodeOperationLog Data Structure.
    /// </summary>
    [Serializable]
    public class QrCodeOperationLog : AopObject
    {
        /// <summary>
        /// 能量码所属的goods_id
        /// </summary>
        [XmlElement("goods_id")]
        public string GoodsId { get; set; }

        /// <summary>
        /// 能量所属的商品名称
        /// </summary>
        [XmlElement("goods_name")]
        public string GoodsName { get; set; }

        /// <summary>
        /// 能量码ID
        /// </summary>
        [XmlElement("qr_code_id")]
        public string QrCodeId { get; set; }
    }
}
