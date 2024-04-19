using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayInsSceneInsserviceprodSerinfoSyncResponse.
    /// </summary>
    public class AlipayInsSceneInsserviceprodSerinfoSyncResponse : AopResponse
    {
        /// <summary>
        /// 支付宝的单据编号 (就是请求中的ser_biz_no原封不动返回)
        /// </summary>
        [XmlElement("ser_biz_no")]
        public string SerBizNo { get; set; }
    }
}
