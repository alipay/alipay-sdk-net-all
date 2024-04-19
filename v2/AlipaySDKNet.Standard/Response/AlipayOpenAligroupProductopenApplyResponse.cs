using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenAligroupProductopenApplyResponse.
    /// </summary>
    public class AlipayOpenAligroupProductopenApplyResponse : AopResponse
    {
        /// <summary>
        /// ctu校验结果对象，内部包含校验结果以及错误code与信息
        /// </summary>
        [XmlElement("ctu_error_info")]
        public CtuErrorInfo CtuErrorInfo { get; set; }

        /// <summary>
        /// 订单号
        /// </summary>
        [XmlElement("order_no")]
        public string OrderNo { get; set; }
    }
}
