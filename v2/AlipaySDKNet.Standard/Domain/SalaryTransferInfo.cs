using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// SalaryTransferInfo Data Structure.
    /// </summary>
    [Serializable]
    public class SalaryTransferInfo : AopObject
    {
        /// <summary>
        /// 转账的业务场景码，有限枚举： 1.ENTRUST_TRANSFER 2.DIRECT_TRANSFER 3.CO_MANAGER_DIRECT_TRANSFER
        /// </summary>
        [XmlElement("biz_scene")]
        public string BizScene { get; set; }

        /// <summary>
        /// 收款方信息
        /// </summary>
        [XmlElement("payee_info")]
        public TransferParticipantInfo PayeeInfo { get; set; }

        /// <summary>
        /// 付款方信息
        /// </summary>
        [XmlElement("payer_info")]
        public TransferParticipantInfo PayerInfo { get; set; }

        /// <summary>
        /// 业务产品码，有限枚举: 1.SINGLE_TRANSFER_NO_PWD 2.TRANS_ACCOUNT_NO_PWD
        /// </summary>
        [XmlElement("product_code")]
        public string ProductCode { get; set; }

        /// <summary>
        /// 订单总金额，单位为元，不支持千位分隔符，精确到小数点后两位，取值范围[0.1,100000000]。
        /// </summary>
        [XmlElement("trans_amount")]
        public string TransAmount { get; set; }
    }
}
