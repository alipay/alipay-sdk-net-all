using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayFundTransAppPayResponse.
    /// </summary>
    public class AlipayFundTransAppPayResponse : AopResponse
    {
        /// <summary>
        /// 该笔转账在支付宝系统内部的单据ID
        /// </summary>
        [XmlElement("order_id")]
        public string OrderId { get; set; }

        /// <summary>
        /// 商户端的唯一订单号
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 用于跳转支付宝页面的信息，POST和GET方法生成内容不同：使用POST方法执行，结果为html form表单，在浏览器渲染即可；使用GET方法会得到支付宝URL，需要打开或重定向到该URL。建议使用POST方式。
        /// </summary>
        [XmlElement("pageRedirectionData")]
        public string PageRedirectionData { get; set; }

        /// <summary>
        /// SUCCESS：转账成功；  WAIT_PAY：转账订单等待支付；  CLOSED：订单超时关闭，截止订单支付超时时间(time_expire)仍未支付，单据状态会变更为CLOSED；
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
