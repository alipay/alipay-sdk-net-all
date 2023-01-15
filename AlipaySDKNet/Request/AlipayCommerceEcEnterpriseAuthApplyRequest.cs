using System;
using System.Collections.Generic;
using Aop.Api.Response;

namespace Aop.Api.Request
{
    /// <summary>
    /// AOP API: alipay.commerce.ec.enterprise.auth.apply
    /// </summary>
    public class AlipayCommerceEcEnterpriseAuthApplyRequest : IAopRequest<AlipayCommerceEcEnterpriseAuthApplyResponse>
    {
        /// <summary>
        /// 统一社会信用代码
        /// </summary>
        public string EnterpriseCode { get; set; }

        /// <summary>
        /// 企业ID
        /// </summary>
        public string EnterpriseId { get; set; }

        /// <summary>
        /// 企业名称
        /// </summary>
        public string EnterpriseName { get; set; }

        /// <summary>
        /// 营业执照文件ID
        /// </summary>
        public string FileId { get; set; }

        /// <summary>
        /// 法人身份证号
        /// </summary>
        public string LegalIdNumber { get; set; }

        /// <summary>
        /// 法人姓名
        /// </summary>
        public string LegalName { get; set; }

        /// <summary>
        /// 营业执照截止日期，时间格式：yyyy-MM-dd
        /// </summary>
        public string LicenseEndDate { get; set; }

        #region IAopRequest Members
        private bool  needEncrypt=false;
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

        public string GetApiName()
        {
            return "alipay.commerce.ec.enterprise.auth.apply";
        }

        public void SetApiVersion(string apiVersion){
            this.apiVersion=apiVersion;
        }

        public string GetApiVersion(){
            return this.apiVersion;
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
            parameters.Add("enterprise_code", this.EnterpriseCode);
            parameters.Add("enterprise_id", this.EnterpriseId);
            parameters.Add("enterprise_name", this.EnterpriseName);
            parameters.Add("file_id", this.FileId);
            parameters.Add("legal_id_number", this.LegalIdNumber);
            parameters.Add("legal_name", this.LegalName);
            parameters.Add("license_end_date", this.LicenseEndDate);
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
    }
}
