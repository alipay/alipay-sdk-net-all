using System;
using System.Collections.Generic;
using Aop.Api.Response;

namespace Aop.Api.Request
{
    /// <summary>
    /// AOP API: alipay.gotone.message.courier.send
    /// </summary>
    public class AlipayGotoneMessageCourierSendRequest : IAopRequest<AlipayGotoneMessageCourierSendResponse>
    {
        /// <summary>
        /// 模板参数,键值对，以竖线分割
        /// </summary>
        public string Arguments { get; set; }

        /// <summary>
        /// 扩展信息。IMEI表示钱包客户端IMEI号；CURRENT_STEP表示消息进度节点,必须为数字； IS_CORRECT表示当前节点是正常还是异常分支，必须为Y或者N; todoPublicId表示钱包公众号id。注意：上诉key值必须严格匹配，大小写敏感
        /// </summary>
        public string ExtInfo { get; set; }

        /// <summary>
        /// 业务配置码serviceCode
        /// </summary>
        public string ServiceCode { get; set; }

        /// <summary>
        /// 用户的支付宝ID
        /// </summary>
        public string UserId { get; set; }

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
            return "alipay.gotone.message.courier.send";
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
            parameters.Add("arguments", this.Arguments);
            parameters.Add("ext_info", this.ExtInfo);
            parameters.Add("service_code", this.ServiceCode);
            parameters.Add("user_id", this.UserId);
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
