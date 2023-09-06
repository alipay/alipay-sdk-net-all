using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceMedicalTradeCreateandpayModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMedicalTradeCreateandpayModel : AopObject
    {
        /// <summary>
        /// 医保个账支付金额
        /// </summary>
        [XmlElement("account_amount")]
        public string AccountAmount { get; set; }

        /// <summary>
        /// 支付宝用户ID，2088开头的16为数字
        /// </summary>
        [XmlElement("alipay_user_id")]
        public string AlipayUserId { get; set; }

        /// <summary>
        /// 支付成功回跳页面地址
        /// </summary>
        [XmlElement("callback_url")]
        public string CallbackUrl { get; set; }

        /// <summary>
        /// 渠道标识，由平台分配给商户
        /// </summary>
        [XmlElement("ch_info")]
        public string ChInfo { get; set; }

        /// <summary>
        /// 医院上传处方明细的收费批次号
        /// </summary>
        [XmlElement("chrg_bch_no")]
        public string ChrgBchNo { get; set; }

        /// <summary>
        /// 医保支付扩展参数
        /// </summary>
        [XmlElement("extend_params")]
        public InsurancePayExtendParams ExtendParams { get; set; }

        /// <summary>
        /// 商户订单创建时间
        /// </summary>
        [XmlElement("gmt_out_create")]
        public string GmtOutCreate { get; set; }

        /// <summary>
        /// 支付超时时间
        /// </summary>
        [XmlElement("gmt_time_expire")]
        public string GmtTimeExpire { get; set; }

        /// <summary>
        /// 医保基金支付金额
        /// </summary>
        [XmlElement("gov_amount")]
        public string GovAmount { get; set; }

        /// <summary>
        /// 行业标识
        /// </summary>
        [XmlElement("industry")]
        public string Industry { get; set; }

        /// <summary>
        /// 医保支付场景标识
        /// </summary>
        [XmlElement("insurance_pay_scene")]
        public string InsurancePayScene { get; set; }

        /// <summary>
        /// 医院支付订单号
        /// </summary>
        [XmlElement("med_org_ord")]
        public string MedOrgOrd { get; set; }

        /// <summary>
        /// 支付宝用户Id
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 订单类型
        /// </summary>
        [XmlElement("order_type")]
        public string OrderType { get; set; }

        /// <summary>
        /// 新国标定点医药机构编码
        /// </summary>
        [XmlElement("org_no")]
        public string OrgNo { get; set; }

        /// <summary>
        /// 医保其他支付金额
        /// </summary>
        [XmlElement("other_amount")]
        public string OtherAmount { get; set; }

        /// <summary>
        /// 外部交易号，需保证商户维度唯一性
        /// </summary>
        [XmlElement("out_trade_no")]
        public string OutTradeNo { get; set; }

        /// <summary>
        /// 支付授权码
        /// </summary>
        [XmlElement("pay_auth_no")]
        public string PayAuthNo { get; set; }

        /// <summary>
        /// 医保订单号
        /// </summary>
        [XmlElement("pay_order_id")]
        public string PayOrderId { get; set; }

        /// <summary>
        /// 用户自费实付金额
        /// </summary>
        [XmlElement("real_amount")]
        public string RealAmount { get; set; }

        /// <summary>
        /// 医保数据透传结构体
        /// </summary>
        [XmlElement("request_content")]
        public string RequestContent { get; set; }

        /// <summary>
        /// 支付结果异步通知地址
        /// </summary>
        [XmlElement("result_notify_url")]
        public string ResultNotifyUrl { get; set; }

        /// <summary>
        /// 平台分配给商户的门店ID，与store_id二选一
        /// </summary>
        [XmlElement("shop_id")]
        public string ShopId { get; set; }

        /// <summary>
        /// 外部门店ID，与shop_id二选一；
        /// </summary>
        [XmlElement("store_id")]
        public string StoreId { get; set; }

        /// <summary>
        /// 订单标题
        /// </summary>
        [XmlElement("subject")]
        public string Subject { get; set; }

        /// <summary>
        /// 补充计算金额参数列表
        /// </summary>
        [XmlArray("subsidy_amount_params")]
        [XmlArrayItem("subsidy_amount_param")]
        public List<SubsidyAmountParam> SubsidyAmountParams { get; set; }

        /// <summary>
        /// 订单总金额
        /// </summary>
        [XmlElement("total_amount")]
        public string TotalAmount { get; set; }
    }
}
