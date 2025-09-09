using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ShopMaterialsInfo Data Structure.
    /// </summary>
    [Serializable]
    public class ShopMaterialsInfo : AopObject
    {
        /// <summary>
        /// 收货地址
        /// </summary>
        [XmlElement("delivery_address")]
        public string DeliveryAddress { get; set; }

        /// <summary>
        /// 物料对应桌号
        /// </summary>
        [XmlElement("desk_no")]
        public string DeskNo { get; set; }

        /// <summary>
        /// 一个实例对应的实际生产数量
        /// </summary>
        [XmlElement("materials_count")]
        public long MaterialsCount { get; set; }

        /// <summary>
        /// 标识物料的唯一性
        /// </summary>
        [XmlElement("materials_instance_id")]
        public string MaterialsInstanceId { get; set; }

        /// <summary>
        /// 描述门店对应的商家名称，有部分物料印刷时需要，有必要时才会传递
        /// </summary>
        [XmlElement("merchant_name")]
        public string MerchantName { get; set; }

        /// <summary>
        /// 物料的nfc链接，有可能为空，为空则先不写入碰一碰的url
        /// </summary>
        [XmlElement("nfc_url")]
        public string NfcUrl { get; set; }

        /// <summary>
        /// 生产要素扩展参数
        /// </summary>
        [XmlElement("production_ext_info")]
        public string ProductionExtInfo { get; set; }

        /// <summary>
        /// 二维码url
        /// </summary>
        [XmlElement("qr_code_url")]
        public string QrCodeUrl { get; set; }

        /// <summary>
        /// 收件人姓名
        /// </summary>
        [XmlElement("receiver_name")]
        public string ReceiverName { get; set; }

        /// <summary>
        /// 收货人联系电话
        /// </summary>
        [XmlElement("receiver_phone")]
        public string ReceiverPhone { get; set; }

        /// <summary>
        /// xxx门店
        /// </summary>
        [XmlElement("shop_name")]
        public string ShopName { get; set; }

        /// <summary>
        /// 门店单号
        /// </summary>
        [XmlElement("shop_order_no")]
        public string ShopOrderNo { get; set; }

        /// <summary>
        /// 对应门店数量的序列号 当前字段已废弃(无具体业务含义，修改为废弃)
        /// </summary>
        [XmlElement("shop_serial_number")]
        public string ShopSerialNumber { get; set; }
    }
}
