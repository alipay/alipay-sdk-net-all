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
        /// 11_12;12_13。小程序类目，格式为 第一个一级类目_第一个二级类目;第二个一级类目_第二个二级类目，详细类目可以参考<a href="https://docs.open.alipay.com/api_49/alipay.open.mini.category.query">https://docs.open.alipay.com/api_49/alipay.open.mini.category.query</a>接口查询mini_category_list 。
        /// </summary>
        public string AppCategoryIds { get; set; }

        /// <summary>
        /// 小程序描述，长度限制 20~400 个字符。 如果前期已经设置过该信息，本次可不填，平台将会为你默认上传该信息。如果前期没有设置过该信息，则本次为必填。可通过<a href="https://opendocs.alipay.com/mini/03l21r">https://opendocs.alipay.com/mini/03l21r</a>查询当前小程序信息
        /// </summary>
        public string AppDesc { get; set; }

        /// <summary>
        /// 小程序应用英文名称。长度限制 3~30 个字符，仅支持包含中文、数字、英文、下划线、+、-。 如果前期已经设置过该信息，本次可不填，平台将会为你默认上传该信息。如果前期没有设置过该信息，则本次为必填。可通过<a href="https://opendocs.alipay.com/mini/03l21r?pathHash=36d314be&scene=common">alipay.open.mini.baseinfo.query</a>查询当前小程序信息
        /// </summary>
        public string AppEnglishName { get; set; }

        /// <summary>
        /// 小程序logo图标，图片格式仅支持 jpeg,png,jpg,PNG,JPG ,JPEG格式，不支持 bmp,gif,BMP,GIF格式。建议上传像素为180*180 px，logo图片最大 2M，图片高度与宽度必须一致。 如果不填默认采用当前小程序 logo 图标。如果前期已经设置过该信息，本次可不填，平台将会为你默认上传该信息。如果前期没有设置过该信息，则本次为必填。
        /// </summary>
        public FileItem AppLogo { get; set; }

        /// <summary>
        /// 小程序名称。长度限制 3~30 个字符，仅支持包含中文、数字、英文、下划线、+、-。 如果前期已经设置过该信息，本次可不填，平台将会为你默认上传该信息。如果前期没有设置过该信息，则本次为必填。可通过<a href="https://opendocs.alipay.com/mini/03l21r?pathHash=36d314be&scene=common ">alipay.open.mini.baseinfo.query</a>查询当前小程序信息
        /// </summary>
        public string AppName { get; set; }

        /// <summary>
        /// 小程序简介，一句话描述小程序功能，长度限制 10~32个字符。 如果前期已经设置过该信息，本次可不填，平台将会为你默认上传该信息。如果前期没有设置过该信息，则本次为必填。可通过<a href="https://opendocs.alipay.com/mini/03l21r?pathHash=36d314be&scene=common">alipay.open.mini.baseinfo.query</a>查询当前小程序信息
        /// </summary>
        public string AppSlogan { get; set; }

        /// <summary>
        /// 新小程序前台类目，格式为 第一个一级类目_第一个二级类目;第二个一级类目_第二个二级类目_第二个三级类目，详细类目可以通过 <a href="https://docs.open.alipay.com/api_49/alipay.open.mini.category.query">https://docs.open.alipay.com/api_49/alipay.open.mini.category.query</a> 接口查询mini_category_list。 如果前期已经设置过该信息，本次可不填，平台将会为你默认上传该信息。如果前期没有设置过该信息，则本次为必填。可通过<a href="https://opendocs.alipay.com/mini/03l21r">https://opendocs.alipay.com/mini/03l21r</a>查询当前小程序信息 注意：个人开发者不得使用企业类目。
        /// </summary>
        public string MiniCategoryIds { get; set; }

        /// <summary>
        /// 小程序客服邮箱，如果不填默认采用当前小程序的应用客服邮箱，小程序客服电话和邮箱至少输入一个。如果前期已经设置过该信息，本次可不填，平台将会为你默认上传该信息。 注意：2021年7月1日后，该字段将逐步灰度为可选字段，请按可选开发。
        /// </summary>
        public string ServiceEmail { get; set; }

        /// <summary>
        /// 小程序客服电话，长度限制5~30个字符，仅支持包含数字和-。如果不填默认采用当前小程序的应用客服电话，小程序客服电话和邮箱至少输入一个。如果前期已经设置过该信息，本次可不填，平台将会为你默认上传该信息。 注意：2021年7月1日后，该字段将逐步灰度为必填字段，请按必填开发。
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
            parameters.Add("app_category_ids", this.AppCategoryIds);
            parameters.Add("app_desc", this.AppDesc);
            parameters.Add("app_english_name", this.AppEnglishName);
            parameters.Add("app_name", this.AppName);
            parameters.Add("app_slogan", this.AppSlogan);
            parameters.Add("mini_category_ids", this.MiniCategoryIds);
            parameters.Add("service_email", this.ServiceEmail);
            parameters.Add("service_phone", this.ServicePhone);
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
