using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayUserKabaoVoucherModifyResponse.
    /// </summary>
    public class AlipayUserKabaoVoucherModifyResponse : AopResponse
    {
        /// <summary>
        /// 补充业务错误信息
        /// </summary>
        [XmlElement("error_msg")]
        public string ErrorMsg { get; set; }

        /// <summary>
        /// 卡包优惠券实例id
        /// </summary>
        [XmlElement("instance_id")]
        public string InstanceId { get; set; }

        /// <summary>
        /// 外部优惠券实例唯一号
        /// </summary>
        [XmlElement("out_instance_id")]
        public string OutInstanceId { get; set; }
    }
}
