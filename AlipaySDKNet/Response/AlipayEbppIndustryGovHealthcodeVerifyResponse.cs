using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayEbppIndustryGovHealthcodeVerifyResponse.
    /// </summary>
    public class AlipayEbppIndustryGovHealthcodeVerifyResponse : AopResponse
    {
        /// <summary>
        /// 码的颜色，红/黄/绿/审核中，分别对应如下: red/yellow/green/init
        /// </summary>
        [XmlElement("code_color")]
        public string CodeColor { get; set; }

        /// <summary>
        /// 生成的健康码码值
        /// </summary>
        [XmlElement("qr_code")]
        public string QrCode { get; set; }

        /// <summary>
        /// 码值刷新的时间，可能为空
        /// </summary>
        [XmlElement("refresh_time")]
        public string RefreshTime { get; set; }

        /// <summary>
        /// 姓名
        /// </summary>
        [XmlElement("user_name")]
        public string UserName { get; set; }
    }
}
