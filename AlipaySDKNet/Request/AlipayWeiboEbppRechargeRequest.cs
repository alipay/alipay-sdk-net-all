using System;
using System.Collections.Generic;
using Aop.Api.Response;

namespace Aop.Api.Request
{
    /// <summary>
    /// AOP API: alipay.weibo.ebpp.recharge
    /// </summary>
    public class AlipayWeiboEbppRechargeRequest : IAopRequest<AlipayWeiboEbppRechargeResponse>
    {
        /// <summary>
        /// 商户用户的设备信息
        /// </summary>
        public string ApdId { get; set; }

        /// <summary>
        /// 手机位置信息
        /// </summary>
        public string CellId { get; set; }

        /// <summary>
        /// device_info_token
        /// </summary>
        public string DeviceInfoToken { get; set; }

        /// <summary>
        /// 商户输入的扩展信息
        /// </summary>
        public string Exparam { get; set; }

        /// <summary>
        /// 终端设备号
        /// </summary>
        public string Imei { get; set; }

        /// <summary>
        /// 商户用户的ip信息
        /// </summary>
        public string Ip { get; set; }

        /// <summary>
        /// 基站LAC
        /// </summary>
        public string LacId { get; set; }

        /// <summary>
        /// 免登来源
        /// </summary>
        public string LoginFrom { get; set; }

        /// <summary>
        /// 设备mac信息
        /// </summary>
        public string Mac { get; set; }

        /// <summary>
        /// 商户的用户Id
        /// </summary>
        public string PartnerUserId { get; set; }

        /// <summary>
        /// 设备的安全支付标识
        /// </summary>
        public string Tid { get; set; }

        /// <summary>
        /// 商户免登Token
        /// </summary>
        public string Token { get; set; }

        /// <summary>
        /// 设备umid信息
        /// </summary>
        public string Umid { get; set; }

        /// <summary>
        /// wireless_mac
        /// </summary>
        public string WirelessMac { get; set; }

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
            return "alipay.weibo.ebpp.recharge";
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
            parameters.Add("apd_id", this.ApdId);
            parameters.Add("cell_id", this.CellId);
            parameters.Add("device_info_token", this.DeviceInfoToken);
            parameters.Add("exparam", this.Exparam);
            parameters.Add("imei", this.Imei);
            parameters.Add("ip", this.Ip);
            parameters.Add("lac_id", this.LacId);
            parameters.Add("login_from", this.LoginFrom);
            parameters.Add("mac", this.Mac);
            parameters.Add("partner_user_id", this.PartnerUserId);
            parameters.Add("tid", this.Tid);
            parameters.Add("token", this.Token);
            parameters.Add("umid", this.Umid);
            parameters.Add("wireless_mac", this.WirelessMac);
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
