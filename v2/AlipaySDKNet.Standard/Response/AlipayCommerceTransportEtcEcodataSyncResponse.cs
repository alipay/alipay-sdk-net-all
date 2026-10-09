using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceTransportEtcEcodataSyncResponse.
    /// </summary>
    public class AlipayCommerceTransportEtcEcodataSyncResponse : AopResponse
    {
        /// <summary>
        /// 域内业务号，对应用户该笔ETC申请单号
        /// </summary>
        [XmlElement("alipay_biz_no")]
        public string AlipayBizNo { get; set; }

        /// <summary>
        /// 同步结果，true/false
        /// </summary>
        [XmlElement("sync_result")]
        public bool SyncResult { get; set; }
    }
}
