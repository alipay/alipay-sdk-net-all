using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayUserUnicomMobileSyncResponse.
    /// </summary>
    public class AlipayUserUnicomMobileSyncResponse : AopResponse
    {
        /// <summary>
        /// 业务处理结果（成功: SUCCESS, 失败: FAIL, 重试: RETRY）
        /// </summary>
        [XmlElement("mobile_sync_result")]
        public string MobileSyncResult { get; set; }

        /// <summary>
        /// 回传的业务流水号
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }
    }
}
