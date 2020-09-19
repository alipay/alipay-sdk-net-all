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
        /// 返回的url
        /// </summary>
        [XmlElement("page_return_url")]
        public string PageReturnUrl { get; set; }

        /// <summary>
        /// 超时时间
        /// </summary>
        [XmlElement("time_expire")]
        public string TimeExpire { get; set; }
    }
}
