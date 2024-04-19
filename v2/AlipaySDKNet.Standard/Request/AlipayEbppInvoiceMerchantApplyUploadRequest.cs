using System;
using System.Collections.Generic;
using Aop.Api.Response;
using Aop.Api.Util;

namespace Aop.Api.Request
{
    /// <summary>
    /// AOP API: alipay.ebpp.invoice.merchant.apply.upload
    /// </summary>
    public class AlipayEbppInvoiceMerchantApplyUploadRequest : IAopUploadRequest<AlipayEbppInvoiceMerchantApplyUploadResponse>
    {
        /// <summary>
        /// 发票申请ID
        /// </summary>
        public string ApplyId { get; set; }

        /// <summary>
        /// 批次ID
        /// </summary>
        public string BatchId { get; set; }

        /// <summary>
        /// 合计含税金额（开票金额）
        /// </summary>
        public string InvoiceAmount { get; set; }

        /// <summary>
        /// 发票代码
        /// </summary>
        public string InvoiceCode { get; set; }

        /// <summary>
        /// 开票日期
        /// </summary>
        public string InvoiceDate { get; set; }

        /// <summary>
        /// 发票板式文件数据
        /// </summary>
        public FileItem InvoiceFileData { get; set; }

        /// <summary>
        /// 发票板式文件类型
        /// </summary>
        public string InvoiceFileType { get; set; }

        /// <summary>
        /// 开票发票类型
        /// </summary>
        public Nullable<long> InvoiceKind { get; set; }

        /// <summary>
        /// 发票号码
        /// </summary>
        public string InvoiceNo { get; set; }

        /// <summary>
        /// 发票(开票)类型
        /// </summary>
        public string InvoiceType { get; set; }

        /// <summary>
        /// 原发票代码
        /// </summary>
        public string NormalInvoiceCode { get; set; }

        /// <summary>
        /// 原发票号码
        /// </summary>
        public string NormalInvoiceNo { get; set; }

        /// <summary>
        /// 销方地址
        /// </summary>
        public string PayeeAddress { get; set; }

        /// <summary>
        /// 销方银行账号
        /// </summary>
        public string PayeeBankAccountId { get; set; }

        /// <summary>
        /// 销方开户行名称
        /// </summary>
        public string PayeeBankName { get; set; }

        /// <summary>
        /// 销方名称
        /// </summary>
        public string PayeeName { get; set; }

        /// <summary>
        /// 销方联系电话
        /// </summary>
        public string PayeePhone { get; set; }

        /// <summary>
        /// 销方税务登记证号
        /// </summary>
        public string PayeeRegisterNo { get; set; }

        /// <summary>
        /// 购方名称
        /// </summary>
        public string PayerName { get; set; }

        /// <summary>
        /// 购方税号
        /// </summary>
        public string PayerRegisterNo { get; set; }

        /// <summary>
        /// 合计金额（不含税）
        /// </summary>
        public string SumPrice { get; set; }

        /// <summary>
        /// 税额
        /// </summary>
        public string SumTax { get; set; }

        #region IAopRequest Members
		private bool needEncrypt=false;
		private string apiVersion = "1.0";
		private string terminalType;
		private string terminalInfo;
        private string prodCode;
		private string notifyUrl;
        private string returnUrl;
		private AopObject bizModel;
        private Dictionary<string, string> udfParams; //add user-defined text parameters

    	 public void SetNeedEncrypt(bool needEncrypt){
             this.needEncrypt=needEncrypt;
        }

        public bool GetNeedEncrypt(){

            return this.needEncrypt;
        }

		public void SetNotifyUrl(string notifyUrl){
            this.notifyUrl = notifyUrl;
        }

        public string GetNotifyUrl(){
            return this.notifyUrl;
        }

        public void SetReturnUrl(string returnUrl){
            this.returnUrl = returnUrl;
        }

        public string GetReturnUrl(){
            return this.returnUrl;
        }

		public void SetTerminalType(String terminalType){
			this.terminalType=terminalType;
		}

    	public string GetTerminalType(){
    		return this.terminalType;
    	}

    	public void SetTerminalInfo(String terminalInfo){
    		this.terminalInfo=terminalInfo;
    	}

    	public string GetTerminalInfo(){
    		return this.terminalInfo;
    	}

        public void SetProdCode(String prodCode){
            this.prodCode=prodCode;
        }

        public string GetProdCode(){
            return this.prodCode;
        }

		public void SetApiVersion(string apiVersion){
            this.apiVersion=apiVersion;
        }

        public string GetApiVersion(){
            return this.apiVersion;
        }

        public string GetApiName()
        {
            return "alipay.ebpp.invoice.merchant.apply.upload";
        }

        public void PutOtherTextParam(string key, string value) 
        {
            if(this.udfParams == null) 
            {
                this.udfParams = new Dictionary<string, string>();
            }
            this.udfParams.Add(key, value);
        }

        public IDictionary<string, string> GetParameters()
        {
            AopDictionary parameters = new AopDictionary();
            parameters.Add("apply_id", this.ApplyId);
            parameters.Add("batch_id", this.BatchId);
            parameters.Add("invoice_amount", this.InvoiceAmount);
            parameters.Add("invoice_code", this.InvoiceCode);
            parameters.Add("invoice_date", this.InvoiceDate);
            parameters.Add("invoice_file_type", this.InvoiceFileType);
            parameters.Add("invoice_kind", this.InvoiceKind);
            parameters.Add("invoice_no", this.InvoiceNo);
            parameters.Add("invoice_type", this.InvoiceType);
            parameters.Add("normal_invoice_code", this.NormalInvoiceCode);
            parameters.Add("normal_invoice_no", this.NormalInvoiceNo);
            parameters.Add("payee_address", this.PayeeAddress);
            parameters.Add("payee_bank_account_id", this.PayeeBankAccountId);
            parameters.Add("payee_bank_name", this.PayeeBankName);
            parameters.Add("payee_name", this.PayeeName);
            parameters.Add("payee_phone", this.PayeePhone);
            parameters.Add("payee_register_no", this.PayeeRegisterNo);
            parameters.Add("payer_name", this.PayerName);
            parameters.Add("payer_register_no", this.PayerRegisterNo);
            parameters.Add("sum_price", this.SumPrice);
            parameters.Add("sum_tax", this.SumTax);
            if(udfParams != null) 
            {
                parameters.AddAll(this.udfParams);
            }
            return parameters;
        }
		
		public AopObject GetBizModel()
        {
            return this.bizModel;
        }

        public void SetBizModel(AopObject bizModel)
        {
            this.bizModel = bizModel;
        }

        #endregion

        #region IAopUploadRequest Members

        public IDictionary<string, FileItem> GetFileParameters()
        {
            IDictionary<string, FileItem> parameters = new Dictionary<string, FileItem>();
            parameters.Add("invoice_file_data", this.InvoiceFileData);
            return parameters;
        }

        #endregion
    }
}
