using System;
using Aop.Api.Domain;
using System.Collections.Generic;
using Aop.Api.Response;
using Aop.Api.Util;

namespace Aop.Api.Request
{
    /// <summary>
    /// AOP API: alipay.open.app.api.field.apply
    /// </summary>
    public class AlipayOpenAppApiFieldApplyRequest : IAopUploadRequest<AlipayOpenAppApiFieldApplyResponse>
    {
        /// <summary>
        /// 字段申请表单，其中api_name，field_name，package_code三个字段参数通过alipay.open.app.api.query接口查询获得，scene_code 则可通过alipay.open.app.api.scene.query接口查询获得。
        /// </summary>
        public AuthFieldApply AuthFieldApply { get; set; }

        /// <summary>
        /// 请上传应用使用图片必须包括如何登录、如何授权输出此字段、如何使用等内容。图片支持格式:png,jpg,jpeg,图片不超过10M。 video或picture_x不可同时为空，至少需传入1个。
        /// </summary>
        public FileItem Picture1 { get; set; }

        /// <summary>
        /// 请上传应用使用图片必须包括如何登录、如何授权输出此字段、如何使用等内容。图片支持格式:png,jpg,jpeg,图片不超过10M。 video或picture_x不可同时为空，至少需传入1个。
        /// </summary>
        public FileItem Picture2 { get; set; }

        /// <summary>
        /// 请上传应用使用图片必须包括如何登录、如何授权输出此字段、如何使用等内容。图片支持格式:png,jpg,jpeg,图片不超过10M。 video或picture_x不可同时为空，至少需传入1个。
        /// </summary>
        public FileItem Picture3 { get; set; }

        /// <summary>
        /// 请上传应用使用图片必须包括如何登录、如何授权输出此字段、如何使用等内容。图片支持格式:png,jpg,jpeg,图片不超过10M。 video或picture_x不可同时为空，至少需传入1个。
        /// </summary>
        public FileItem Picture4 { get; set; }

        /// <summary>
        /// 请上传应用使用图片必须包括如何登录、如何授权输出此字段、如何使用等内容。图片支持格式:png,jpg,jpeg,图片不超过10M。 video或picture_x不可同时为空，至少需传入1个。
        /// </summary>
        public FileItem Picture5 { get; set; }

        /// <summary>
        /// 请上传应用使用视频，必须包括如何登录、如何授权输出此字段、如何使用等内容。视频支持格式:MP4,视频不超过10M。 video或picture_x不可同时为空，至少需传入1个。
        /// </summary>
        public FileItem Video { get; set; }

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
            return "alipay.open.app.api.field.apply";
        }

        public IDictionary<string, string> GetParameters()
        {
            AopDictionary parameters = new AopDictionary();
            parameters.Add("auth_field_apply", this.AuthFieldApply);
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
            parameters.Add("picture_1", this.Picture1);
            parameters.Add("picture_2", this.Picture2);
            parameters.Add("picture_3", this.Picture3);
            parameters.Add("picture_4", this.Picture4);
            parameters.Add("picture_5", this.Picture5);
            parameters.Add("video", this.Video);
            return parameters;
        }

        #endregion
    }
}
