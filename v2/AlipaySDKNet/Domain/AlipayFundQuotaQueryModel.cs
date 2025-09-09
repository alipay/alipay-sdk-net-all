using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayFundQuotaQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayFundQuotaQueryModel : AopObject
    {
        /// <summary>
        /// 描述特定的业务场景，与实际转账场景一致，可传的参数如下： DIRECT_TRANSFER：单笔无密转账到支付宝，单笔无密转账到银行卡，现金红包; DEFAULT：使用alipay.fund.trans.toaccount.transfer转账到户场景
        /// </summary>
        [XmlElement("biz_scene")]
        public string BizScene { get; set; }

        /// <summary>
        /// 业务产品码， 单笔转账到支付宝账户固定为: TRANS_ACCOUNT_NO_PWD； 收发现金红包固定为: STD_RED_PACKET；单笔付款到卡固定为：TRANS_BANKCARD_NO_PWD；单笔付款到卡固定为：TRANS_BANKCARD_NO_PWD；使用alipay.fund.trans.toaccount.transfer接口固定为DEFAULT
        /// </summary>
        [XmlElement("product_code")]
        public string ProductCode { get; set; }
    }
}
