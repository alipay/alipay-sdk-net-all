using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RentPathInfoDTO Data Structure.
    /// </summary>
    [Serializable]
    public class RentPathInfoDTO : AopObject
    {
        /// <summary>
        /// 商家有独立页面用于支持用户发起租赁商品购买时，可传入此字段。用户在芝麻租赁频道发起购买时，将引导用户跳转至该页面完成操作。
        /// </summary>
        [XmlElement("buyout_path")]
        public string BuyoutPath { get; set; }

        /// <summary>
        /// 商家小程序对应的订单详情页路径地址 value。仅需传入小程序页面路径即可。同一笔订单的链接必须与第一次传入的地址相同，且需是小程序内部页面路径
        /// </summary>
        [XmlElement("detail_path")]
        public string DetailPath { get; set; }

        /// <summary>
        /// 租赁服务协议
        /// </summary>
        [XmlArray("protocols")]
        [XmlArrayItem("rent_service_protocol_d_t_o")]
        public List<RentServiceProtocolDTO> Protocols { get; set; }

        /// <summary>
        /// 商家有独立页面用于支持用户发起租赁商品续租时，可传入此字段。用户在芝麻租赁频道发起购买时，将引导用户跳转至该页面完成操作。
        /// </summary>
        [XmlElement("relet_path")]
        public string ReletPath { get; set; }

        /// <summary>
        /// 商家有独立页面用于支持用户发起租赁商品归还时，可传入此字段。用户在芝麻租赁频道发起购买时，将引导用户跳转至该页面完成操作。
        /// </summary>
        [XmlElement("return_path")]
        public string ReturnPath { get; set; }
    }
}
