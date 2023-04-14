using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayFundBailOperationDepositCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayFundBailOperationDepositCreateModel : AopObject
    {
        /// <summary>
        /// 协议号，保证金唯一协议号
        /// </summary>
        [XmlElement("agreement_no")]
        public string AgreementNo { get; set; }

        /// <summary>
        /// 创建保证金缴纳单金额，单位元
        /// </summary>
        [XmlElement("amount")]
        public string Amount { get; set; }

        /// <summary>
        /// 扩展大字段,扩展信息主键值限制为com.alipay.accordercore.common.service.facade.control.auth.model.enums.ExtInfoKey
        /// </summary>
        [XmlElement("extra_param")]
        public string ExtraParam { get; set; }

        /// <summary>
        /// 单据标题，用于收银台展示，传空将使用主单标题---”保证金资金池“
        /// </summary>
        [XmlElement("operation_title")]
        public string OperationTitle { get; set; }

        /// <summary>
        /// 外部请求号，商户流水号，创单的幂等号
        /// </summary>
        [XmlElement("out_request_no")]
        public string OutRequestNo { get; set; }

        /// <summary>
        /// 支付超时时间，超时关闭流水，不可继续支付
        /// </summary>
        [XmlElement("pay_timeout")]
        public string PayTimeout { get; set; }

        /// <summary>
        /// 产品码，固定传 BAIL_AUTH
        /// </summary>
        [XmlElement("product_code")]
        public string ProductCode { get; set; }

        /// <summary>
        /// 备注，展示在账单中
        /// </summary>
        [XmlElement("remark")]
        public string Remark { get; set; }

        /// <summary>
        /// 业务方指定需要展示在收银台的的用户昵称
        /// </summary>
        [XmlElement("user_nick")]
        public string UserNick { get; set; }
    }
}
