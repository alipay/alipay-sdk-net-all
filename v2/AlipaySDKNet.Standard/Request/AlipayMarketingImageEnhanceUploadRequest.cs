using System;
using System.Collections.Generic;
using Aop.Api.Response;
using Aop.Api.Util;

namespace Aop.Api.Request
{
    /// <summary>
    /// AOP API: alipay.marketing.image.enhance.upload
    /// </summary>
    public class AlipayMarketingImageEnhanceUploadRequest : IAopUploadRequest<AlipayMarketingImageEnhanceUploadResponse>
    {
        /// <summary>
        /// 图片的byte字节数组。图片大小限制为5M。支持格式如下：png、jpg、jpeg、bmp、webp。
        /// </summary>
        public FileItem ImageContent { get; set; }

        /// <summary>
        /// 图片归属图空间目录id。不填时，默认归属到图空间根目录；填写时会保存到图片空间的目录id下；当图片需要保存到根目录下时传"0"。
        /// </summary>
        public string ImageDirectoryId { get; set; }

        /// <summary>
        /// 素材字段。本接口必须为图片类型的素材字段。
        /// </summary>
        public string MaterialField { get; set; }

        /// <summary>
        /// 素材规范ID，用于标识具体场景下的素材规范，根据具体的使用场景获取对应的素材规范ID。
        /// </summary>
        public string MaterialSpecId { get; set; }

        /// <summary>
        /// 表示是否需要优化图片。若选择需要优化图片，系统会根据原图进行优化，再根据素材规范校验；若选择不需要优化图片，系统对原图直接校验。校验通过则上传成功，校验不通过会返回具体错误原因。
        /// </summary>
        public Nullable<bool> NeedEnhance { get; set; }

        /// <summary>
        /// 图片上传场景，分为默认素材规范场景和介质图片场景。
        /// </summary>
        public string UploadScene { get; set; }

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
            return "alipay.marketing.image.enhance.upload";
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
            parameters.Add("image_directory_id", this.ImageDirectoryId);
            parameters.Add("material_field", this.MaterialField);
            parameters.Add("material_spec_id", this.MaterialSpecId);
            parameters.Add("need_enhance", this.NeedEnhance);
            parameters.Add("upload_scene", this.UploadScene);
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
            parameters.Add("image_content", this.ImageContent);
            return parameters;
        }

        #endregion
    }
}
