using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayEcoMycarParkingConfigQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEcoMycarParkingConfigQueryModel : AopObject
    {
        /// <summary>
        /// 接口名称。H5传入参数固定值：alipay.eco.mycar.parking.userpage.query； 小程序传入参数固定值：alipay.eco.mycar.parking.isv.homepage； 协议状态变更通知传入参数固定值： alipay.eco.mycar.parking.agreement.notify。
        /// </summary>
        [XmlElement("interface_name")]
        public string InterfaceName { get; set; }

        /// <summary>
        /// 接口类型。H5、小程序传入参数固定值：interface_page； 通知接口传入参数固定值：interface_service。
        /// </summary>
        [XmlElement("interface_type")]
        public string InterfaceType { get; set; }
    }
}
