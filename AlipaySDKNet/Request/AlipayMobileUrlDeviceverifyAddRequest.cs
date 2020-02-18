using System;
using System.Collections.Generic;
using Aop.Api.Response;

namespace Aop.Api.Request
{
    /// <summary>
    /// AOP API: alipay.mobile.url.deviceverify.add
    /// </summary>
    public class AlipayMobileUrlDeviceverifyAddRequest : IAopRequest<AlipayMobileUrlDeviceverifyAddResponse>
    {
        /// <summary>
        /// 设备指纹id
        /// </summary>
        public string Apdid { get; set; }

        /// <summary>
        /// 应用版本号
        /// </summary>
        public string AppVersion { get; set; }

        /// <summary>
        /// 应用名
        /// </summary>
        public string Appid { get; set; }

        /// <summary>
        /// 集团统一id
        /// </summary>
        public string Hid { get; set; }

        /// <summary>
        /// 手机号码
        /// </summary>
        public string Mobile { get; set; }

        /// <summary>
        /// 统一sdk的版本
        /// </summary>
        public string SdkVersion { get; set; }

        /// <summary>
        /// 手淘设备ID
        /// </summary>
        public string Umid { get; set; }

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
            return "alipay.mobile.url.deviceverify.add";
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
            parameters.Add("apdid", this.Apdid);
            parameters.Add("app_version", this.AppVersion);
            parameters.Add("appid", this.Appid);
            parameters.Add("hid", this.Hid);
            parameters.Add("mobile", this.Mobile);
            parameters.Add("sdk_version", this.SdkVersion);
            parameters.Add("umid", this.Umid);
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
