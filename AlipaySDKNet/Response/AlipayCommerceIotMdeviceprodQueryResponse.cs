using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceIotMdeviceprodQueryResponse.
    /// </summary>
    public class AlipayCommerceIotMdeviceprodQueryResponse : AopResponse
    {
        /// <summary>
        /// 设备激活时间
        /// </summary>
        [XmlElement("activate_time")]
        public string ActivateTime { get; set; }

        /// <summary>
        /// 地址信息
        /// </summary>
        [XmlElement("addr_info")]
        public string AddrInfo { get; set; }

        /// <summary>
        /// 业务类型
        /// </summary>
        [XmlElement("biz_type")]
        public string BizType { get; set; }

        /// <summary>
        /// 机具唯一id
        /// </summary>
        [XmlElement("device_id")]
        public string DeviceId { get; set; }

        /// <summary>
        /// 机具名称
        /// </summary>
        [XmlElement("device_name")]
        public string DeviceName { get; set; }

        /// <summary>
        /// 机具序列号
        /// </summary>
        [XmlElement("device_sn")]
        public string DeviceSn { get; set; }

        /// <summary>
        /// 机具图片信息
        /// </summary>
        [XmlElement("img_url")]
        public string ImgUrl { get; set; }

        /// <summary>
        /// isv信息
        /// </summary>
        [XmlElement("isv")]
        public MerchantModel Isv { get; set; }

        /// <summary>
        /// 商户联系信息
        /// </summary>
        [XmlElement("merchant")]
        public MerchantModel Merchant { get; set; }

        /// <summary>
        /// 店铺地址
        /// </summary>
        [XmlElement("shop_address")]
        public string ShopAddress { get; set; }

        /// <summary>
        /// 店铺id
        /// </summary>
        [XmlElement("shop_id")]
        public string ShopId { get; set; }

        /// <summary>
        /// xxx店铺
        /// </summary>
        [XmlElement("shop_name")]
        public string ShopName { get; set; }

        /// <summary>
        /// 机具状态code
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 设备状态描述
        /// </summary>
        [XmlElement("status_desc")]
        public string StatusDesc { get; set; }

        /// <summary>
        /// 机具生产厂商
        /// </summary>
        [XmlElement("supplier_name")]
        public string SupplierName { get; set; }
    }
}
