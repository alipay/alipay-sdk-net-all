using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// FinExtParams Data Structure.
    /// </summary>
    [Serializable]
    public class FinExtParams : AopObject
    {
        /// <summary>
        /// 机构的appid
        /// </summary>
        [XmlElement("inst_appid")]
        public string InstAppid { get; set; }

        /// <summary>
        /// isv编码
        /// </summary>
        [XmlElement("isv_code")]
        public string IsvCode { get; set; }

        /// <summary>
        /// 返回的url
        /// </summary>
        [XmlElement("page_return_url")]
        public string PageReturnUrl { get; set; }

        /// <summary>
        /// 订单来源
        /// </summary>
        [XmlElement("source")]
        public string Source { get; set; }

        /// <summary>
        /// 超时时间
        /// </summary>
        [XmlElement("time_expire")]
        public string TimeExpire { get; set; }
    }
}
