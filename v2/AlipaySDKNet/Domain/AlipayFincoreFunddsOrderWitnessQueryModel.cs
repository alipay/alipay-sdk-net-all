using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayFincoreFunddsOrderWitnessQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayFincoreFunddsOrderWitnessQueryModel : AopObject
    {
        /// <summary>
        /// 云资通订单号（fds_no 和 out_request_no 两个参数不能同时为空）
        /// </summary>
        [XmlElement("fds_no")]
        public string FdsNo { get; set; }

        /// <summary>
        /// 外部订单号 （fds_no 和 out_request_no 两个参数不能同时为空）
        /// </summary>
        [XmlElement("out_request_no")]
        public string OutRequestNo { get; set; }

        /// <summary>
        /// 签约产品码
        /// </summary>
        [XmlElement("product_code")]
        public string ProductCode { get; set; }
    }
}
