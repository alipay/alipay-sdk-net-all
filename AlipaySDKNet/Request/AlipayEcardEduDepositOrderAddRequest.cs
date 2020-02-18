using System;
using System.Collections.Generic;
using Aop.Api.Response;

namespace Aop.Api.Request
{
    /// <summary>
    /// AOP API: alipay.ecard.edu.deposit.order.add
    /// </summary>
    public class AlipayEcardEduDepositOrderAddRequest : IAopRequest<AlipayEcardEduDepositOrderAddResponse>
    {
        /// <summary>
        /// 校园一卡通机构
        /// </summary>
        public string AgentCode { get; set; }

        /// <summary>
        /// 公众账号协议Id
        /// </summary>
        public string AgreementId { get; set; }

        /// <summary>
        /// 支付宝userId
        /// </summary>
        public string AlipayUserId { get; set; }

        /// <summary>
        /// 校园一卡通帐户姓名
        /// </summary>
        public string CardName { get; set; }

        /// <summary>
        /// 校园一卡通号码
        /// </summary>
        public string CardNo { get; set; }

        /// <summary>
        /// 校园一卡通充值金额
        /// </summary>
        public string DepositAmount { get; set; }

        /// <summary>
        /// 成功充值通知手机号码
        /// </summary>
        public string MobileNo { get; set; }

        /// <summary>
        /// 公众平台ID
        /// </summary>
        public string PublicId { get; set; }

        /// <summary>
        /// 是否分享手机号码
        /// </summary>
        public string ShareMobileNo { get; set; }

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
            return "alipay.ecard.edu.deposit.order.add";
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
            parameters.Add("agent_code", this.AgentCode);
            parameters.Add("agreement_id", this.AgreementId);
            parameters.Add("alipay_user_id", this.AlipayUserId);
            parameters.Add("card_name", this.CardName);
            parameters.Add("card_no", this.CardNo);
            parameters.Add("deposit_amount", this.DepositAmount);
            parameters.Add("mobile_no", this.MobileNo);
            parameters.Add("public_id", this.PublicId);
            parameters.Add("share_mobile_no", this.ShareMobileNo);
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
