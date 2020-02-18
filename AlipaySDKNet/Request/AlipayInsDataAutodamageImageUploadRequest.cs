using System;
using System.Collections.Generic;
using Aop.Api.Response;
using Aop.Api.Util;

namespace Aop.Api.Request
{
    /// <summary>
    /// AOP API: alipay.ins.data.autodamage.image.upload
    /// </summary>
    public class AlipayInsDataAutodamageImageUploadRequest : IAopUploadRequest<AlipayInsDataAutodamageImageUploadResponse>
    {
        /// <summary>
        /// 业务单号，在存储上面用于做目录管理，图片都放到该目录下
        /// </summary>
        public string BizNo { get; set; }

        /// <summary>
        /// 业务类型，比如车险图像定损对应的是“1”
        /// </summary>
        public string BizType { get; set; }

        /// <summary>
        /// 图片二进制字节流
        /// </summary>
        public FileItem ImageContent { get; set; }

        /// <summary>
        /// 图像文件名称
        /// </summary>
        public string ImageName { get; set; }

        /// <summary>
        /// 图像格式类型，目前仅支持jpg格式
        /// </summary>
        public string ImageType { get; set; }

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
            return "alipay.ins.data.autodamage.image.upload";
        }

        public IDictionary<string, string> GetParameters()
        {
            AopDictionary parameters = new AopDictionary();
            parameters.Add("biz_no", this.BizNo);
            parameters.Add("biz_type", this.BizType);
            parameters.Add("image_name", this.ImageName);
            parameters.Add("image_type", this.ImageType);
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
