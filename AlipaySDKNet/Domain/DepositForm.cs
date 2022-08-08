using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// DepositForm Data Structure.
    /// </summary>
    [Serializable]
    public class DepositForm : AopObject
    {
        /// <summary>
        /// 充值金额（单位为元，必须大于0且最多小数点后两位）
        /// </summary>
        [XmlElement("amount")]
        public string Amount { get; set; }

        /// <summary>
        /// 订单标题：敏感字、长度超长会拒绝交易，可包括数字、字母、空格、汉字，但不能包括特殊字符、emoji等
        /// </summary>
        [XmlElement("order_title")]
        public string OrderTitle { get; set; }

        /// <summary>
        /// 商户侧单号（幂等字段） 补充说明：转入场景幂等逻辑（商户appid+out_biz_no），商户集成时需注意，如换号重复发起，则认为是一笔新的请求
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }
    }
}
