using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceTransportTourAssetDeleteResponse.
    /// </summary>
    public class AlipayCommerceTransportTourAssetDeleteResponse : AopResponse
    {
        /// <summary>
        /// 出库失败的订单号列表
        /// </summary>
        [XmlArray("fail_out_biz_no")]
        [XmlArrayItem("string")]
        public List<string> FailOutBizNo { get; set; }

        /// <summary>
        /// 出库成功的订单号列表
        /// </summary>
        [XmlArray("success_out_biz_no")]
        [XmlArrayItem("string")]
        public List<string> SuccessOutBizNo { get; set; }
    }
}
