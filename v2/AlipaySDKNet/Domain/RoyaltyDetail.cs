using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RoyaltyDetail Data Structure.
    /// </summary>
    [Serializable]
    public class RoyaltyDetail : AopObject
    {
        /// <summary>
        /// 分账金额
        /// </summary>
        [XmlElement("amount")]
        public string Amount { get; set; }

        /// <summary>
        /// 支付宝分账明细单号，每笔分账业务执行的明细单号
        /// </summary>
        [XmlElement("detail_id")]
        public string DetailId { get; set; }

        /// <summary>
        /// 分账失败错误码，只在分账失败时返回
        /// </summary>
        [XmlElement("error_code")]
        public string ErrorCode { get; set; }

        /// <summary>
        /// 分账错误描述信息
        /// </summary>
        [XmlElement("error_desc")]
        public string ErrorDesc { get; set; }

        /// <summary>
        /// 分账执行时间
        /// </summary>
        [XmlElement("execute_dt")]
        public string ExecuteDt { get; set; }

        /// <summary>
        /// 分账操作类型。有以下几种类型： replenish(补差)、replenish_refund(退补差)、transfer(分账)、transfer_refund(退分账)
        /// </summary>
        [XmlElement("operation_type")]
        public string OperationType { get; set; }

        /// <summary>
        /// 分账状态，SUCCESS成功，FAIL失败，PROCESSING处理中
        /// </summary>
        [XmlElement("state")]
        public string State { get; set; }

        /// <summary>
        /// 分账转入账号，只有在operation_type为replenish_refund(退补差)，transfer(分账)才返回该字段或trans_in_open_id。trans_in_open_id为分账转入方的openId，当trans_in_open_id不为空的时候，请优先使用trans_in_open_id。
        /// </summary>
        [XmlElement("trans_in")]
        public string TransIn { get; set; }

        /// <summary>
        /// 分账转入方的OpenId，OpenId为用户在该应用下支付宝的唯一用户标识。
        /// </summary>
        [XmlElement("trans_in_open_id")]
        public string TransInOpenId { get; set; }

        /// <summary>
        /// 分账转入账号类型，userId表示是支付宝账号对应的支付宝唯一用户号，loginName表示是支付宝登录号，secondMerchantID表示是二级商户id。 只有在operation_type为replenish_refund(退补差)，transfer(分账)才返回该字段
        /// </summary>
        [XmlElement("trans_in_type")]
        public string TransInType { get; set; }

        /// <summary>
        /// 分账转出账号，只有在operation_type为replenish(补差),transfer_refund(退分账)类型才返回该字段或trans_out_open_id字段。trans_out_open_id字段为分账转出方的openId，当trans_out_open_id 字段不为空时，请优先使用trans_out_open_id。
        /// </summary>
        [XmlElement("trans_out")]
        public string TransOut { get; set; }

        /// <summary>
        /// 分账转出方的OpenId，OpenId为用户在该应用下支付宝内的唯一用户标识。
        /// </summary>
        [XmlElement("trans_out_open_id")]
        public string TransOutOpenId { get; set; }

        /// <summary>
        /// 分账转出账号类型，userId表示是支付宝账号对应的支付宝唯一用户号，loginName表示是支付宝登录号，secondMerchantID表示是二级商户id。 只有在operation_type为replenish(补差)，transfer_refund(退分账)类型才返回该字段
        /// </summary>
        [XmlElement("trans_out_type")]
        public string TransOutType { get; set; }
    }
}
