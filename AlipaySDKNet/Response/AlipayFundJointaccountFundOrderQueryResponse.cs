using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayFundJointaccountFundOrderQueryResponse.
    /// </summary>
    public class AlipayFundJointaccountFundOrderQueryResponse : AopResponse
    {
        /// <summary>
        /// 操作金额（单位为元，必须大于0且最多小数点后两位）
        /// </summary>
        [XmlElement("amount")]
        public string Amount { get; set; }

        /// <summary>
        /// 资金操作时间（yyyy-MM-dd HH:mm:ss）
        /// </summary>
        [XmlElement("biz_date")]
        public string BizDate { get; set; }

        /// <summary>
        /// 支付宝侧转账订单号
        /// </summary>
        [XmlElement("biz_trans_id")]
        public string BizTransId { get; set; }

        /// <summary>
        /// 资金操作的错误码
        /// </summary>
        [XmlElement("error_code")]
        public string ErrorCode { get; set; }

        /// <summary>
        /// 错误描述
        /// </summary>
        [XmlElement("error_msg")]
        public string ErrorMsg { get; set; }

        /// <summary>
        /// 订单标题 <br/> 补充说明： <br/> - 该字段与各类资金操作接口的请求参数中传入值保持一致
        /// </summary>
        [XmlElement("order_title")]
        public string OrderTitle { get; set; }

        /// <summary>
        /// 资金单据的状态： <br/> - INIT 初始化 <br/> - SUCESS 成功 <br/> - FAIL 失败 <br/>
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
