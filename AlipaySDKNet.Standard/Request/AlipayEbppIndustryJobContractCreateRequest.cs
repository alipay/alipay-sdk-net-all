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
        /// 用户身份证号码
        /// </summary>
        public string CertNo { get; set; }

        /// <summary>
        /// 企业信用代码或者营业执照注册号
        /// </summary>
        public string CompanyCertNo { get; set; }

        /// <summary>
        /// 企业名称
        /// </summary>
        public string CompanyName { get; set; }

        /// <summary>
        /// 上传文件的二进制流
        /// </summary>
        public FileItem FileContent { get; set; }

        /// <summary>
        /// 企业法人身份证号码
        /// </summary>
        public string LegalPersonCertNo { get; set; }

        /// <summary>
        /// 企业法人名称
        /// </summary>
        public string LegalPersonName { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        public string OpenId { get; set; }

        /// <summary>
        /// 外部订单号
        /// </summary>
        public string OuterBizNo { get; set; }

        /// <summary>
        /// 电子合同签署区配置，必须包含个人和企业两部分信息
        /// </summary>
        public List<ContractSignArea> SignArea { get; set; }

        /// <summary>
        /// 签署平台: H5 或者 ALIPAY
        /// </summary>
        public string SignPlatform { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        public string UserId { get; set; }

        /// <summary>
        /// 用户名称
        /// </summary>
        public string UserName { get; set; }

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
            parameters.Add("cert_no", this.CertNo);
            parameters.Add("company_cert_no", this.CompanyCertNo);
            parameters.Add("company_name", this.CompanyName);
            parameters.Add("legal_person_cert_no", this.LegalPersonCertNo);
            parameters.Add("legal_person_name", this.LegalPersonName);
            parameters.Add("open_id", this.OpenId);
            parameters.Add("outer_biz_no", this.OuterBizNo);
            parameters.Add("sign_area", this.SignArea);
            parameters.Add("sign_platform", this.SignPlatform);
            parameters.Add("user_id", this.UserId);
            parameters.Add("user_name", this.UserName);
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
