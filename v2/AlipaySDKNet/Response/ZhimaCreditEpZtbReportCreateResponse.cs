using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// ZhimaCreditEpZtbReportCreateResponse.
    /// </summary>
    public class ZhimaCreditEpZtbReportCreateResponse : AopResponse
    {
        /// <summary>
        /// 报告订单号
        /// </summary>
        [XmlElement("order_no")]
        public string OrderNo { get; set; }

        /// <summary>
        /// 商户唯一业务流水号，由大小写字母和数字构成（当商户传入时返回）
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }
    }
}
