using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// ZhimaCreditEpReportCreateResponse.
    /// </summary>
    public class ZhimaCreditEpReportCreateResponse : AopResponse
    {
        /// <summary>
        /// 报告订单号
        /// </summary>
        [XmlElement("order_no")]
        public string OrderNo { get; set; }

        /// <summary>
        /// 合作方外部订单号
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 页面跳转地址
        /// </summary>
        [XmlElement("page_redirection")]
        public string PageRedirection { get; set; }
    }
}
