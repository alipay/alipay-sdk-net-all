using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// InterfaceInfoList Data Structure.
    /// </summary>
    [Serializable]
    public class InterfaceInfoList : AopObject
    {
        /// <summary>
        /// H5传入参数固定值：alipay.eco.mycar.parking.userpage.query;  小程序传入参数固定值：alipay.eco.mycar.parking.isv.homepage;  协议状态变更通知传入参数固定值： alipay.eco.mycar.parking.agreement.notify;
        /// </summary>
        [XmlElement("interface_name")]
        public string InterfaceName { get; set; }

        /// <summary>
        /// H5、小程序传入参数固定值:interface_page； 通知接口传入参数固定值:interface_service;
        /// </summary>
        [XmlElement("interface_type")]
        public string InterfaceType { get; set; }

        /// <summary>
        /// H5 SPI接口的调用地址url，协议必须为https，对整个url字符串必须进行UrlEncode编码。编码为UTF-8;  小程序SPI接口的调用地址ur格式：小程序|小程序缴费页面地址;  协议状态变更通知SPI接口的调用地址url，同H5格式;
        /// </summary>
        [XmlElement("interface_url")]
        public string InterfaceUrl { get; set; }
    }
}
