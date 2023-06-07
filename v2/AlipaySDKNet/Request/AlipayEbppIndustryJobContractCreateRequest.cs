using System;
using Aop.Api.Domain;
using System.Collections.Generic;
using Aop.Api.Response;
using Aop.Api.Util;

namespace Aop.Api.Request
{
    /// <summary>
    /// AOP API: alipay.ebpp.industry.job.contract.create
    /// </summary>
    public class AlipayEbppIndustryJobContractCreateRequest : IAopUploadRequest<AlipayEbppIndustryJobContractCreateResponse>
    {
        /// <summary>
        /// 企业列表
        /// </summary>
        public List<ContractCompanyInfo> CompanyList { get; set; }

        /// <summary>
        /// 合同签署失败时的跳转地址，如果不做单独配置，默认与redirect_url一致
        /// </summary>
        public string FailureRedirectUrl { get; set; }

        /// <summary>
        /// 上传文件的二进制流
        /// </summary>
        public FileItem FileContent { get; set; }

        /// <summary>
        /// 签署状态变更时的通知地址
        /// </summary>
        public string NoticeUrl { get; set; }

        /// <summary>
        /// 外部订单号
        /// </summary>
        public string OuterBizNo { get; set; }

        /// <summary>
        /// 签署成功后的重定向跳转地址
        /// </summary>
        public string RedirectUrl { get; set; }

        /// <summary>
        /// 签署平台: H5 或者 ALIPAY
        /// </summary>
        public string SignPlatform { get; set; }

        /// <summary>
        /// 合同用户列表
        /// </summary>
        public List<ContractUserInfo> UserList { get; set; }

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
            return "alipay.ebpp.industry.job.contract.create";
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
            parameters.Add("company_list", this.CompanyList);
            parameters.Add("failure_redirect_url", this.FailureRedirectUrl);
            parameters.Add("notice_url", this.NoticeUrl);
            parameters.Add("outer_biz_no", this.OuterBizNo);
            parameters.Add("redirect_url", this.RedirectUrl);
            parameters.Add("sign_platform", this.SignPlatform);
            parameters.Add("user_list", this.UserList);
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
