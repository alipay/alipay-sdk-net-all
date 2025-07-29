using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOfflineProviderUserinfoNverifyDeleteResponse.
    /// </summary>
    public class AlipayOfflineProviderUserinfoNverifyDeleteResponse : AopResponse
    {
        /// <summary>
        /// 出库失败的用户订单号，失败原因一般是订单号未入库。可能为空。
        /// </summary>
        [XmlArray("fail_out_biz_no")]
        [XmlArrayItem("string")]
        public List<string> FailOutBizNo { get; set; }

        /// <summary>
        /// ["ORD2024121701234567","ORD2024121708991234"]
        /// </summary>
        [XmlArray("success_out_biz_no")]
        [XmlArrayItem("string")]
        public List<string> SuccessOutBizNo { get; set; }
    }
}
