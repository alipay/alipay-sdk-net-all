using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// ZhimaCustomerJobworthInfoQueryResponse.
    /// </summary>
    public class ZhimaCustomerJobworthInfoQueryResponse : AopResponse
    {
        /// <summary>
        /// 受理台单号作为jsapi的一个参数。如果不使用jsapi可以忽略
        /// </summary>
        [XmlElement("acceptance_id")]
        public string AcceptanceId { get; set; }

        /// <summary>
        /// 用于授权校验,授权之前需要通过token校验
        /// </summary>
        [XmlElement("auth_token")]
        public string AuthToken { get; set; }

        /// <summary>
        /// h5url
        /// </summary>
        [XmlElement("html_url")]
        public string HtmlUrl { get; set; }

        /// <summary>
        /// 职得工作证图片url,可以直接用于展示
        /// </summary>
        [XmlElement("picture_url")]
        public string PictureUrl { get; set; }

        /// <summary>
        /// 业务编码
        /// </summary>
        [XmlElement("sub_code")]
        public string SubCode { get; set; }

        /// <summary>
        /// 业务中文结果信息
        /// </summary>
        [XmlElement("sub_msg")]
        public string SubMsg { get; set; }

        /// <summary>
        /// 工作证图片更新的url,需要跳转到工作证小程序中进行更新
        /// </summary>
        [XmlElement("update_url")]
        public string UpdateUrl { get; set; }

        /// <summary>
        /// 职得工作证跳转小程序链接
        /// </summary>
        [XmlElement("url")]
        public string Url { get; set; }
    }
}
