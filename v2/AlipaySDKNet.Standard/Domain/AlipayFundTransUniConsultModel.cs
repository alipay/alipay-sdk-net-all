using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayFundTransUniConsultModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayFundTransUniConsultModel : AopObject
    {
        /// <summary>
        /// 描述特定的业务场景，可传的参数如下： DIRECT_TRANSFER：单笔无密转账到支付宝，其他场景以对应的产品接入指南文档为准。
        /// </summary>
        [XmlElement("biz_scene")]
        public string BizScene { get; set; }

        /// <summary>
        /// 转账咨询业务的标题
        /// </summary>
        [XmlElement("order_title")]
        public string OrderTitle { get; set; }

        /// <summary>
        /// 商家侧唯一订单号，由商家自定义。对于不同转账咨询请求，商家需保证该订单号在自身系统唯一。
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 收款方信息
        /// </summary>
        [XmlElement("payee_info")]
        public Participant PayeeInfo { get; set; }

        /// <summary>
        /// 付款方信息
        /// </summary>
        [XmlElement("payer_info")]
        public Participant PayerInfo { get; set; }

        /// <summary>
        /// 业务产品码， 单笔无密转账到支付宝账户固定为: TRANS_ACCOUNT_NO_PWD，其他场景以对应的产品接入指南文档为准。
        /// </summary>
        [XmlElement("product_code")]
        public string ProductCode { get; set; }

        /// <summary>
        /// 业务备注
        /// </summary>
        [XmlElement("remark")]
        public string Remark { get; set; }

        /// <summary>
        /// 订单总金额，单位为元，精确到小数点后两位， TRANS_ACCOUNT_NO_PWD产品取值范围[0.1,100000000]
        /// </summary>
        [XmlElement("trans_amount")]
        public string TransAmount { get; set; }
    }
}
