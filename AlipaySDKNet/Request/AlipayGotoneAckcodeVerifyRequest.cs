using System;
using System.Collections.Generic;
using Aop.Api.Response;

namespace Aop.Api.Request
{
    /// <summary>
    /// AOP API: alipay.gotone.ackcode.verify
    /// </summary>
    public class AlipayGotoneAckcodeVerifyRequest : IAopRequest<AlipayGotoneAckcodeVerifyResponse>
    {
        /// <summary>
        /// 校验码
        /// </summary>
        public string AckCode { get; set; }

        /// <summary>
        /// 区分相同的手机号、业务类型，但不同业务场景的手机校验码等情况校验。比如使用order_n
        /// </summary>
        public string BizNo { get; set; }

        /// <summary>
        /// 手机校验码业务类型，为空默认DEFAULT_TYPE
        /// </summary>
        public string BizType { get; set; }

        /// <summary>
        /// 接收校验码短信手机号
        /// </summary>
        public string Mobile { get; set; }

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
            return "alipay.gotone.ackcode.verify";
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
            parameters.Add("ack_code", this.AckCode);
            parameters.Add("biz_no", this.BizNo);
            parameters.Add("biz_type", this.BizType);
            parameters.Add("mobile", this.Mobile);
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
