using System;
using System.Collections.Generic;
using Aop.Api.Response;
using Aop.Api.Util;

namespace Aop.Api.Request
{
    /// <summary>
    /// AOP API: alipay.open.mini.ampe.enter.apply
    /// </summary>
    public class AlipayOpenMiniAmpeEnterApplyRequest : IAopUploadRequest<AlipayOpenMiniAmpeEnterApplyResponse>
    {
        /// <summary>
        /// 详细地址
        /// </summary>
        public string Address { get; set; }

        /// <summary>
        /// 联系人邮箱
        /// </summary>
        public string ContactEmail { get; set; }

        /// <summary>
        /// 联系人姓名
        /// </summary>
        public string ContactName { get; set; }

        /// <summary>
        /// 联系人手机号
        /// </summary>
        public string ContactPhone { get; set; }

        /// <summary>
        /// 厂商名称，必填，最大长度为128
        /// </summary>
        public string EnterpriseName { get; set; }

        /// <summary>
        /// 介绍资料，选填，最小为1k，最大不能超过10MB，文件格式支持zip，rar，jpg，png，doc，docx，pdf
        /// </summary>
        public FileItem IntroductionFile { get; set; }

        /// <summary>
        /// 企业营业执照照片二进制流，必填，最小为1k，最大不能超过5MB，图片格式支持jpg，png
        /// </summary>
        public FileItem LicensePic { get; set; }

        /// <summary>
        /// 主营产品信息，选填
        /// </summary>
        public string MajorProducts { get; set; }

        /// <summary>
        /// 企业官网，选填，最大长度为128
        /// </summary>
        public string OfficialWebsite { get; set; }

        /// <summary>
        /// 场景码，申请后平台分配，必填
        /// </summary>
        public string SceneCode { get; set; }

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
            return "alipay.open.mini.ampe.enter.apply";
        }

        public IDictionary<string, string> GetParameters()
        {
            AopDictionary parameters = new AopDictionary();
            parameters.Add("address", this.Address);
            parameters.Add("contact_email", this.ContactEmail);
            parameters.Add("contact_name", this.ContactName);
            parameters.Add("contact_phone", this.ContactPhone);
            parameters.Add("enterprise_name", this.EnterpriseName);
            parameters.Add("major_products", this.MajorProducts);
            parameters.Add("official_website", this.OfficialWebsite);
            parameters.Add("scene_code", this.SceneCode);
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
            parameters.Add("introduction_file", this.IntroductionFile);
            parameters.Add("license_pic", this.LicensePic);
            return parameters;
        }

        #endregion
    }
}
