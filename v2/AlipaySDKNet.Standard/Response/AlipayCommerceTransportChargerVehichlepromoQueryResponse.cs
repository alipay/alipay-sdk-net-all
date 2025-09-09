using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceTransportChargerVehichlepromoQueryResponse.
    /// </summary>
    public class AlipayCommerceTransportChargerVehichlepromoQueryResponse : AopResponse
    {
        /// <summary>
        /// 订单核销车企优惠金额，精度两位小数，单位元
        /// </summary>
        [XmlElement("discount_amount")]
        public string DiscountAmount { get; set; }

        /// <summary>
        /// 获取签名后的业务数据
        /// </summary>
        [XmlElement("orderStr")]
        public string OrderStr { get; set; }

        /// <summary>
        /// 车架号
        /// </summary>
        [XmlElement("vin")]
        public string Vin { get; set; }
    }
}
