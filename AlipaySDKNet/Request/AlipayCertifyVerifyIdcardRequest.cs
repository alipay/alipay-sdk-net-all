using System;
using System.Collections.Generic;
using Aop.Api.Response;

namespace Aop.Api.Request
{
    /// <summary>
    /// AOP API: alipay.certify.verify.idcard
    /// </summary>
    public class AlipayCertifyVerifyIdcardRequest : IAopRequest<AlipayCertifyVerifyIdcardResponse>
    {
        /// <summary>
        /// 访问来源，业务系统 用于结算
        /// </summary>
        public string BizFrom { get; set; }

        /// <summary>
        /// 业务主体ID 如userId
        /// </summary>
        public string BizId { get; set; }

        /// <summary>
        /// 证件姓名
        /// </summary>
        public string CertName { get; set; }

        /// <summary>
        /// 身份证号码
        /// </summary>
        public string CertNo { get; set; }

        /// <summary>
        /// 认证来源 : 业务BU,如网商银行
        /// </summary>
        public string CertifyFrom { get; set; }

        /// <summary>
        /// Y强制查官网，N缺省，先查本地后官网
        /// </summary>
        public string ForcePublic { get; set; }

        #region IAopRequest Members
		private bool  needEncrypt=false;
        private string apiVersion = "1.0";
		private string terminalType;
		private string terminalInfo;
        private string prodCode;
		private string notifyUrl;
        private string returnUrl;
		private AopObject bizModel;

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
            return "alipay.certify.verify.idcard";
        }

        public void SetApiVersion(string apiVersion){
            this.apiVersion=apiVersion;
        }

        public string GetApiVersion(){
            return this.apiVersion;
        }

        public IDictionary<string, string> GetParameters()
        {
            AopDictionary parameters = new AopDictionary();
            parameters.Add("biz_from", this.BizFrom);
            parameters.Add("biz_id", this.BizId);
            parameters.Add("cert_name", this.CertName);
            parameters.Add("cert_no", this.CertNo);
            parameters.Add("certify_from", this.CertifyFrom);
            parameters.Add("force_public", this.ForcePublic);
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
