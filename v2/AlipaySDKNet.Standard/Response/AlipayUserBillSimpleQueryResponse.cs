using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayUserBillSimpleQueryResponse.
    /// </summary>
    public class AlipayUserBillSimpleQueryResponse : AopResponse
    {
        /// <summary>
        /// 交易金额/转账金额。单位为元
        /// </summary>
        [XmlElement("amount")]
        public string Amount { get; set; }

        /// <summary>
        /// 业务状态
        /// </summary>
        [XmlElement("biz_state")]
        public string BizState { get; set; }

        /// <summary>
        /// 业务创建时间
        /// </summary>
        [XmlElement("gmt_biz_create")]
        public string GmtBizCreate { get; set; }

        /// <summary>
        /// 资金流入流出类型 IN 表示收入 OUT表示支出
        /// </summary>
        [XmlElement("in_out_type")]
        public string InOutType { get; set; }
    }
}
