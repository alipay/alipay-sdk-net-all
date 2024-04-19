using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayTradeRepaybillBillinConfirmModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayTradeRepaybillBillinConfirmModel : AopObject
    {
        /// <summary>
        /// 本次业务订单入账的金额，精确到小数点后两位，取值范围[0.01,100000000]
        /// </summary>
        [XmlElement("amount")]
        public string Amount { get; set; }

        /// <summary>
        /// 账单产品类型，标识业务用，具体值支付宝根据业务接入场景进行分配。
        /// </summary>
        [XmlElement("bill_product")]
        public string BillProduct { get; set; }

        /// <summary>
        /// 业务债务出账金额，账单入账会触发业务债务出账，对于存在售中退款场景，入账金额和债务出账金额会不一致。例如交易金额为10元，售中退款4元，调用此接口入账则amount应该等于10元，biz_debts_out_amount应该等于6元。
        /// </summary>
        [XmlElement("biz_debts_out_amount")]
        public string BizDebtsOutAmount { get; set; }

        /// <summary>
        /// 本次账单同步关联的支付宝交易单号
        /// </summary>
        [XmlElement("biz_no")]
        public string BizNo { get; set; }

        /// <summary>
        /// 外部账单编号，用于控制账单的幂等，同一批账单的业务订单外部账单号为同一个
        /// </summary>
        [XmlElement("out_bill_no")]
        public string OutBillNo { get; set; }

        /// <summary>
        /// 外部请求号,唯一标识一次请求
        /// </summary>
        [XmlElement("out_request_no")]
        public string OutRequestNo { get; set; }

        /// <summary>
        /// 账单归属主体，蚂蚁统一会员id
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
