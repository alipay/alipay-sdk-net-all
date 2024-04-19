using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// ZhimaCreditEpCreditlinkAuthCreateResponse.
    /// </summary>
    public class ZhimaCreditEpCreditlinkAuthCreateResponse : AopResponse
    {
        /// <summary>
        /// 业务订单号
        /// </summary>
        [XmlElement("biz_no")]
        public string BizNo { get; set; }

        /// <summary>
        /// 授权有效时间,格式"yyyy-MM-dd HH:mm:ss"
        /// </summary>
        [XmlElement("expire_time")]
        public string ExpireTime { get; set; }
    }
}
