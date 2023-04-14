using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayEbppInvoiceApplyInvUploadModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEbppInvoiceApplyInvUploadModel : AopObject
    {
        /// <summary>
        /// 发票防伪码/密码
        /// </summary>
        [XmlElement("anti_fake_code")]
        public string AntiFakeCode { get; set; }

        /// <summary>
        /// 发票申请ID, 由阿里发票平台生成。 拆单开票后一笔申请可能对应多张发票。 source=apply时必填，其他source可为空
        /// </summary>
        [XmlElement("apply_id")]
        public string ApplyId { get; set; }

        /// <summary>
        /// 开票失败错误码， 开票失败(create_result=fail)时必填
        /// </summary>
        [XmlElement("biz_error_code")]
        public string BizErrorCode { get; set; }

        /// <summary>
        /// 开票失败错误信息， 开票失败(create_result=fail)时必填
        /// </summary>
        [XmlElement("biz_error_msg")]
        public string BizErrorMsg { get; set; }

        /// <summary>
        /// 抬头类型。可选值： 0：个人 1：企业
        /// </summary>
        [XmlElement("business_type")]
        public long BusinessType { get; set; }

        /// <summary>
        /// 校验码
        /// </summary>
        [XmlElement("check_code")]
        public string CheckCode { get; set; }

        /// <summary>
        /// 开票结果，枚举值： success: 发票开具成功； fail: 开票失败； source=async时必填，传实际的开票结果。其他source可不传，默认为success
        /// </summary>
        [XmlElement("create_result")]
        public string CreateResult { get; set; }

        /// <summary>
        /// 开票分机号/机器编号
        /// </summary>
        [XmlElement("device_no")]
        public string DeviceNo { get; set; }

        /// <summary>
        /// 合计含税金额（开票金额），格式为2位小数。 当开红票时，该字段为负数。 开票成功时(create_result=success)必填
        /// </summary>
        [XmlElement("invoice_amount")]
        public string InvoiceAmount { get; set; }

        /// <summary>
        /// 发票代码。 开票成功时(create_result=success)必填
        /// </summary>
        [XmlElement("invoice_code")]
        public string InvoiceCode { get; set; }

        /// <summary>
        /// 开票日期，格式 yyyy-MM-dd. 开票成功时(create_result=success)必填
        /// </summary>
        [XmlElement("invoice_date")]
        public string InvoiceDate { get; set; }

        /// <summary>
        /// 发票版式文件数据，base64化的字符串； 电子发票必填
        /// </summary>
        [XmlElement("invoice_file_content")]
        public string InvoiceFileContent { get; set; }

        /// <summary>
        /// 发票板式文件类型。可选值： PDF, OFD。 开电票且开票成功时(create_result=success)必填
        /// </summary>
        [XmlElement("invoice_file_type")]
        public string InvoiceFileType { get; set; }

        /// <summary>
        /// 电子发票明细。 source=apply时必填，其他source可为空
        /// </summary>
        [XmlElement("invoice_items")]
        public InvoiceItem InvoiceItems { get; set; }

        /// <summary>
        /// 开票发票类型 可选值： 0: 电票； 1：纸质普票； 2：纸质专票； 开票成功时(create_result=success)必填
        /// </summary>
        [XmlElement("invoice_kind")]
        public long InvoiceKind { get; set; }

        /// <summary>
        /// 发票备注，会显示在票面
        /// </summary>
        [XmlElement("invoice_memo")]
        public string InvoiceMemo { get; set; }

        /// <summary>
        /// 发票号码。 开票成功时(create_result=success)必填
        /// </summary>
        [XmlElement("invoice_no")]
        public string InvoiceNo { get; set; }

        /// <summary>
        /// 发票(开票)类型，可选值： blue: 蓝票； red: 红票； 开票成功时(create_result=success)必填
        /// </summary>
        [XmlElement("invoice_type")]
        public string InvoiceType { get; set; }

        /// <summary>
        /// 征税方式，0普通征收，1减按征收，2差额征收
        /// </summary>
        [XmlElement("levy_type")]
        public string LevyType { get; set; }

        /// <summary>
        /// 原发票代码。 冲红且开票成功时(create_result=success)必填
        /// </summary>
        [XmlElement("normal_invoice_code")]
        public string NormalInvoiceCode { get; set; }

        /// <summary>
        /// 原发票号码。 冲红且开票成功时(create_result=success)必填
        /// </summary>
        [XmlElement("normal_invoice_no")]
        public string NormalInvoiceNo { get; set; }

        /// <summary>
        /// 销方地址。 开票成功时(create_result=success)必填
        /// </summary>
        [XmlElement("payee_address")]
        public string PayeeAddress { get; set; }

        /// <summary>
        /// 销方银行账号
        /// </summary>
        [XmlElement("payee_bank_account_id")]
        public string PayeeBankAccountId { get; set; }

        /// <summary>
        /// 销方开户行名称
        /// </summary>
        [XmlElement("payee_bank_name")]
        public string PayeeBankName { get; set; }

        /// <summary>
        /// 复核人
        /// </summary>
        [XmlElement("payee_checker")]
        public string PayeeChecker { get; set; }

        /// <summary>
        /// 销方名称。 开票成功时(create_result=success)必填
        /// </summary>
        [XmlElement("payee_name")]
        public string PayeeName { get; set; }

        /// <summary>
        /// 开票人。 开票成功时(create_result=success)必填
        /// </summary>
        [XmlElement("payee_operator")]
        public string PayeeOperator { get; set; }

        /// <summary>
        /// 销方联系电话。 开票成功时(create_result=success)必填
        /// </summary>
        [XmlElement("payee_phone")]
        public string PayeePhone { get; set; }

        /// <summary>
        /// 收款人
        /// </summary>
        [XmlElement("payee_receiver")]
        public string PayeeReceiver { get; set; }

        /// <summary>
        /// 销方税务登记证号。由大写字母或数字组成，长度要求15~20位。 开票成功时(create_result=success)必填
        /// </summary>
        [XmlElement("payee_register_no")]
        public string PayeeRegisterNo { get; set; }

        /// <summary>
        /// 购方地址， 专票且开票成功时(create_result=success)必填
        /// </summary>
        [XmlElement("payer_address")]
        public string PayerAddress { get; set; }

        /// <summary>
        /// 购方银行账号， 专票且开票成功时(create_result=success)必填
        /// </summary>
        [XmlElement("payer_bank_account_id")]
        public string PayerBankAccountId { get; set; }

        /// <summary>
        /// 购方开户行名称， 专票且开票成功时(create_result=success)必填
        /// </summary>
        [XmlElement("payer_bank_name")]
        public string PayerBankName { get; set; }

        /// <summary>
        /// 购方电子邮箱，需满足邮箱格式。 格式要求：\\w+([-+.]\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*
        /// </summary>
        [XmlElement("payer_email")]
        public string PayerEmail { get; set; }

        /// <summary>
        /// 购方抬头。 开票成功时(create_result=success)必填
        /// </summary>
        [XmlElement("payer_name")]
        public string PayerName { get; set; }

        /// <summary>
        /// 购方联系电话， 专票且开票成功时(create_result=success)必填
        /// </summary>
        [XmlElement("payer_phone")]
        public string PayerPhone { get; set; }

        /// <summary>
        /// 购方税务登记证号，由大写字母或数字组成，长度要求15~20位。 开企业抬头时必填， 专票且开票成功时(create_result=success)必填
        /// </summary>
        [XmlElement("payer_register_no")]
        public string PayerRegisterNo { get; set; }

        /// <summary>
        /// 业务平台Code, 由发票中台分配。 用于标识需交付发票的业务平台，source=upload时必填，其他source可为空
        /// </summary>
        [XmlElement("platform_code")]
        public string PlatformCode { get; set; }

        /// <summary>
        /// 业务平台发票申请对应的订单号。 用于区分业务平台订单号，source=upload时必填，其他source可为空
        /// </summary>
        [XmlElement("platform_tid")]
        public string PlatformTid { get; set; }

        /// <summary>
        /// 业务平台发票申请对应的订单号。 用于区分业务平台订单号，source=upload时必填，其他source可为空
        /// </summary>
        [XmlElement("platform_user_id")]
        public string PlatformUserId { get; set; }

        /// <summary>
        /// 二维码
        /// </summary>
        [XmlElement("qr_code")]
        public string QrCode { get; set; }

        /// <summary>
        /// 购方手机号码，用于收票
        /// </summary>
        [XmlElement("receive_mobile")]
        public string ReceiveMobile { get; set; }

        /// <summary>
        /// 红字通知单号； 专票冲红且开票成功时(create_result=success)必填
        /// </summary>
        [XmlElement("red_notice_no")]
        public string RedNoticeNo { get; set; }

        /// <summary>
        /// 开票流水号/序列号，唯一标志一笔开票请求，由于阿里发票中台生成。 source=async时必填，其他source可为空
        /// </summary>
        [XmlElement("serial_no")]
        public string SerialNo { get; set; }

        /// <summary>
        /// 发票来源，可选值： apply: 间连开票模式，ISV回传商家基于申请开具的发票； async：直连开票模式，ISV回传开票结果； upload：直接回传，进行归集与交付的发票
        /// </summary>
        [XmlElement("source")]
        public string Source { get; set; }

        /// <summary>
        /// 特殊票种标识，可选值： “00”非特殊票种 （默认值） “02”农产品收购 “06”抵扣通行费 “07”其它通行费 “08”成品油销售 “18”成品油专票负数发票
        /// </summary>
        [XmlElement("special_flag")]
        public string SpecialFlag { get; set; }

        /// <summary>
        /// 合计金额（不含税），格式为2位小数。 当开红票时，该字段为负数。 开票成功时(create_result=success)必填
        /// </summary>
        [XmlElement("sum_price")]
        public string SumPrice { get; set; }

        /// <summary>
        /// 合计税额，格式为2位小数。 当开红票时，该字段为0或负数。 开票成功时(create_result=success)必填
        /// </summary>
        [XmlElement("sum_tax")]
        public string SumTax { get; set; }
    }
}
