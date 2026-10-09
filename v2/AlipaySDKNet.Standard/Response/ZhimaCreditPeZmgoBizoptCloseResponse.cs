using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// ZhimaCreditPeZmgoBizoptCloseResponse.
    /// </summary>
    public class ZhimaCreditPeZmgoBizoptCloseResponse : AopResponse
    {
        /// <summary>
        /// 芝麻GO签约申请时生成的签约申请单据号
        /// </summary>
        [XmlElement("biz_opt_no")]
        public string BizOptNo { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 商户本次操作的请求流水号
        /// </summary>
        [XmlElement("out_request_no")]
        public string OutRequestNo { get; set; }

        /// <summary>
        /// 商户ID
        /// </summary>
        [XmlElement("partner_id")]
        public string PartnerId { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
