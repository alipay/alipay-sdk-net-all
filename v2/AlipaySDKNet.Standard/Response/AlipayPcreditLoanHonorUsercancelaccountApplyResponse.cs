using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayPcreditLoanHonorUsercancelaccountApplyResponse.
    /// </summary>
    public class AlipayPcreditLoanHonorUsercancelaccountApplyResponse : AopResponse
    {
        /// <summary>
        /// 注销失败描述
        /// </summary>
        [XmlElement("logoff_err_desc")]
        public string LogoffErrDesc { get; set; }

        /// <summary>
        /// 注销受理是否成功，注销业务逻辑异步处理
        /// </summary>
        [XmlElement("logoff_result")]
        public bool LogoffResult { get; set; }

        /// <summary>
        /// --增加注销结果？ 1-注销成功--处理完成的结果 2-注销处理中--处理中 3-注销失败（不允许出现）
        /// </summary>
        [XmlElement("logoff_status")]
        public string LogoffStatus { get; set; }

        /// <summary>
        /// 渠道侧受理单号
        /// </summary>
        [XmlElement("out_order_no")]
        public string OutOrderNo { get; set; }
    }
}
