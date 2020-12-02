using System;
using System.Collections.Generic;
using Aop.Api.Response;
using Aop.Api.Util;

namespace Aop.Api.Request
{
    /// <summary>
    /// AOP API: alipay.open.mini.baseinfo.modify
    /// </summary>
    public class AlipayOpenMiniBaseinfoModifyRequest : IAopUploadRequest<AlipayOpenMiniBaseinfoModifyResponse>
    {
        /// <summary>
        /// 11_12;12_13。小程序类目，格式为 第一个一级类目_第一个二级类目;第二个一级类目_第二个二级类目，详细类目可以参考https://docs.open.alipay.com/api_49/alipay.open.mini.category.query接口查询mini_category_list 。
        /// </summary>
        public string AppCategoryIds { get; set; }

        /// <summary>
        /// 小程序应用描述，20-200个字。若小程序应用未设置该项内容时必传，若小程序应用已设置且无需修改则无需传入。
        /// </summary>
        public string AppDesc { get; set; }

        /// <summary>
        /// 小程序应用英文名称。若小程序应用未设置该项内容时必传，若小程序应用已设置且无需修改则无需传入。
        /// </summary>
        public string AppEnglishName { get; set; }

        /// <summary>
        /// 小程序应用logo图标，图片格式必须为：png、jpeg、jpg，建议上传像素为180*180。 若小程序应用未设置该项内容时必传，若小程序应用已设置且无需修改则无需传入。
        /// </summary>
        public FileItem AppLogo { get; set; }

        /// <summary>
        /// 小程序应用名称。若小程序应用未设置该项内容时必传，若小程序应用已设置且无需修改则无需传入。
        /// </summary>
        public string AppName { get; set; }

        /// <summary>
        /// 小程序应用简介，一句话描述小程序功能。若小程序应用未设置该项内容时必传，若小程序应用已设置且无需修改则无需传入。
        /// </summary>
        public string AppSlogan { get; set; }

        /// <summary>
        /// 新小程序前台类目。格式为 第一个一级类目_第一个二级类目;第二个一级类目_第二个二级类目_第二个三级类目。详细类目可以通过 https://docs.open.alipay.com/api_49/alipay.open.mini.category.query接口查询mini_category_list。 如需申请用户信息则该项必填，否则应用后台不会展示用户信息申请入口；通过接口申请用户信息会被直接驳回。
        /// </summary>
        public string MiniCategoryIds { get; set; }

        /// <summary>
        /// 小程序客服邮箱。若小程序应用未设置该项内容时必传，若小程序应用已设置且无需修改则无需传入。
        /// </summary>
        public string ServiceEmail { get; set; }

        /// <summary>
        /// 小程序客服电话。若小程序应用未设置该项内容时必传，若小程序应用已设置且无需修改则无需传入。
        /// </summary>
        public string ServicePhone { get; set; }

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
            return "alipay.open.mini.baseinfo.modify";
        }

        public IDictionary<string, string> GetParameters()
        {
            AopDictionary parameters = new AopDictionary();
            parameters.Add("app_category_ids", this.AppCategoryIds);
            parameters.Add("app_desc", this.AppDesc);
            parameters.Add("app_english_name", this.AppEnglishName);
            parameters.Add("app_name", this.AppName);
            parameters.Add("app_slogan", this.AppSlogan);
            parameters.Add("mini_category_ids", this.MiniCategoryIds);
            parameters.Add("service_email", this.ServiceEmail);
            parameters.Add("service_phone", this.ServicePhone);
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
            parameters.Add("app_logo", this.AppLogo);
            return parameters;
        }

        #endregion
    }
}
