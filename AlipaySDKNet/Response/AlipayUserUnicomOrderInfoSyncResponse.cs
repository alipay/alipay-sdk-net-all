using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayUserUnicomOrderInfoSyncResponse.
    /// </summary>
    public class AlipayUserUnicomOrderInfoSyncResponse : AopResponse
    {
        /// <summary>
        /// 联通订单号
        /// </summary>
        [XmlElement("order_no")]
        public string OrderNo { get; set; }

        /// <summary>
        /// 业务处理结果 （成功: SUCCESS, 失败: FAIL, 重试: RETRY）
        /// </summary>
        [XmlElement("order_sync_result")]
        public string OrderSyncResult { get; set; }
    }
}
