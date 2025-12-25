using System;
using System.Collections.Generic;
using Aop.Api.Response;
using Aop.Api.Util;

namespace Aop.Api.Request
{
    /// <summary>
    /// AOP API: alipay.commerce.medical.insurance.file.upload
    /// </summary>
    public class AlipayCommerceMedicalInsuranceFileUploadRequest : IAopUploadRequest<AlipayCommerceMedicalInsuranceFileUploadResponse>
    {
        /// <summary>
        /// 理赔申请号（保司）
        /// </summary>
        public string ApplyNo { get; set; }

        /// <summary>
        /// 支付宝生成的业务流水号
        /// </summary>
        public string BizNo { get; set; }

        /// <summary>
        /// 报案号（保司）
        /// </summary>
        public string ClaimNo { get; set; }

        /// <summary>
        /// 支付宝给出固定值,见接口文档附录
        /// </summary>
        public string ClaimStatus { get; set; }

        /// <summary>
        /// 保司类型
        /// </summary>
        public string CompanyType { get; set; }

        /// <summary>
        /// 文件内容
        /// </summary>
        public FileItem FileContent { get; set; }

        /// <summary>
        /// 理赔通知书文件编码
        /// </summary>
        public string FileNo { get; set; }

        /// <summary>
        /// 支付宝open_id
        /// </summary>
        public string OpenId { get; set; }

        /// <summary>
        /// 支付宝user_id
        /// </summary>
        public string UserId { get; set; }

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
            return "alipay.commerce.medical.insurance.file.upload";
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
            parameters.Add("apply_no", this.ApplyNo);
            parameters.Add("biz_no", this.BizNo);
            parameters.Add("claim_no", this.ClaimNo);
            parameters.Add("claim_status", this.ClaimStatus);
            parameters.Add("company_type", this.CompanyType);
            parameters.Add("file_no", this.FileNo);
            parameters.Add("open_id", this.OpenId);
            parameters.Add("user_id", this.UserId);
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
            parameters.Add("file_content", this.FileContent);
            return parameters;
        }

        #endregion
    }
}
