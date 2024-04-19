using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceIotDapplyDevicetradestatlistQueryResponse.
    /// </summary>
    public class AlipayCommerceIotDapplyDevicetradestatlistQueryResponse : AopResponse
    {
        /// <summary>
        /// 设备交易统计信息
        /// </summary>
        [XmlElement("devicetradestatlist")]
        public DeviceTradeInfoList Devicetradestatlist { get; set; }

        /// <summary>
        /// 表示返回的列表总数
        /// </summary>
        [XmlElement("total_count")]
        public long TotalCount { get; set; }
    }
}
