using System;
using System.Collections.Generic;
using Aop.Api.Response;

namespace Aop.Api.Request
{
    /// <summary>
    /// AOP API: alipay.ebpp.recharge.item.get
    /// </summary>
    public class AlipayEbppRechargeItemGetRequest : IAopRequest<AlipayEbppRechargeItemGetResponse>
    {
        /// <summary>
        /// 支付宝id
        /// </summary>
        public string CardNo { get; set; }

        /// <summary>
        /// 商品上架、下架状态  1/0
        /// </summary>
        public string IsForSale { get; set; }

        /// <summary>
        /// 1000|2000|3000 可以传递多个以|线分开
        /// </summary>
        public string ItemCode { get; set; }

        /// <summary>
        /// 0001：手机话费充值;0002 Q币充值；0003公交卡充值;0004流量充值
        /// </summary>
        public string ItemCodeType { get; set; }

        /// <summary>
        /// 业务类型例如：TX
        /// </summary>
        public string OrderType { get; set; }

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
            return "alipay.ebpp.recharge.item.get";
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
            parameters.Add("card_no", this.CardNo);
            parameters.Add("is_for_sale", this.IsForSale);
            parameters.Add("item_code", this.ItemCode);
            parameters.Add("item_code_type", this.ItemCodeType);
            parameters.Add("order_type", this.OrderType);
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
