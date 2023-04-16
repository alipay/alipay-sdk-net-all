using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// LogisticsSyncDataDTO Data Structure.
    /// </summary>
    [Serializable]
    public class LogisticsSyncDataDTO : AopObject
    {
        /// <summary>
        /// 路由发生地址
        /// </summary>
        [XmlElement("accept_address")]
        public string AcceptAddress { get; set; }

        /// <summary>
        /// 路由发生时间
        /// </summary>
        [XmlElement("accept_time")]
        public string AcceptTime { get; set; }

        /// <summary>
        /// 实际寄件重量
        /// </summary>
        [XmlElement("actual_weight")]
        public string ActualWeight { get; set; }

        /// <summary>
        /// 认证类型
        /// </summary>
        [XmlElement("auth_code")]
        public string AuthCode { get; set; }

        /// <summary>
        /// 认证类型
        /// </summary>
        [XmlElement("auth_type")]
        public string AuthType { get; set; }

        /// <summary>
        /// 取消原因
        /// </summary>
        [XmlElement("cancel_reason")]
        public string CancelReason { get; set; }

        /// <summary>
        /// 取消时间
        /// </summary>
        [XmlElement("cancel_time")]
        public string CancelTime { get; set; }

        /// <summary>
        /// 快递员姓名
        /// </summary>
        [XmlElement("courier_name")]
        public string CourierName { get; set; }

        /// <summary>
        /// 快递员手机号
        /// </summary>
        [XmlElement("courier_phone")]
        public string CourierPhone { get; set; }

        /// <summary>
        /// 抵扣金额，单位分
        /// </summary>
        [XmlElement("discount_amount")]
        public string DiscountAmount { get; set; }

        /// <summary>
        /// 入库地址
        /// </summary>
        [XmlElement("inbound_address")]
        public string InboundAddress { get; set; }

        /// <summary>
        /// 入库时间
        /// </summary>
        [XmlElement("inbound_time")]
        public string InboundTime { get; set; }

        /// <summary>
        /// 保价费，单位分
        /// </summary>
        [XmlElement("insured_weight_amount")]
        public string InsuredWeightAmount { get; set; }

        /// <summary>
        /// 物流单号
        /// </summary>
        [XmlElement("logistics_no")]
        public string LogisticsNo { get; set; }

        /// <summary>
        /// 主寄件金额，单位分
        /// </summary>
        [XmlElement("main_amount")]
        public string MainAmount { get; set; }

        /// <summary>
        /// 路由节点操作码
        /// </summary>
        [XmlElement("op_code")]
        public string OpCode { get; set; }

        /// <summary>
        /// 外部业务单号
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 物流公司单号
        /// </summary>
        [XmlElement("out_logistics_no")]
        public string OutLogisticsNo { get; set; }

        /// <summary>
        /// 超重价格，单位分
        /// </summary>
        [XmlElement("over_weight_amount")]
        public string OverWeightAmount { get; set; }

        /// <summary>
        /// 包装费，单位分
        /// </summary>
        [XmlElement("package_amount")]
        public string PackageAmount { get; set; }

        /// <summary>
        /// 用户支付链接
        /// </summary>
        [XmlElement("pay_url")]
        public string PayUrl { get; set; }

        /// <summary>
        /// 实收续重金额，单位分
        /// </summary>
        [XmlElement("receipt_addition")]
        public string ReceiptAddition { get; set; }

        /// <summary>
        /// 实收首重金额，单位分
        /// </summary>
        [XmlElement("receipt_first")]
        public string ReceiptFirst { get; set; }

        /// <summary>
        /// 实收金额，单位分
        /// </summary>
        [XmlElement("receipt_total")]
        public string ReceiptTotal { get; set; }

        /// <summary>
        /// 物流揽收时间
        /// </summary>
        [XmlElement("receive_time")]
        public string ReceiveTime { get; set; }

        /// <summary>
        /// 路由节点备注
        /// </summary>
        [XmlElement("remark")]
        public string Remark { get; set; }

        /// <summary>
        /// 签收时间
        /// </summary>
        [XmlElement("sign_time")]
        public string SignTime { get; set; }

        /// <summary>
        /// 签收人地址
        /// </summary>
        [XmlElement("signer_address")]
        public string SignerAddress { get; set; }

        /// <summary>
        /// 签收人名称
        /// </summary>
        [XmlElement("signer_name")]
        public string SignerName { get; set; }

        /// <summary>
        /// 签收人联系方式
        /// </summary>
        [XmlElement("signer_phone")]
        public string SignerPhone { get; set; }

        /// <summary>
        /// 用户实际需要支付金额，单位分
        /// </summary>
        [XmlElement("user_need_pay")]
        public string UserNeedPay { get; set; }

        /// <summary>
        /// 用户实际支付金额，单位分
        /// </summary>
        [XmlElement("user_real_pay")]
        public string UserRealPay { get; set; }
    }
}
