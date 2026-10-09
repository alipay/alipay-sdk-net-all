using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayUserKabaoVoucherCreateResponse.
    /// </summary>
    public class AlipayUserKabaoVoucherCreateResponse : AopResponse
    {
        /// <summary>
        /// 错误信息
        /// </summary>
        [XmlElement("error_msg")]
        public string ErrorMsg { get; set; }

        /// <summary>
        /// 支付宝卡包优惠券的实例唯一id
        /// </summary>
        [XmlElement("instance_id")]
        public string InstanceId { get; set; }

        /// <summary>
        /// 外部优惠券实例唯一id
        /// </summary>
        [XmlElement("out_instance_id")]
        public string OutInstanceId { get; set; }
    }
}
