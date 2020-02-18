using System;
using System.Collections.Generic;
using Aop.Api.Response;
using Aop.Api.Util;

namespace Aop.Api.Request
{
    /// <summary>
    /// AOP API: alipay.marketing.campaign.rule.tag.create
    /// </summary>
    public class AlipayMarketingCampaignRuleTagCreateRequest : IAopUploadRequest<AlipayMarketingCampaignRuleTagCreateResponse>
    {
        /// <summary>
        /// 每行格式如下的csv文件，以,隔开，文件最大50M  2088004384251514,2088102344258114,13888888888,aaa@bbb.com,34032198407138000,北京市海淀区  分别意义：16位随机数字,userid,手机号码,邮件地址,身份证号,地区
        /// </summary>
        public FileItem Customerdata { get; set; }

        /// <summary>
        /// 签约商户下属子机构唯一编号
        /// </summary>
        public string Mpid { get; set; }

        /// <summary>
        /// 针对自定义人群的操作，可以创建或者删除，当创建时，自定义标签可为空
        /// </summary>
        public string Operatetype { get; set; }

        /// <summary>
        /// 自定义标签id，创建时可为空
        /// </summary>
        public string Selftag { get; set; }

        /// <summary>
        /// 自定义人群标签的描述信息（操作为CREATE时使用）
        /// </summary>
        public string Tagdesc { get; set; }

        #region IAopRequest Members
		private bool needEncrypt=false;
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

		public void SetApiVersion(string apiVersion){
            this.apiVersion=apiVersion;
        }

        public string GetApiVersion(){
            return this.apiVersion;
        }

        public string GetApiName()
        {
            return "alipay.marketing.campaign.rule.tag.create";
        }

        public IDictionary<string, string> GetParameters()
        {
            AopDictionary parameters = new AopDictionary();
            parameters.Add("mpid", this.Mpid);
            parameters.Add("operatetype", this.Operatetype);
            parameters.Add("selftag", this.Selftag);
            parameters.Add("tagdesc", this.Tagdesc);
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
            parameters.Add("customerdata", this.Customerdata);
            return parameters;
        }

        #endregion
    }
}
