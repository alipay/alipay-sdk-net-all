using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayEbppCommunityThirdpartybillCreateResponse.
    /// </summary>
    public class AlipayEbppCommunityThirdpartybillCreateResponse : AopResponse
    {
        /// <summary>
        /// 支付宝内部生成账单流水号。
        /// </summary>
        [XmlElement("alipay_biz_no")]
        public string AlipayBizNo { get; set; }
    }
}
