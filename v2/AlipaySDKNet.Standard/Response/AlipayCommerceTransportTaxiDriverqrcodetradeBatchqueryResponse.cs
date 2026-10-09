using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceTransportTaxiDriverqrcodetradeBatchqueryResponse.
    /// </summary>
    public class AlipayCommerceTransportTaxiDriverqrcodetradeBatchqueryResponse : AopResponse
    {
        /// <summary>
        /// 出租车司机收钱码交易数据列表
        /// </summary>
        [XmlArray("driver_qrcode_trade_info_list")]
        [XmlArrayItem("driver_trade_info")]
        public List<DriverTradeInfo> DriverQrcodeTradeInfoList { get; set; }
    }
}
