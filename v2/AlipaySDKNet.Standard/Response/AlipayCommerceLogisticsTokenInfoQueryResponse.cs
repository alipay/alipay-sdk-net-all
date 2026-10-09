using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceLogisticsTokenInfoQueryResponse.
    /// </summary>
    public class AlipayCommerceLogisticsTokenInfoQueryResponse : AopResponse
    {
        /// <summary>
        /// 收件信息
        /// </summary>
        [XmlElement("receive_info")]
        public UserAddressInfoObj ReceiveInfo { get; set; }

        /// <summary>
        /// 选择站点信息
        /// </summary>
        [XmlElement("selected_station_info")]
        public SelectedStationInfoDTO SelectedStationInfo { get; set; }

        /// <summary>
        /// 寄件信息
        /// </summary>
        [XmlElement("send_info")]
        public UserAddressInfoObj SendInfo { get; set; }

        /// <summary>
        /// 服务信息
        /// </summary>
        [XmlElement("service_info")]
        public ServiceInfoObj ServiceInfo { get; set; }
    }
}
