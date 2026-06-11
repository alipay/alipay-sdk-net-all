using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// XingheLendassistCarfinOrgexpressCancelResponse.
    /// </summary>
    public class XingheLendassistCarfinOrgexpressCancelResponse : AopResponse
    {
        /// <summary>
        /// 取消失败原因
        /// </summary>
        [XmlElement("refuse_msg")]
        public string RefuseMsg { get; set; }

        /// <summary>
        /// 取消成功：1 取消失败：2
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
