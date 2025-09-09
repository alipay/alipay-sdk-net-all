using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RentPathInfoVO Data Structure.
    /// </summary>
    [Serializable]
    public class RentPathInfoVO : AopObject
    {
        /// <summary>
        /// 商家租赁订单购买页地址
        /// </summary>
        [XmlElement("buyout_path")]
        public string BuyoutPath { get; set; }

        /// <summary>
        /// 商家小程序对应的订单详情页路径地址
        /// </summary>
        [XmlElement("detail_path")]
        public string DetailPath { get; set; }

        /// <summary>
        /// 租赁服务协议
        /// </summary>
        [XmlArray("protocols")]
        [XmlArrayItem("rent_service_protocol_v_o")]
        public List<RentServiceProtocolVO> Protocols { get; set; }

        /// <summary>
        /// 商家租赁订单续租页地址
        /// </summary>
        [XmlElement("relet_path")]
        public string ReletPath { get; set; }

        /// <summary>
        /// 商家租赁订单归还页地址
        /// </summary>
        [XmlElement("return_path")]
        public string ReturnPath { get; set; }
    }
}
