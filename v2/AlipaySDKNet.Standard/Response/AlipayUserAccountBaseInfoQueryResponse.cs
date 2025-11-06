using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayUserAccountBaseInfoQueryResponse.
    /// </summary>
    public class AlipayUserAccountBaseInfoQueryResponse : AopResponse
    {
        /// <summary>
        /// 明文手机号，内部接口，对接入方实施管控
        /// </summary>
        [XmlElement("bind_mobile")]
        public string BindMobile { get; set; }

        /// <summary>
        /// long时间戳，精确到毫秒
        /// </summary>
        [XmlElement("bind_mobile_time")]
        public string BindMobileTime { get; set; }

        /// <summary>
        /// 二次放号打分阈值，业务方自己判断是否为二次放号
        /// </summary>
        [XmlElement("phone_release_sign")]
        public string PhoneReleaseSign { get; set; }
    }
}
