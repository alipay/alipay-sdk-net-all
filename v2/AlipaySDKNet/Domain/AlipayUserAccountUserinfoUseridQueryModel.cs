using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayUserAccountUserinfoUseridQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayUserAccountUserinfoUseridQueryModel : AopObject
    {
        /// <summary>
        /// 用来描述及校验业务来源，如果不传会提示异常
        /// </summary>
        [XmlElement("biz_from")]
        public string BizFrom { get; set; }

        /// <summary>
        /// 用来标注qr_code使用业务场景
        /// </summary>
        [XmlElement("biz_type")]
        public string BizType { get; set; }

        /// <summary>
        /// 获取支付宝用户id的令牌
        /// </summary>
        [XmlElement("qr_code")]
        public string QrCode { get; set; }
    }
}
