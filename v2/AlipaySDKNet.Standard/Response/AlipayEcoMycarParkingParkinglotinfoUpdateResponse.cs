using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayEcoMycarParkingParkinglotinfoUpdateResponse.
    /// </summary>
    public class AlipayEcoMycarParkingParkinglotinfoUpdateResponse : AopResponse
    {
        /// <summary>
        /// 具体错误码 参数异常：INVALID_PARAMETER 没有权限操作：NO_PERMISSION_ERROR 请求受理结果未知：BIZ_UNKNOWN 请求受理失败：BIZ_FAIL 系统繁忙：SYSTEM_ERROR
        /// </summary>
        [XmlElement("biz_code")]
        public string BizCode { get; set; }

        /// <summary>
        /// 具体错误原因
        /// </summary>
        [XmlElement("biz_msg")]
        public string BizMsg { get; set; }
    }
}
