using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceTransportTaxiOrderinfoSyncResponse.
    /// </summary>
    public class AlipayCommerceTransportTaxiOrderinfoSyncResponse : AopResponse
    {
        /// <summary>
        /// 支付宝唯一司机id
        /// </summary>
        [XmlElement("driver_user_id")]
        public string DriverUserId { get; set; }

        /// <summary>
        /// 返回结果编码
        /// </summary>
        [XmlElement("error_code")]
        public string ErrorCode { get; set; }

        /// <summary>
        /// 返回结果描述
        /// </summary>
        [XmlElement("error_msg")]
        public string ErrorMsg { get; set; }

        /// <summary>
        /// 费用信息同步处理结果
        /// </summary>
        [XmlElement("result")]
        public string Result { get; set; }
    }
}
