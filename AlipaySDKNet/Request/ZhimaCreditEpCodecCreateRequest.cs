using System;
using System.Collections.Generic;
using Aop.Api.Response;
using Aop.Api.Util;

namespace Aop.Api.Request
{
    /// <summary>
    /// AOP API: zhima.credit.ep.codec.create
    /// </summary>
    public class ZhimaCreditEpCodecCreateRequest : IAopUploadRequest<ZhimaCreditEpCodecCreateResponse>
    {
        /// <summary>
        /// 商户端保持自有渠道id所对应商户的唯一性
        /// </summary>
        public string ChannelId { get; set; }

        /// <summary>
        /// 支持中文名，最长50个字符
        /// </summary>
        public string ChannelName { get; set; }

        /// <summary>
        /// 主图背景图二进制数据
        /// </summary>
        public FileItem ContentImg { get; set; }

        /// <summary>
        /// 跳转页URL
        /// </summary>
        public string GotoUrl { get; set; }

        /// <summary>
        /// logo图片二进制数据
        /// </summary>
        public FileItem LogoImg { get; set; }

        /// <summary>
        /// 推广子文案
        /// </summary>
        public string Subtitle { get; set; }

        /// <summary>
        /// 推广主文案，限20个中文字符以内
        /// </summary>
        public string Title { get; set; }

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
            return "zhima.credit.ep.codec.create";
        }

        public IDictionary<string, string> GetParameters()
        {
            AopDictionary parameters = new AopDictionary();
            parameters.Add("channel_id", this.ChannelId);
            parameters.Add("channel_name", this.ChannelName);
            parameters.Add("goto_url", this.GotoUrl);
            parameters.Add("subtitle", this.Subtitle);
            parameters.Add("title", this.Title);
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
            parameters.Add("content_img", this.ContentImg);
            parameters.Add("logo_img", this.LogoImg);
            return parameters;
        }

        #endregion
    }
}
