using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ShopMaterialsValidInfo Data Structure.
    /// </summary>
    [Serializable]
    public class ShopMaterialsValidInfo : AopObject
    {
        /// <summary>
        /// 物料的nfc芯片id
        /// </summary>
        [XmlElement("chip_id")]
        public string ChipId { get; set; }

        /// <summary>
        /// 物料对应桌号
        /// </summary>
        [XmlElement("desk_no")]
        public string DeskNo { get; set; }

        /// <summary>
        /// 标识物料的唯一性
        /// </summary>
        [XmlElement("materials_instance_id")]
        public string MaterialsInstanceId { get; set; }

        /// <summary>
        /// 物料的nfc链接，有可能为空，为空则先不写入碰一碰的url
        /// </summary>
        [XmlElement("nfc_url")]
        public string NfcUrl { get; set; }

        /// <summary>
        /// 物料二维码url
        /// </summary>
        [XmlElement("qr_code_url")]
        public string QrCodeUrl { get; set; }

        /// <summary>
        /// 门店单号
        /// </summary>
        [XmlElement("shop_order_no")]
        public string ShopOrderNo { get; set; }
    }
}
