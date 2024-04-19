using System;
using System.Collections.Generic;
using Aop.Api.Response;

namespace Aop.Api.Request
{
    /// <summary>
    /// AOP API: alipay.ebpp.pdeduct.bill.pay.status
    /// </summary>
    public class AlipayEbppPdeductBillPayStatusRequest : IAopRequest<AlipayEbppPdeductBillPayStatusResponse>
    {
        /// <summary>
        /// 支付宝用户ID
        /// </summary>
        public string AgreementId { get; set; }

        /// <summary>
        /// 用户UserId在应用AppId下的唯一用户标识
        /// </summary>
        public string OpenId { get; set; }

        /// <summary>
        /// 商户代扣业务流水
        /// </summary>
        public string OutOrderNo { get; set; }

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
            return "alipay.ebpp.pdeduct.bill.pay.status";
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
            parameters.Add("agreement_id", this.AgreementId);
            parameters.Add("open_id", this.OpenId);
            parameters.Add("out_order_no", this.OutOrderNo);
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
