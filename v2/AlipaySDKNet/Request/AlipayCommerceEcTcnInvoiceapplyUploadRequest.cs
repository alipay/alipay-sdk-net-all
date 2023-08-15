using System;
using System.Collections.Generic;
using Aop.Api.Response;
using Aop.Api.Util;

namespace Aop.Api.Request
{
    /// <summary>
    /// AOP API: alipay.commerce.ec.tcn.invoiceapply.upload
    /// </summary>
    public class AlipayCommerceEcTcnInvoiceapplyUploadRequest : IAopUploadRequest<AlipayCommerceEcTcnInvoiceapplyUploadResponse>
    {
        /// <summary>
        /// 申请ID
        /// </summary>
        public string ApplyId { get; set; }

        /// <summary>
        /// 购方地址
        /// </summary>
        public string BuyerAddress { get; set; }

        /// <summary>
        /// 购方银行账号
        /// </summary>
        public string BuyerBankAccount { get; set; }

        /// <summary>
        /// 购方开户行
        /// </summary>
        public string BuyerBankName { get; set; }

        /// <summary>
        /// 购方名称
        /// </summary>
        public string BuyerName { get; set; }

        /// <summary>
        /// 购方税号
        /// </summary>
        public string BuyerTaxNo { get; set; }

        /// <summary>
        /// 购方电话
        /// </summary>
        public string BuyerTel { get; set; }

        /// <summary>
        /// 发票校验码
        /// </summary>
        public string CheckCode { get; set; }

        /// <summary>
        /// 文件字节流数据
        /// </summary>
        public FileItem FileData { get; set; }

        /// <summary>
        /// 文件类型
        /// </summary>
        public string FileType { get; set; }

        /// <summary>
        /// 开票金额
        /// </summary>
        public string InvoiceAmount { get; set; }

        /// <summary>
        /// 小数点保留6位，开票金额（不含税）
        /// </summary>
        public string InvoiceAmountWithoutTax { get; set; }

        /// <summary>
        /// 发票代码
        /// </summary>
        public string InvoiceCode { get; set; }

        /// <summary>
        /// 开票时间
        /// </summary>
        public Nullable<DateTime> InvoiceDate { get; set; }

        /// <summary>
        /// 发票介质类型
        /// </summary>
        public string InvoiceKind { get; set; }

        /// <summary>
        /// 发票号码
        /// </summary>
        public string InvoiceNo { get; set; }

        /// <summary>
        /// 税额
        /// </summary>
        public string InvoiceTaxAmount { get; set; }

        /// <summary>
        /// 发票税率
        /// </summary>
        public string InvoiceTaxRate { get; set; }

        /// <summary>
        /// 发票类型
        /// </summary>
        public string InvoiceType { get; set; }

        /// <summary>
        /// 原发票代码
        /// </summary>
        public string OriginalInvoiceCode { get; set; }

        /// <summary>
        /// 原发票号码
        /// </summary>
        public string OriginalInvoiceNo { get; set; }

        /// <summary>
        /// 冲红备注
        /// </summary>
        public string RedRemarks { get; set; }

        /// <summary>
        /// 销方地址
        /// </summary>
        public string SellerAddress { get; set; }

        /// <summary>
        /// 销方银行账号
        /// </summary>
        public string SellerBankAccount { get; set; }

        /// <summary>
        /// 销方开户行
        /// </summary>
        public string SellerBankName { get; set; }

        /// <summary>
        /// 销方名称
        /// </summary>
        public string SellerName { get; set; }

        /// <summary>
        /// 销方税号
        /// </summary>
        public string SellerTaxNo { get; set; }

        /// <summary>
        /// 销方电话
        /// </summary>
        public string SellerTel { get; set; }

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
            return "alipay.commerce.ec.tcn.invoiceapply.upload";
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
            parameters.Add("buyer_address", this.BuyerAddress);
            parameters.Add("buyer_bank_account", this.BuyerBankAccount);
            parameters.Add("buyer_bank_name", this.BuyerBankName);
            parameters.Add("buyer_name", this.BuyerName);
            parameters.Add("buyer_tax_no", this.BuyerTaxNo);
            parameters.Add("buyer_tel", this.BuyerTel);
            parameters.Add("check_code", this.CheckCode);
            parameters.Add("file_type", this.FileType);
            parameters.Add("invoice_amount", this.InvoiceAmount);
            parameters.Add("invoice_amount_without_tax", this.InvoiceAmountWithoutTax);
            parameters.Add("invoice_code", this.InvoiceCode);
            parameters.Add("invoice_date", this.InvoiceDate);
            parameters.Add("invoice_kind", this.InvoiceKind);
            parameters.Add("invoice_no", this.InvoiceNo);
            parameters.Add("invoice_tax_amount", this.InvoiceTaxAmount);
            parameters.Add("invoice_tax_rate", this.InvoiceTaxRate);
            parameters.Add("invoice_type", this.InvoiceType);
            parameters.Add("original_invoice_code", this.OriginalInvoiceCode);
            parameters.Add("original_invoice_no", this.OriginalInvoiceNo);
            parameters.Add("red_remarks", this.RedRemarks);
            parameters.Add("seller_address", this.SellerAddress);
            parameters.Add("seller_bank_account", this.SellerBankAccount);
            parameters.Add("seller_bank_name", this.SellerBankName);
            parameters.Add("seller_name", this.SellerName);
            parameters.Add("seller_tax_no", this.SellerTaxNo);
            parameters.Add("seller_tel", this.SellerTel);
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
            parameters.Add("file_data", this.FileData);
            return parameters;
        }

        #endregion
    }
}
